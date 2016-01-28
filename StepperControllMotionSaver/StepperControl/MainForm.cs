using StepperControl.Commands;
using System;
using System.IO.Ports;
using System.Windows.Forms;
using StepperControl.Messages;
using System.IO;

namespace StepperControl
{
    public partial class MainForm : Form
    {

        #region Varibles

        /// <summary>
        /// Decimal separator depending of the culture.
        /// </summary>
        private static char DecimalSeparator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

        /// <summary>
        /// Name of the serial port.
        /// </summary>
        private string portName = String.Empty;

        /// <summary>
        /// The machine.
        /// </summary>
        private Machine macine = null;

        private string programName = String.Empty;

        private ProgramController programControl = new ProgramController();

        #endregion

        #region Constructor

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Methods

        private void SearchForPorts()
        {
            this.cbPorts.Items.Clear();

            string[] portNames = SerialPort.GetPortNames();

            if (portNames.Length == 0)
            {
                this.cbPorts.Text = "No Ports";
                return;
            }

            this.cbPorts.DataSource = portNames;
            this.cbPorts.Text = cbPorts.Items[0].ToString();
        }

        public void Connect()
        {
            try
            {
                if (this.macine != null && this.macine.IsConnected)
                {
                    return;
                }

                this.macine = new Machine(this.portName, 1);
                this.macine.Connect();

                this.programControl.OnExecutionIndexCanged += this.programControl_OnExecutionIndexChanged;

                string mesage = String.Format("Connected @ {0}", this.portName);
                this.AddLogRow(mesage);
            }
            catch(Exception exception)
            {
                this.AddLogRow(exception.ToString());
            }
        }

        public void Disconnect()
        {
            try
            {
                if (this.macine != null && this.macine.IsConnected)
                {
                    this.macine.Disconect();

                    string mesage = String.Format("Dissconnected @ {0}", this.portName);
                    this.AddLogRow(mesage);
                }
            }
            catch (Exception exception)
            {
                this.AddLogRow(exception.ToString());
            }
        }

        private void AddLogRow(string message)
        {
            tbStatus.AppendText(message);
            tbStatus.AppendText(Environment.NewLine);
        }

        private void RunProgram()
        {
            if (!this.programControl.IsRuning && this.macine != null && this.macine.IsConnected)
            {
                this.programControl.RunProgram();
            }
        }

        private void ResumeProgram()
        {
            if (!this.programControl.IsRuning)
            {
                this.programControl.ResumeProgram();
            }
        }

        private void StopProgram()
        {
            if (this.programControl.IsRuning && this.macine != null && this.macine.IsConnected)
            {
                this.programControl.StopProgram();
            }
        }

        private void SetProgramIndex(int index)
        {
            if (this.lstCommands.InvokeRequired)
            {
                this.lstCommands.BeginInvoke((MethodInvoker)delegate()
                {
                    if (index > 0 && index < this.lstCommands.Items.Count)
                    {
                        // Select the program row.
                        this.lstCommands.SelectedIndex = index;
                    }
                });
            }
            else
            {
                if (index > 0 && index < this.lstCommands.Items.Count)
                {
                    // Select the program row.
                    this.lstCommands.SelectedIndex = index;
                }
            }
        }

        private void SaveProgram()
        {
            // Create an instance of the open file dialog box.
            SaveFileDialog fileDialog = new SaveFileDialog();

            // Set filter options and filter index.
            fileDialog.Filter = "XML Files (.xml)|*.xml|All Files (*.*)|*.*";
            fileDialog.FilterIndex = 1;

            if (this.programName == "")
            {
                this.programName = AppUtils.CreateProgramName();
            }

            fileDialog.FileName = this.programName;
            //fileDialog.Multiselect = false;

            // Show the dialog and get result.
            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK && this.programControl.Commands.Count > 0) // Test result.
            {
                string path = fileDialog.FileName;
                CommandsStore.Save(this.programControl.Commands, path);
            }
        }

        private void LoadProgram()
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog fileDialog = new OpenFileDialog();

            // Set filter options and filter index.
            fileDialog.Filter = "XML Files (.xml)|*.xml|All Files (*.*)|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.Multiselect = false;

            // Show the dialog and get result.
            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK) // Test result.
            {
                string path = fileDialog.FileName;
                MotionCommands commands = CommandsStore.Load(path);

                if (commands != null && commands.Count > 0)
                {

                    this.programControl.Commands = commands;

                    this.lstCommands.Items.Clear();
                    MotionCommand[] test = new MotionCommand[this.programControl.Commands.Count];
                    this.programControl.Commands.CopyTo(test, 0);
                    this.lstCommands.Items.AddRange(test);
                }

                this.programName = Path.GetFileNameWithoutExtension(path);

                this.lblProgramName.Text = String.Format("Program: {0}", this.programName);
            }
        }


        #endregion

        #region Buttons

        private void btnConnect_Click(object sender, EventArgs e)
        {
           this.Connect();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            this.Disconnect();
        }


        private void btnCW_Click(object sender, EventArgs e)
        {
            // TODO: Send command to PLC for clock ways direction motion with parameters in the text boxes.

            if (this.macine == null)
            {
                return;
            }

            // S = V * t
            // S - Speed    [s/sec] (1 / 5000) / 1
            // V - Velocity [s]
            // t - Time     [sec]

            // t = S / V
            // t = (1 / 5000) / V

            float stepsCount = 0.0f;
            float.TryParse(AppUtils.CorrectDecDelimiter(this.tbStepsCount.Text), out stepsCount);

            float posScale = stepsCount / 360.0f;

            float degreeSetPosition = 0.0f;
            float.TryParse(AppUtils.CorrectDecDelimiter(this.tbPosition.Text), out degreeSetPosition);

            float steps = degreeSetPosition * posScale;
            steps = (float)Math.Round(steps, 0);

            float speed = 0.0f;
            float.TryParse(AppUtils.CorrectDecDelimiter(this.tbSpeed.Text), out speed);

            this.macine.DriveMotor((ushort)-steps, (ushort)speed);

            string message = String.Format("Motor @ {0}[stp]; speed {1}[Hz]", -steps, speed);
            this.AddLogRow(message);
        }

        private void btnCCW_Click(object sender, EventArgs e)
        {
            // TODO: Send command to PLC for contra clock ways direction motion with parameters in the text boxes.

            if (this.macine == null)
            {
                return;
            }

            float stepsCount = 0.0f;
            float.TryParse(AppUtils.CorrectDecDelimiter(this.tbStepsCount.Text), out stepsCount);

            float posScale = stepsCount / 360.0f;

            float degreeSetPosition = 0.0f;
            float.TryParse(AppUtils.CorrectDecDelimiter(this.tbPosition.Text), out degreeSetPosition);

            float steps = degreeSetPosition * posScale;
            steps = (float)Math.Round(steps, 0);

            float speed = 0.0f;
            float.TryParse(AppUtils.CorrectDecDelimiter(this.tbSpeed.Text), out speed);

            this.macine.DriveMotor((ushort)steps, (ushort)speed);

            string message = String.Format("Motor @ {0}[stp]; speed {1}[Hz]", steps, speed);
            this.AddLogRow(message);
        }


        private void btnAddCommand_Click(object sender, EventArgs e)
        {
            string sSpeed = AppUtils.CorrectDecDelimiter(this.tbSpeedPC.Text);
            string sPos = AppUtils.CorrectDecDelimiter(this.tbPositionPC.Text);

            float speed = 0.0f;
            float position = 0.0f;

            float.TryParse(sSpeed, out speed);
            float.TryParse(sPos, out position);

            MotionCommand command = new MotionCommand(position, speed);

            this.programControl.Commands.Add(command);
            this.lstCommands.Items.Add(command.ToString());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.programControl.Commands.Clear();
            this.lstCommands.Items.Clear();
        }

        private void btnRunProgram_Click(object sender, EventArgs e)
        {
            this.RunProgram();
        }

        private void btnResumeProgram_Click(object sender, EventArgs e)
        {
            this.ResumeProgram();
        }

        private void btnStopProgram_Click(object sender, EventArgs e)
        {
            this.ResumeProgram();
        }

        private void btnLoadProgram_Click(object sender, EventArgs e)
        {
            this.LoadProgram();
        }

        private void btnSaveProgram_Click(object sender, EventArgs e)
        {
            this.SaveProgram();
        }

        #endregion

        #region Main Form

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.SearchForPorts();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Disconnect();
        }

        #endregion

        #region Combo box - ports.

        private void cbPorts_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox tb = (ComboBox)sender;
            this.portName = tb.Text;
        }

        #endregion

        #region Program controll

        private void programControl_OnExecutionIndexChanged(object sender, MessageInt e)
        {
            MotionCommand command = this.programControl.Commands[e.Value];

            float stepsCount = 0.0f;
            float.TryParse(AppUtils.CorrectDecDelimiter(this.tbStepsCount.Text), out stepsCount);

            float posScale = stepsCount / 360.0f;

            float steps = command.Position * posScale;
            steps = (float)Math.Round(steps, 0);

            this.macine.DriveMotor((ushort)steps, (ushort)command.Speed);

            this.SetProgramIndex(e.Value);
        }

        #endregion

        private void lstCommands_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstCommands.Items.Count > 0)
            {
                int index = this.lstCommands.SelectedIndex;
                if (index > 0)
                {
                    // this.programControl.Commands[index]
                    string command = this.lstCommands.Items[index].ToString();
                    this.lblCommand.Text = String.Format("CMD: {0}", command);
                    this.lblCommandIndex.Text = String.Format("Index: {0}/{1}", index + 1, this.programControl.Commands.Count);
                }
            }
        }



    }
}
