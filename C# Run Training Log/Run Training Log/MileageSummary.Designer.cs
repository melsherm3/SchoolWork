namespace Run_Training_Log
{
    partial class MileageSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MileageSummary));
            this.blackMileagePanel = new System.Windows.Forms.Panel();
            this.mileageLabel = new System.Windows.Forms.Label();
            this.redMileagePanel = new System.Windows.Forms.Panel();
            this.logoMileagePictureBox = new System.Windows.Forms.PictureBox();
            this.dateStartLabel = new System.Windows.Forms.Label();
            this.dateEndLabel = new System.Windows.Forms.Label();
            this.dateStartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateEndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.submitButton = new System.Windows.Forms.Button();
            this.totalMileageLabel = new System.Windows.Forms.Label();
            this.workoutsTableAdapter1 = new Run_Training_Log.TrainingLogDataSetTableAdapters.WorkoutsTableAdapter();
            this.closeMileageButton = new System.Windows.Forms.Button();
            this.totalMileageResultLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.weeklyMileageLabel = new System.Windows.Forms.Label();
            this.weeklyMileageTextBox = new System.Windows.Forms.TextBox();
            this.blackMileagePanel.SuspendLayout();
            this.redMileagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoMileagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // blackMileagePanel
            // 
            this.blackMileagePanel.BackColor = System.Drawing.Color.Black;
            this.blackMileagePanel.Controls.Add(this.mileageLabel);
            this.blackMileagePanel.Location = new System.Drawing.Point(3, 68);
            this.blackMileagePanel.Name = "blackMileagePanel";
            this.blackMileagePanel.Size = new System.Drawing.Size(506, 42);
            this.blackMileagePanel.TabIndex = 4;
            // 
            // mileageLabel
            // 
            this.mileageLabel.AutoSize = true;
            this.mileageLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mileageLabel.ForeColor = System.Drawing.Color.White;
            this.mileageLabel.Location = new System.Drawing.Point(365, 10);
            this.mileageLabel.Name = "mileageLabel";
            this.mileageLabel.Size = new System.Drawing.Size(135, 23);
            this.mileageLabel.TabIndex = 0;
            this.mileageLabel.Text = "Mileage Summary";
            // 
            // redMileagePanel
            // 
            this.redMileagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.redMileagePanel.Controls.Add(this.logoMileagePictureBox);
            this.redMileagePanel.Location = new System.Drawing.Point(3, 2);
            this.redMileagePanel.Name = "redMileagePanel";
            this.redMileagePanel.Size = new System.Drawing.Size(506, 64);
            this.redMileagePanel.TabIndex = 3;
            // 
            // logoMileagePictureBox
            // 
            this.logoMileagePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoMileagePictureBox.Image")));
            this.logoMileagePictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoMileagePictureBox.Name = "logoMileagePictureBox";
            this.logoMileagePictureBox.Size = new System.Drawing.Size(166, 58);
            this.logoMileagePictureBox.TabIndex = 0;
            this.logoMileagePictureBox.TabStop = false;
            // 
            // dateStartLabel
            // 
            this.dateStartLabel.AutoSize = true;
            this.dateStartLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStartLabel.Location = new System.Drawing.Point(58, 151);
            this.dateStartLabel.Name = "dateStartLabel";
            this.dateStartLabel.Size = new System.Drawing.Size(84, 23);
            this.dateStartLabel.TabIndex = 5;
            this.dateStartLabel.Text = "Date Start: ";
            // 
            // dateEndLabel
            // 
            this.dateEndLabel.AutoSize = true;
            this.dateEndLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEndLabel.Location = new System.Drawing.Point(58, 198);
            this.dateEndLabel.Name = "dateEndLabel";
            this.dateEndLabel.Size = new System.Drawing.Size(82, 23);
            this.dateEndLabel.TabIndex = 6;
            this.dateEndLabel.Text = "Date End: ";
            // 
            // dateStartTimePicker
            // 
            this.dateStartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStartTimePicker.Location = new System.Drawing.Point(148, 154);
            this.dateStartTimePicker.Name = "dateStartTimePicker";
            this.dateStartTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateStartTimePicker.TabIndex = 7;
            // 
            // dateEndTimePicker
            // 
            this.dateEndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEndTimePicker.Location = new System.Drawing.Point(146, 201);
            this.dateEndTimePicker.Name = "dateEndTimePicker";
            this.dateEndTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateEndTimePicker.TabIndex = 8;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(198, 241);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(89, 31);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submit";
            this.toolTip1.SetToolTip(this.submitButton, "Calculate total mileage");
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // totalMileageLabel
            // 
            this.totalMileageLabel.AutoSize = true;
            this.totalMileageLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMileageLabel.Location = new System.Drawing.Point(25, 333);
            this.totalMileageLabel.Name = "totalMileageLabel";
            this.totalMileageLabel.Size = new System.Drawing.Size(283, 23);
            this.totalMileageLabel.TabIndex = 10;
            this.totalMileageLabel.Text = "Your total mileage for this time period is: ";
            this.totalMileageLabel.Visible = false;
            // 
            // workoutsTableAdapter1
            // 
            this.workoutsTableAdapter1.ClearBeforeFill = true;
            // 
            // closeMileageButton
            // 
            this.closeMileageButton.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeMileageButton.Location = new System.Drawing.Point(293, 241);
            this.closeMileageButton.Name = "closeMileageButton";
            this.closeMileageButton.Size = new System.Drawing.Size(89, 31);
            this.closeMileageButton.TabIndex = 12;
            this.closeMileageButton.Text = "Close";
            this.toolTip1.SetToolTip(this.closeMileageButton, "Close this form");
            this.closeMileageButton.UseVisualStyleBackColor = true;
            this.closeMileageButton.Click += new System.EventHandler(this.closeMileageButton_Click);
            // 
            // totalMileageResultLabel
            // 
            this.totalMileageResultLabel.AutoSize = true;
            this.totalMileageResultLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMileageResultLabel.Location = new System.Drawing.Point(303, 333);
            this.totalMileageResultLabel.Name = "totalMileageResultLabel";
            this.totalMileageResultLabel.Size = new System.Drawing.Size(0, 23);
            this.totalMileageResultLabel.TabIndex = 13;
            this.totalMileageResultLabel.Visible = false;
            // 
            // weeklyMileageLabel
            // 
            this.weeklyMileageLabel.AutoSize = true;
            this.weeklyMileageLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyMileageLabel.Location = new System.Drawing.Point(25, 376);
            this.weeklyMileageLabel.Name = "weeklyMileageLabel";
            this.weeklyMileageLabel.Size = new System.Drawing.Size(299, 23);
            this.weeklyMileageLabel.TabIndex = 14;
            this.weeklyMileageLabel.Text = "Your weekly mileage for this time period is:";
            this.weeklyMileageLabel.Visible = false;
            // 
            // weeklyMileageTextBox
            // 
            this.weeklyMileageTextBox.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyMileageTextBox.Location = new System.Drawing.Point(43, 413);
            this.weeklyMileageTextBox.Multiline = true;
            this.weeklyMileageTextBox.Name = "weeklyMileageTextBox";
            this.weeklyMileageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.weeklyMileageTextBox.Size = new System.Drawing.Size(399, 105);
            this.weeklyMileageTextBox.TabIndex = 15;
            this.weeklyMileageTextBox.Visible = false;
            // 
            // MileageSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(506, 540);
            this.Controls.Add(this.weeklyMileageTextBox);
            this.Controls.Add(this.weeklyMileageLabel);
            this.Controls.Add(this.totalMileageResultLabel);
            this.Controls.Add(this.closeMileageButton);
            this.Controls.Add(this.totalMileageLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.dateEndTimePicker);
            this.Controls.Add(this.dateStartTimePicker);
            this.Controls.Add(this.dateEndLabel);
            this.Controls.Add(this.dateStartLabel);
            this.Controls.Add(this.blackMileagePanel);
            this.Controls.Add(this.redMileagePanel);
            this.Name = "MileageSummary";
            this.Text = "MileageSummary";
            this.blackMileagePanel.ResumeLayout(false);
            this.blackMileagePanel.PerformLayout();
            this.redMileagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoMileagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel blackMileagePanel;
        private System.Windows.Forms.Label mileageLabel;
        private System.Windows.Forms.Panel redMileagePanel;
        private System.Windows.Forms.PictureBox logoMileagePictureBox;
        private System.Windows.Forms.Label dateStartLabel;
        private System.Windows.Forms.Label dateEndLabel;
        private System.Windows.Forms.DateTimePicker dateStartTimePicker;
        private System.Windows.Forms.DateTimePicker dateEndTimePicker;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label totalMileageLabel;
        private TrainingLogDataSetTableAdapters.WorkoutsTableAdapter workoutsTableAdapter1;
        private System.Windows.Forms.Button closeMileageButton;
        private System.Windows.Forms.Label totalMileageResultLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label weeklyMileageLabel;
        private System.Windows.Forms.TextBox weeklyMileageTextBox;
    }
}