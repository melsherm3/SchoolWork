namespace Run_Training_Log
{
    partial class PaceCalculator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaceCalculator));
            this.blackPacePanel = new System.Windows.Forms.Panel();
            this.paceLabel = new System.Windows.Forms.Label();
            this.redPacePanel = new System.Windows.Forms.Panel();
            this.logoPacePictureBox = new System.Windows.Forms.PictureBox();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.paceResultLabel = new System.Windows.Forms.Label();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.minutesTextBox = new System.Windows.Forms.TextBox();
            this.secondsTextBox = new System.Windows.Forms.TextBox();
            this.paceTextBox = new System.Windows.Forms.TextBox();
            this.submitPaceButton = new System.Windows.Forms.Button();
            this.closePaceButton = new System.Windows.Forms.Button();
            this.paceToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.blackPacePanel.SuspendLayout();
            this.redPacePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPacePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // blackPacePanel
            // 
            this.blackPacePanel.BackColor = System.Drawing.Color.Black;
            this.blackPacePanel.Controls.Add(this.paceLabel);
            this.blackPacePanel.Location = new System.Drawing.Point(-3, 67);
            this.blackPacePanel.Name = "blackPacePanel";
            this.blackPacePanel.Size = new System.Drawing.Size(506, 42);
            this.blackPacePanel.TabIndex = 4;
            // 
            // paceLabel
            // 
            this.paceLabel.AutoSize = true;
            this.paceLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paceLabel.ForeColor = System.Drawing.Color.White;
            this.paceLabel.Location = new System.Drawing.Point(384, 10);
            this.paceLabel.Name = "paceLabel";
            this.paceLabel.Size = new System.Drawing.Size(119, 23);
            this.paceLabel.TabIndex = 0;
            this.paceLabel.Text = "Pace Calculator";
            // 
            // redPacePanel
            // 
            this.redPacePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.redPacePanel.Controls.Add(this.logoPacePictureBox);
            this.redPacePanel.Location = new System.Drawing.Point(-3, 1);
            this.redPacePanel.Name = "redPacePanel";
            this.redPacePanel.Size = new System.Drawing.Size(506, 64);
            this.redPacePanel.TabIndex = 3;
            // 
            // logoPacePictureBox
            // 
            this.logoPacePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPacePictureBox.Image")));
            this.logoPacePictureBox.Location = new System.Drawing.Point(3, 2);
            this.logoPacePictureBox.Name = "logoPacePictureBox";
            this.logoPacePictureBox.Size = new System.Drawing.Size(166, 58);
            this.logoPacePictureBox.TabIndex = 0;
            this.logoPacePictureBox.TabStop = false;
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceLabel.Location = new System.Drawing.Point(26, 137);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(144, 23);
            this.distanceLabel.TabIndex = 5;
            this.distanceLabel.Text = "Distance (in miles): ";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(26, 179);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(52, 23);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "Time: ";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursLabel.Location = new System.Drawing.Point(104, 211);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(52, 23);
            this.hoursLabel.TabIndex = 7;
            this.hoursLabel.Text = "Hours";
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesLabel.Location = new System.Drawing.Point(225, 211);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(64, 23);
            this.minutesLabel.TabIndex = 8;
            this.minutesLabel.Text = "Minutes";
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsLabel.Location = new System.Drawing.Point(340, 211);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(72, 23);
            this.secondsLabel.TabIndex = 9;
            this.secondsLabel.Text = "Seconds";
            // 
            // paceResultLabel
            // 
            this.paceResultLabel.AutoSize = true;
            this.paceResultLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paceResultLabel.Location = new System.Drawing.Point(26, 335);
            this.paceResultLabel.Name = "paceResultLabel";
            this.paceResultLabel.Size = new System.Drawing.Size(163, 23);
            this.paceResultLabel.TabIndex = 10;
            this.paceResultLabel.Text = "Your pace per mile is: ";
            this.paceResultLabel.Visible = false;
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceTextBox.Location = new System.Drawing.Point(176, 137);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(100, 29);
            this.distanceTextBox.TabIndex = 11;
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursTextBox.Location = new System.Drawing.Point(84, 179);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(100, 29);
            this.hoursTextBox.TabIndex = 12;
            // 
            // minutesTextBox
            // 
            this.minutesTextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesTextBox.Location = new System.Drawing.Point(205, 179);
            this.minutesTextBox.Name = "minutesTextBox";
            this.minutesTextBox.Size = new System.Drawing.Size(100, 29);
            this.minutesTextBox.TabIndex = 13;
            // 
            // secondsTextBox
            // 
            this.secondsTextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsTextBox.Location = new System.Drawing.Point(328, 179);
            this.secondsTextBox.Name = "secondsTextBox";
            this.secondsTextBox.Size = new System.Drawing.Size(100, 29);
            this.secondsTextBox.TabIndex = 14;
            // 
            // paceTextBox
            // 
            this.paceTextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paceTextBox.Location = new System.Drawing.Point(205, 335);
            this.paceTextBox.Name = "paceTextBox";
            this.paceTextBox.Size = new System.Drawing.Size(138, 29);
            this.paceTextBox.TabIndex = 15;
            this.paceTextBox.Visible = false;
            // 
            // submitPaceButton
            // 
            this.submitPaceButton.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitPaceButton.Location = new System.Drawing.Point(269, 257);
            this.submitPaceButton.Name = "submitPaceButton";
            this.submitPaceButton.Size = new System.Drawing.Size(91, 37);
            this.submitPaceButton.TabIndex = 16;
            this.submitPaceButton.Text = "Submit";
            this.paceToolTip.SetToolTip(this.submitPaceButton, "Calculate your pace");
            this.submitPaceButton.UseVisualStyleBackColor = true;
            this.submitPaceButton.Click += new System.EventHandler(this.submitPaceButton_Click);
            // 
            // closePaceButton
            // 
            this.closePaceButton.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closePaceButton.Location = new System.Drawing.Point(366, 257);
            this.closePaceButton.Name = "closePaceButton";
            this.closePaceButton.Size = new System.Drawing.Size(69, 37);
            this.closePaceButton.TabIndex = 17;
            this.closePaceButton.Text = "Close";
            this.paceToolTip.SetToolTip(this.closePaceButton, "Close this form");
            this.closePaceButton.UseVisualStyleBackColor = true;
            this.closePaceButton.Click += new System.EventHandler(this.closePaceButton_Click);
            // 
            // PaceCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(504, 403);
            this.Controls.Add(this.closePaceButton);
            this.Controls.Add(this.submitPaceButton);
            this.Controls.Add(this.paceTextBox);
            this.Controls.Add(this.secondsTextBox);
            this.Controls.Add(this.minutesTextBox);
            this.Controls.Add(this.hoursTextBox);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(this.paceResultLabel);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.blackPacePanel);
            this.Controls.Add(this.redPacePanel);
            this.Name = "PaceCalculator";
            this.Text = "PaceCalculator";
            this.blackPacePanel.ResumeLayout(false);
            this.blackPacePanel.PerformLayout();
            this.redPacePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPacePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel blackPacePanel;
        private System.Windows.Forms.Label paceLabel;
        private System.Windows.Forms.Panel redPacePanel;
        private System.Windows.Forms.PictureBox logoPacePictureBox;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Label paceResultLabel;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.TextBox minutesTextBox;
        private System.Windows.Forms.TextBox secondsTextBox;
        private System.Windows.Forms.TextBox paceTextBox;
        private System.Windows.Forms.Button submitPaceButton;
        private System.Windows.Forms.Button closePaceButton;
        private System.Windows.Forms.ToolTip paceToolTip;
    }
}