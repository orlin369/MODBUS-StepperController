namespace StepperControl
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpbMove = new System.Windows.Forms.GroupBox();
            this.btnCW = new System.Windows.Forms.Button();
            this.btnCCW = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.tbSpeed = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.tbStepsCount = new System.Windows.Forms.TextBox();
            this.lblStepsCount = new System.Windows.Forms.Label();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gpbMotions = new System.Windows.Forms.GroupBox();
            this.btnSaveProgram = new System.Windows.Forms.Button();
            this.btnLoadProgram = new System.Windows.Forms.Button();
            this.btnResumeProgram = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRunProgram = new System.Windows.Forms.Button();
            this.btnAddCommand = new System.Windows.Forms.Button();
            this.tbPositionPC = new System.Windows.Forms.TextBox();
            this.tbSpeedPC = new System.Windows.Forms.TextBox();
            this.btnStopProgram = new System.Windows.Forms.Button();
            this.lblSpeedPC = new System.Windows.Forms.Label();
            this.lblPositionPC = new System.Windows.Forms.Label();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.lblCommandIndex = new System.Windows.Forms.Label();
            this.lstCommands = new System.Windows.Forms.ListBox();
            this.lblCommand = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gpbMove.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gpbMotions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnConnect.Location = new System.Drawing.Point(7, 49);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(187, 66);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.ForeColor = System.Drawing.Color.Red;
            this.btnDisconnect.Location = new System.Drawing.Point(7, 121);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(187, 66);
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // cbPorts
            // 
            this.cbPorts.BackColor = System.Drawing.Color.Black;
            this.cbPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPorts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPorts.ForeColor = System.Drawing.Color.White;
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(6, 19);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(188, 24);
            this.cbPorts.TabIndex = 2;
            this.cbPorts.SelectedValueChanged += new System.EventHandler(this.cbPorts_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPorts);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 193);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // gpbMove
            // 
            this.gpbMove.Controls.Add(this.btnCW);
            this.gpbMove.Controls.Add(this.btnCCW);
            this.gpbMove.Controls.Add(this.groupBox4);
            this.gpbMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gpbMove.ForeColor = System.Drawing.Color.White;
            this.gpbMove.Location = new System.Drawing.Point(12, 12);
            this.gpbMove.Name = "gpbMove";
            this.gpbMove.Size = new System.Drawing.Size(615, 174);
            this.gpbMove.TabIndex = 11;
            this.gpbMove.TabStop = false;
            this.gpbMove.Text = "Move Motors";
            // 
            // btnCW
            // 
            this.btnCW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCW.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCW.ForeColor = System.Drawing.Color.Red;
            this.btnCW.Location = new System.Drawing.Point(200, 19);
            this.btnCW.Name = "btnCW";
            this.btnCW.Size = new System.Drawing.Size(190, 145);
            this.btnCW.TabIndex = 23;
            this.btnCW.Text = "CW";
            this.btnCW.UseVisualStyleBackColor = true;
            this.btnCW.Click += new System.EventHandler(this.btnCW_Click);
            // 
            // btnCCW
            // 
            this.btnCCW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCCW.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCCW.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnCCW.Location = new System.Drawing.Point(7, 19);
            this.btnCCW.Name = "btnCCW";
            this.btnCCW.Size = new System.Drawing.Size(187, 145);
            this.btnCCW.TabIndex = 22;
            this.btnCCW.Text = "CCW";
            this.btnCCW.UseVisualStyleBackColor = true;
            this.btnCCW.Click += new System.EventHandler(this.btnCCW_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblSpeed);
            this.groupBox4.Controls.Add(this.tbPosition);
            this.groupBox4.Controls.Add(this.tbSpeed);
            this.groupBox4.Controls.Add(this.lblPosition);
            this.groupBox4.Controls.Add(this.tbStepsCount);
            this.groupBox4.Controls.Add(this.lblStepsCount);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(396, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(213, 145);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Properties";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSpeed.Location = new System.Drawing.Point(9, 76);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(123, 20);
            this.lblSpeed.TabIndex = 25;
            this.lblSpeed.Text = "Speed [s/sec]:";
            // 
            // tbPosition
            // 
            this.tbPosition.BackColor = System.Drawing.Color.Black;
            this.tbPosition.ForeColor = System.Drawing.Color.White;
            this.tbPosition.Location = new System.Drawing.Point(143, 46);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(57, 22);
            this.tbPosition.TabIndex = 22;
            this.tbPosition.Text = "360";
            // 
            // tbSpeed
            // 
            this.tbSpeed.BackColor = System.Drawing.Color.Black;
            this.tbSpeed.ForeColor = System.Drawing.Color.White;
            this.tbSpeed.Location = new System.Drawing.Point(143, 76);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(57, 22);
            this.tbSpeed.TabIndex = 24;
            this.tbSpeed.Text = "5000";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPosition.Location = new System.Drawing.Point(9, 46);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(94, 20);
            this.lblPosition.TabIndex = 23;
            this.lblPosition.Text = "Pos. [deg]:";
            // 
            // tbStepsCount
            // 
            this.tbStepsCount.BackColor = System.Drawing.Color.Black;
            this.tbStepsCount.ForeColor = System.Drawing.Color.White;
            this.tbStepsCount.Location = new System.Drawing.Point(143, 18);
            this.tbStepsCount.Name = "tbStepsCount";
            this.tbStepsCount.Size = new System.Drawing.Size(57, 22);
            this.tbStepsCount.TabIndex = 16;
            this.tbStepsCount.Text = "5000";
            // 
            // lblStepsCount
            // 
            this.lblStepsCount.AutoSize = true;
            this.lblStepsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStepsCount.Location = new System.Drawing.Point(9, 18);
            this.lblStepsCount.Name = "lblStepsCount";
            this.lblStepsCount.Size = new System.Drawing.Size(105, 20);
            this.lblStepsCount.TabIndex = 17;
            this.lblStepsCount.Text = "Step Count:";
            // 
            // tbStatus
            // 
            this.tbStatus.BackColor = System.Drawing.Color.Black;
            this.tbStatus.ForeColor = System.Drawing.Color.White;
            this.tbStatus.Location = new System.Drawing.Point(6, 19);
            this.tbStatus.Multiline = true;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(397, 168);
            this.tbStatus.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbStatus);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(218, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 193);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            // 
            // gpbMotions
            // 
            this.gpbMotions.Controls.Add(this.btnSaveProgram);
            this.gpbMotions.Controls.Add(this.btnLoadProgram);
            this.gpbMotions.Controls.Add(this.btnResumeProgram);
            this.gpbMotions.Controls.Add(this.btnClear);
            this.gpbMotions.Controls.Add(this.btnRunProgram);
            this.gpbMotions.Controls.Add(this.btnAddCommand);
            this.gpbMotions.Controls.Add(this.tbPositionPC);
            this.gpbMotions.Controls.Add(this.tbSpeedPC);
            this.gpbMotions.Controls.Add(this.btnStopProgram);
            this.gpbMotions.Controls.Add(this.lblSpeedPC);
            this.gpbMotions.Controls.Add(this.lblPositionPC);
            this.gpbMotions.Controls.Add(this.lblProgramName);
            this.gpbMotions.Controls.Add(this.lblCommandIndex);
            this.gpbMotions.Controls.Add(this.lstCommands);
            this.gpbMotions.Controls.Add(this.lblCommand);
            this.gpbMotions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gpbMotions.ForeColor = System.Drawing.Color.White;
            this.gpbMotions.Location = new System.Drawing.Point(633, 12);
            this.gpbMotions.Name = "gpbMotions";
            this.gpbMotions.Size = new System.Drawing.Size(637, 373);
            this.gpbMotions.TabIndex = 14;
            this.gpbMotions.TabStop = false;
            this.gpbMotions.Text = "Program Control";
            // 
            // btnSaveProgram
            // 
            this.btnSaveProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveProgram.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSaveProgram.Location = new System.Drawing.Point(391, 209);
            this.btnSaveProgram.Name = "btnSaveProgram";
            this.btnSaveProgram.Size = new System.Drawing.Size(115, 23);
            this.btnSaveProgram.TabIndex = 39;
            this.btnSaveProgram.Text = "SAVE";
            this.btnSaveProgram.UseVisualStyleBackColor = true;
            this.btnSaveProgram.Click += new System.EventHandler(this.btnSaveProgram_Click);
            // 
            // btnLoadProgram
            // 
            this.btnLoadProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoadProgram.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnLoadProgram.Location = new System.Drawing.Point(391, 180);
            this.btnLoadProgram.Name = "btnLoadProgram";
            this.btnLoadProgram.Size = new System.Drawing.Size(115, 23);
            this.btnLoadProgram.TabIndex = 38;
            this.btnLoadProgram.Text = "LOAD";
            this.btnLoadProgram.UseVisualStyleBackColor = true;
            this.btnLoadProgram.Click += new System.EventHandler(this.btnLoadProgram_Click);
            // 
            // btnResumeProgram
            // 
            this.btnResumeProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResumeProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResumeProgram.ForeColor = System.Drawing.Color.Yellow;
            this.btnResumeProgram.Location = new System.Drawing.Point(391, 121);
            this.btnResumeProgram.Name = "btnResumeProgram";
            this.btnResumeProgram.Size = new System.Drawing.Size(115, 23);
            this.btnResumeProgram.TabIndex = 37;
            this.btnResumeProgram.Text = "RESUME";
            this.btnResumeProgram.UseVisualStyleBackColor = true;
            this.btnResumeProgram.Click += new System.EventHandler(this.btnResumeProgram_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(391, 338);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 23);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRunProgram
            // 
            this.btnRunProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRunProgram.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnRunProgram.Location = new System.Drawing.Point(391, 92);
            this.btnRunProgram.Name = "btnRunProgram";
            this.btnRunProgram.Size = new System.Drawing.Size(115, 23);
            this.btnRunProgram.TabIndex = 35;
            this.btnRunProgram.Text = "RUN";
            this.btnRunProgram.UseVisualStyleBackColor = true;
            this.btnRunProgram.Click += new System.EventHandler(this.btnRunProgram_Click);
            // 
            // btnAddCommand
            // 
            this.btnAddCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddCommand.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnAddCommand.Location = new System.Drawing.Point(391, 309);
            this.btnAddCommand.Name = "btnAddCommand";
            this.btnAddCommand.Size = new System.Drawing.Size(115, 23);
            this.btnAddCommand.TabIndex = 34;
            this.btnAddCommand.Text = "ADD";
            this.btnAddCommand.UseVisualStyleBackColor = true;
            this.btnAddCommand.Click += new System.EventHandler(this.btnAddCommand_Click);
            // 
            // tbPositionPC
            // 
            this.tbPositionPC.BackColor = System.Drawing.Color.Black;
            this.tbPositionPC.ForeColor = System.Drawing.Color.White;
            this.tbPositionPC.Location = new System.Drawing.Point(449, 255);
            this.tbPositionPC.Name = "tbPositionPC";
            this.tbPositionPC.Size = new System.Drawing.Size(57, 22);
            this.tbPositionPC.TabIndex = 32;
            this.tbPositionPC.Text = "30";
            // 
            // tbSpeedPC
            // 
            this.tbSpeedPC.BackColor = System.Drawing.Color.Black;
            this.tbSpeedPC.ForeColor = System.Drawing.Color.White;
            this.tbSpeedPC.Location = new System.Drawing.Point(449, 281);
            this.tbSpeedPC.Name = "tbSpeedPC";
            this.tbSpeedPC.Size = new System.Drawing.Size(57, 22);
            this.tbSpeedPC.TabIndex = 33;
            this.tbSpeedPC.Text = "25";
            // 
            // btnStopProgram
            // 
            this.btnStopProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStopProgram.ForeColor = System.Drawing.Color.Red;
            this.btnStopProgram.Location = new System.Drawing.Point(391, 151);
            this.btnStopProgram.Name = "btnStopProgram";
            this.btnStopProgram.Size = new System.Drawing.Size(115, 23);
            this.btnStopProgram.TabIndex = 31;
            this.btnStopProgram.Text = "STOP";
            this.btnStopProgram.UseVisualStyleBackColor = true;
            this.btnStopProgram.Click += new System.EventHandler(this.btnStopProgram_Click);
            // 
            // lblSpeedPC
            // 
            this.lblSpeedPC.AutoSize = true;
            this.lblSpeedPC.Location = new System.Drawing.Point(391, 284);
            this.lblSpeedPC.Name = "lblSpeedPC";
            this.lblSpeedPC.Size = new System.Drawing.Size(58, 16);
            this.lblSpeedPC.TabIndex = 29;
            this.lblSpeedPC.Text = "Speed:";
            // 
            // lblPositionPC
            // 
            this.lblPositionPC.AutoSize = true;
            this.lblPositionPC.Location = new System.Drawing.Point(391, 258);
            this.lblPositionPC.Name = "lblPositionPC";
            this.lblPositionPC.Size = new System.Drawing.Size(39, 16);
            this.lblPositionPC.TabIndex = 28;
            this.lblPositionPC.Text = "Pos:";
            // 
            // lblProgramName
            // 
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.Location = new System.Drawing.Point(388, 21);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(90, 16);
            this.lblProgramName.TabIndex = 27;
            this.lblProgramName.Text = "Program: ---";
            // 
            // lblCommandIndex
            // 
            this.lblCommandIndex.AutoSize = true;
            this.lblCommandIndex.Location = new System.Drawing.Point(388, 47);
            this.lblCommandIndex.Name = "lblCommandIndex";
            this.lblCommandIndex.Size = new System.Drawing.Size(68, 16);
            this.lblCommandIndex.TabIndex = 26;
            this.lblCommandIndex.Text = "Index: ---";
            // 
            // lstCommands
            // 
            this.lstCommands.BackColor = System.Drawing.SystemColors.InfoText;
            this.lstCommands.ForeColor = System.Drawing.SystemColors.Info;
            this.lstCommands.FormattingEnabled = true;
            this.lstCommands.ItemHeight = 16;
            this.lstCommands.Location = new System.Drawing.Point(6, 21);
            this.lstCommands.Name = "lstCommands";
            this.lstCommands.Size = new System.Drawing.Size(379, 340);
            this.lstCommands.TabIndex = 19;
            this.lstCommands.SelectedIndexChanged += new System.EventHandler(this.lstCommands_SelectedIndexChanged);
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Location = new System.Drawing.Point(388, 34);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(100, 16);
            this.lblCommand.TabIndex = 18;
            this.lblCommand.Text = "Command: ---";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1283, 392);
            this.Controls.Add(this.gpbMotions);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gpbMove);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Stepper Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.gpbMove.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gpbMotions.ResumeLayout(false);
            this.gpbMotions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gpbMove;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblStepsCount;
        private System.Windows.Forms.TextBox tbStepsCount;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCW;
        private System.Windows.Forms.Button btnCCW;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.TextBox tbSpeed;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.GroupBox gpbMotions;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRunProgram;
        private System.Windows.Forms.Button btnAddCommand;
        private System.Windows.Forms.TextBox tbPositionPC;
        private System.Windows.Forms.TextBox tbSpeedPC;
        private System.Windows.Forms.Button btnStopProgram;
        private System.Windows.Forms.Label lblSpeedPC;
        private System.Windows.Forms.Label lblPositionPC;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.Label lblCommandIndex;
        private System.Windows.Forms.ListBox lstCommands;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.Button btnResumeProgram;
        private System.Windows.Forms.Button btnLoadProgram;
        private System.Windows.Forms.Button btnSaveProgram;
    }
}

