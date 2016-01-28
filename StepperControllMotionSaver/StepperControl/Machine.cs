using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// MODBUS-RTU Lib
using Modbus;
using Modbus.Data;
using Modbus.IO;
using Modbus.Device;
using System.IO.Ports;

namespace StepperControl
{
    class Machine
    {

        private SerialPort plcPort = null;

        private bool isConnected = false;

        private IModbusMaster master = null;

        public bool IsMoveing
        {
            get
            {
                if (this.isConnected)
                {
                    ushort[] plcData = this.master.ReadHoldingRegisters(this.ID, 0, 0);

                    return plcData[0] == 1;
                }

                return false;
            }
        }

        public bool IsConnected
        {
            get
            {
                return this.isConnected;
            }
        }

        public byte ID
        {
            get;
            private set;
        }


        public Machine(string portName, byte id)
        {
            this.ID = id;

            this.plcPort = new SerialPort(portName);
            this.plcPort.BaudRate = 115200;
            this.plcPort.DataBits = 8;
            this.plcPort.StopBits = StopBits.One;
            this.plcPort.Parity = Parity.Even;

            this.master = ModbusSerialMaster.CreateRtu(this.plcPort);
        }

        #region Connect / Disconect

        /// <summary>
        /// Connect to the robot.
        /// </summary>
        public void Connect()
        {
            if (this.plcPort != null)
            {
                this.plcPort.Open();

                if (this.plcPort.IsOpen)
                {
                    this.isConnected = true;
                }
            }
        }

        /// <summary>
        /// Disconnect from the robot.
        /// </summary>
        public void Disconect()
        {
            if (this.plcPort != null)
            {
                if (this.plcPort.IsOpen)
                {
                    this.plcPort.Close();
                    this.isConnected = false;
                }
            }
        }

        #endregion

        public void DriveMotor(ushort steps, ushort freq)
        {
            if(this.isConnected)
            {
                ushort[] plcData = new ushort[] { 1, steps, freq };
                this.master.WriteMultipleRegisters(this.ID, 0, plcData);
            }
        }
    }
}
