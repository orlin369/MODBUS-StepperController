using StepperControl.Commands;
using System;
using System.Threading;

namespace StepperControl
{
    class ProgramController
    {

        #region Variables

        /// <summary>
        /// List of commands.
        /// </summary>
        private MotionCommands commands = new MotionCommands();

        /// <summary>
        /// Current command index.
        /// </summary>
        private int commandIndex = 0;

        /// <summary>
        /// Automatic move thread.
        /// </summary>
        private Thread automaticMove = null;

        #endregion

        #region Properties

        /// <summary>
        /// True when robogt is folowing the commands.
        /// Else false.
        /// </summary>
        public bool IsRuning
        {
            private set;
            get;
        }

        /// <summary>
        /// Set runing in loop.
        /// </summary>
        public bool LoopProgram { get; set; }

        /// <summary>
        /// Set of commands.
        /// </summary>
        public MotionCommands Commands
        {
            set
            {
                this.commands = value;
            }
            get
            {
                return this.commands;
            }
        }

        /// <summary>
        /// Current command index.
        /// </summary>
        public int CurrentCommandIndex
        {
            get
            {
                return this.commandIndex;
            }
        }

        #endregion

        #region Events

        public event EventHandler<MotionCommand> OnCommand;

        public event EventHandler<Messages.MessageInt> OnExecutionIndexCanged;

        /// <summary>
        /// On runing trought the commands.
        /// </summary>
        public event EventHandler<EventArgs> OnRuning;

        /// <summary>
        /// On finishing runing trough commands.
        /// </summary>
        public event EventHandler<EventArgs> OnFinish;

        #endregion

        public ProgramController()
        {
            this.Commands.Clear();
        }

        #region Automatic Controll

        /// <summary>
        /// Run exact list of commands.
        /// </summary>
        /// <param name="commands">List of commands.</param>
        /// <param name="commandIndex">Index to start from.</param>
        public void RunProgram(int commandIndex = 0)
        {
            if (this.automaticMove != null && this.commands.Count > 0)
            {
                if (this.automaticMove.ThreadState == ThreadState.Running)
                {
                    return;
                }
            }

            this.commandIndex = commandIndex;
            this.automaticMove = new Thread(new ThreadStart(this.RunTroughtCmd));
            this.automaticMove.Start();
        }

        /// <summary>
        /// Resume the program from where it stops.
        /// </summary>
        public void ResumeProgram()
        {
            if (this.automaticMove != null)
            {
                if (this.automaticMove.ThreadState == ThreadState.Running)
                {
                    return;
                }
            }

            this.automaticMove = new Thread(new ThreadStart(this.RunTroughtCmd));
            this.automaticMove.Start();
        }

        /// <summary>
        /// Stop the program.
        /// </summary>
        public void StopProgram()
        {
            this.IsRuning = false;
            this.automaticMove = null;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Runing throught thread.
        /// </summary>
        private void RunTroughtCmd()
        {
            this.IsRuning = true;
            this.commandIndex = 0;
            if (this.OnRuning != null)
            {
                this.OnRuning(this, new EventArgs());
            }

            while (this.IsRuning)
            {
                // Get the command.
                MotionCommand command = this.commands[this.commandIndex];

                // Calculate the delay.
                float delay = command.WaitTime();

                // Send execution index to listeners.
                if (this.OnCommand != null)
                {
                    this.OnCommand(this, command);
                }

                if (this.OnExecutionIndexCanged != null)
                {
                    this.OnExecutionIndexCanged(this.OnExecutionIndexCanged, new Messages.MessageInt(this.commandIndex));
                }

                // Wait the robot to finish the motion.
                Thread.Sleep((int)delay + 100);

                // Increment the index.
                this.commandIndex++;

                // Check the command index and proram loop bit.
                if (this.commandIndex == this.commands.Count)
                {
                    if (this.LoopProgram)
                    {
                        this.commandIndex = 0;
                        this.IsRuning = true;
                    }
                    else
                    {
                        this.IsRuning = false;
                        break;
                    }
                }
            }

            if (this.OnFinish != null)
            {
                this.OnFinish(this, new EventArgs());
            }

            this.automaticMove = null;
        }

        #endregion

    }
}
