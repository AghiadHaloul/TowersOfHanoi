namespace TowersOfHanoi
{
    partial class Form1
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
            this.gamePanel = new System.Windows.Forms.Panel();
            this.numOfDesksLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.disksNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.currentStepLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.nextStepButton = new System.Windows.Forms.Button();
            this.nextStepLabel = new System.Windows.Forms.Label();
            this.stepsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.stepDuraionLabel = new System.Windows.Forms.Label();
            this.parametersGroupBox = new System.Windows.Forms.GroupBox();
            this.stepsGroupBox = new System.Windows.Forms.GroupBox();
            this.toolsGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disksNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepsNumericUpDown)).BeginInit();
            this.parametersGroupBox.SuspendLayout();
            this.stepsGroupBox.SuspendLayout();
            this.toolsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gamePanel.Location = new System.Drawing.Point(3, 16);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(933, 605);
            this.gamePanel.TabIndex = 0;
            this.gamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // numOfDesksLabel
            // 
            this.numOfDesksLabel.AutoSize = true;
            this.numOfDesksLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.numOfDesksLabel.Location = new System.Drawing.Point(13, 29);
            this.numOfDesksLabel.Name = "numOfDesksLabel";
            this.numOfDesksLabel.Size = new System.Drawing.Size(125, 19);
            this.numOfDesksLabel.TabIndex = 2;
            this.numOfDesksLabel.Text = "Number of disks";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.gamePanel);
            this.groupBox1.Location = new System.Drawing.Point(-3, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(939, 649);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // disksNumericUpDown
            // 
            this.disksNumericUpDown.Font = new System.Drawing.Font("Tahoma", 12F);
            this.disksNumericUpDown.Location = new System.Drawing.Point(167, 24);
            this.disksNumericUpDown.Name = "disksNumericUpDown";
            this.disksNumericUpDown.Size = new System.Drawing.Size(69, 27);
            this.disksNumericUpDown.TabIndex = 5;
            this.disksNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // currentStepLabel
            // 
            this.currentStepLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentStepLabel.AutoSize = true;
            this.currentStepLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.currentStepLabel.Location = new System.Drawing.Point(23, 26);
            this.currentStepLabel.Name = "currentStepLabel";
            this.currentStepLabel.Size = new System.Drawing.Size(42, 19);
            this.currentStepLabel.TabIndex = 6;
            this.currentStepLabel.Text = "label";
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.startButton.Location = new System.Drawing.Point(335, 29);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(257, 32);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButtonClick);
            // 
            // nextStepButton
            // 
            this.nextStepButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nextStepButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.nextStepButton.Location = new System.Drawing.Point(335, 73);
            this.nextStepButton.Name = "nextStepButton";
            this.nextStepButton.Size = new System.Drawing.Size(257, 32);
            this.nextStepButton.TabIndex = 8;
            this.nextStepButton.Text = "Next Step";
            this.nextStepButton.UseVisualStyleBackColor = true;
            this.nextStepButton.Click += new System.EventHandler(this.nextStepButton_Click);
            // 
            // nextStepLabel
            // 
            this.nextStepLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nextStepLabel.AutoSize = true;
            this.nextStepLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.nextStepLabel.Location = new System.Drawing.Point(23, 52);
            this.nextStepLabel.Name = "nextStepLabel";
            this.nextStepLabel.Size = new System.Drawing.Size(42, 19);
            this.nextStepLabel.TabIndex = 9;
            this.nextStepLabel.Text = "label";
            // 
            // stepsNumericUpDown
            // 
            this.stepsNumericUpDown.Font = new System.Drawing.Font("Tahoma", 12F);
            this.stepsNumericUpDown.Location = new System.Drawing.Point(167, 57);
            this.stepsNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.stepsNumericUpDown.Name = "stepsNumericUpDown";
            this.stepsNumericUpDown.Size = new System.Drawing.Size(69, 27);
            this.stepsNumericUpDown.TabIndex = 10;
            this.stepsNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // stepDuraionLabel
            // 
            this.stepDuraionLabel.AutoSize = true;
            this.stepDuraionLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.stepDuraionLabel.Location = new System.Drawing.Point(15, 61);
            this.stepDuraionLabel.Name = "stepDuraionLabel";
            this.stepDuraionLabel.Size = new System.Drawing.Size(144, 19);
            this.stepDuraionLabel.TabIndex = 11;
            this.stepDuraionLabel.Text = "Step Duration (MS)";
            // 
            // parametersGroupBox
            // 
            this.parametersGroupBox.Controls.Add(this.disksNumericUpDown);
            this.parametersGroupBox.Controls.Add(this.stepDuraionLabel);
            this.parametersGroupBox.Controls.Add(this.numOfDesksLabel);
            this.parametersGroupBox.Controls.Add(this.stepsNumericUpDown);
            this.parametersGroupBox.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.parametersGroupBox.Location = new System.Drawing.Point(6, 16);
            this.parametersGroupBox.Name = "parametersGroupBox";
            this.parametersGroupBox.Size = new System.Drawing.Size(255, 97);
            this.parametersGroupBox.TabIndex = 12;
            this.parametersGroupBox.TabStop = false;
            // 
            // stepsGroupBox
            // 
            this.stepsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stepsGroupBox.Controls.Add(this.currentStepLabel);
            this.stepsGroupBox.Controls.Add(this.nextStepLabel);
            this.stepsGroupBox.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.stepsGroupBox.Location = new System.Drawing.Point(622, 16);
            this.stepsGroupBox.Name = "stepsGroupBox";
            this.stepsGroupBox.Size = new System.Drawing.Size(265, 97);
            this.stepsGroupBox.TabIndex = 13;
            this.stepsGroupBox.TabStop = false;
            this.stepsGroupBox.Text = "Steps";
            // 
            // toolsGroupBox
            // 
            this.toolsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolsGroupBox.Controls.Add(this.parametersGroupBox);
            this.toolsGroupBox.Controls.Add(this.stepsGroupBox);
            this.toolsGroupBox.Controls.Add(this.startButton);
            this.toolsGroupBox.Controls.Add(this.nextStepButton);
            this.toolsGroupBox.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.toolsGroupBox.Location = new System.Drawing.Point(9, -5);
            this.toolsGroupBox.Name = "toolsGroupBox";
            this.toolsGroupBox.Size = new System.Drawing.Size(916, 126);
            this.toolsGroupBox.TabIndex = 14;
            this.toolsGroupBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 760);
            this.Controls.Add(this.toolsGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Towers of Hanoi";
            this.MaximumSizeChanged += new System.EventHandler(this.Form1_MaximumSizeChanged);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.disksNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepsNumericUpDown)).EndInit();
            this.parametersGroupBox.ResumeLayout(false);
            this.parametersGroupBox.PerformLayout();
            this.stepsGroupBox.ResumeLayout(false);
            this.stepsGroupBox.PerformLayout();
            this.toolsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Label numOfDesksLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown disksNumericUpDown;
        private System.Windows.Forms.Label currentStepLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button nextStepButton;
        private System.Windows.Forms.Label nextStepLabel;
        private System.Windows.Forms.NumericUpDown stepsNumericUpDown;
        private System.Windows.Forms.Label stepDuraionLabel;
        private System.Windows.Forms.GroupBox parametersGroupBox;
        private System.Windows.Forms.GroupBox stepsGroupBox;
        private System.Windows.Forms.GroupBox toolsGroupBox;
    }
}

