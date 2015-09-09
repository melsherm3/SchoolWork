namespace Run_Training_Log
{
    partial class AddWorkout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWorkout));
            this.redWorkoutPanel = new System.Windows.Forms.Panel();
            this.logoWorkoutPictureBox = new System.Windows.Forms.PictureBox();
            this.blackWorkoutPanel = new System.Windows.Forms.Panel();
            this.addWorkoutLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.mileageLabel = new System.Windows.Forms.Label();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mileageTextBox = new System.Windows.Forms.TextBox();
            this.detailsTextBox = new System.Windows.Forms.TextBox();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.workoutsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainingLogDataSet = new Run_Training_Log.TrainingLogDataSet();
            this.workoutsTableAdapter = new Run_Training_Log.TrainingLogDataSetTableAdapters.WorkoutsTableAdapter();
            this.tableAdapterManager1 = new Run_Training_Log.TrainingLogDataSetTableAdapters.TableAdapterManager();
            this.toolTipWorkout = new System.Windows.Forms.ToolTip(this.components);
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.minutesTextBox = new System.Windows.Forms.TextBox();
            this.secondsTextBox = new System.Windows.Forms.TextBox();
            this.autoFillButton = new System.Windows.Forms.Button();
            this.autoFillLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.redWorkoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoWorkoutPictureBox)).BeginInit();
            this.blackWorkoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workoutsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingLogDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // redWorkoutPanel
            // 
            this.redWorkoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.redWorkoutPanel.Controls.Add(this.logoWorkoutPictureBox);
            this.redWorkoutPanel.Location = new System.Drawing.Point(-6, 2);
            this.redWorkoutPanel.Name = "redWorkoutPanel";
            this.redWorkoutPanel.Size = new System.Drawing.Size(506, 64);
            this.redWorkoutPanel.TabIndex = 1;
            // 
            // logoWorkoutPictureBox
            // 
            this.logoWorkoutPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoWorkoutPictureBox.Image")));
            this.logoWorkoutPictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoWorkoutPictureBox.Name = "logoWorkoutPictureBox";
            this.logoWorkoutPictureBox.Size = new System.Drawing.Size(166, 58);
            this.logoWorkoutPictureBox.TabIndex = 0;
            this.logoWorkoutPictureBox.TabStop = false;
            // 
            // blackWorkoutPanel
            // 
            this.blackWorkoutPanel.BackColor = System.Drawing.Color.Black;
            this.blackWorkoutPanel.Controls.Add(this.addWorkoutLabel);
            this.blackWorkoutPanel.Location = new System.Drawing.Point(-6, 68);
            this.blackWorkoutPanel.Name = "blackWorkoutPanel";
            this.blackWorkoutPanel.Size = new System.Drawing.Size(506, 42);
            this.blackWorkoutPanel.TabIndex = 2;
            // 
            // addWorkoutLabel
            // 
            this.addWorkoutLabel.AutoSize = true;
            this.addWorkoutLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWorkoutLabel.ForeColor = System.Drawing.Color.White;
            this.addWorkoutLabel.Location = new System.Drawing.Point(390, 10);
            this.addWorkoutLabel.Name = "addWorkoutLabel";
            this.addWorkoutLabel.Size = new System.Drawing.Size(113, 23);
            this.addWorkoutLabel.TabIndex = 0;
            this.addWorkoutLabel.Text = "Add a Workout";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(24, 152);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(50, 23);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Date: ";
            // 
            // mileageLabel
            // 
            this.mileageLabel.AutoSize = true;
            this.mileageLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mileageLabel.Location = new System.Drawing.Point(24, 193);
            this.mileageLabel.Name = "mileageLabel";
            this.mileageLabel.Size = new System.Drawing.Size(73, 23);
            this.mileageLabel.TabIndex = 4;
            this.mileageLabel.Text = "Mileage: ";
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsLabel.Location = new System.Drawing.Point(24, 232);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(64, 23);
            this.detailsLabel.TabIndex = 5;
            this.detailsLabel.Text = "Details: ";
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsLabel.Location = new System.Drawing.Point(24, 335);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(93, 23);
            this.commentsLabel.TabIndex = 6;
            this.commentsLabel.Text = "Comments: ";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(257, 448);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(125, 35);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add Workout";
            this.toolTipWorkout.SetToolTip(this.addButton, "Click to add a new workout");
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(118, 147);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker.TabIndex = 8;
            // 
            // mileageTextBox
            // 
            this.mileageTextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mileageTextBox.Location = new System.Drawing.Point(118, 193);
            this.mileageTextBox.Name = "mileageTextBox";
            this.mileageTextBox.Size = new System.Drawing.Size(100, 29);
            this.mileageTextBox.TabIndex = 9;
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.AcceptsReturn = true;
            this.detailsTextBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsTextBox.Location = new System.Drawing.Point(118, 234);
            this.detailsTextBox.Multiline = true;
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.Size = new System.Drawing.Size(352, 98);
            this.detailsTextBox.TabIndex = 10;
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.AcceptsReturn = true;
            this.commentsTextBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsTextBox.Location = new System.Drawing.Point(118, 338);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(352, 98);
            this.commentsTextBox.TabIndex = 11;
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(388, 448);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(82, 35);
            this.closeButton.TabIndex = 12;
            this.closeButton.Text = "Close";
            this.toolTipWorkout.SetToolTip(this.closeButton, "Close this window");
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // workoutsBindingSource
            // 
            this.workoutsBindingSource.DataMember = "Workouts";
            this.workoutsBindingSource.DataSource = this.trainingLogDataSet;
            // 
            // trainingLogDataSet
            // 
            this.trainingLogDataSet.DataSetName = "TrainingLogDataSet";
            this.trainingLogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workoutsTableAdapter
            // 
            this.workoutsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = Run_Training_Log.TrainingLogDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.WorkoutsTableAdapter = this.workoutsTableAdapter;
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursTextBox.Location = new System.Drawing.Point(28, 536);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(100, 29);
            this.hoursTextBox.TabIndex = 14;
            this.hoursTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipWorkout.SetToolTip(this.hoursTextBox, "Type hours here");
            // 
            // minutesTextBox
            // 
            this.minutesTextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesTextBox.Location = new System.Drawing.Point(134, 536);
            this.minutesTextBox.Name = "minutesTextBox";
            this.minutesTextBox.Size = new System.Drawing.Size(100, 29);
            this.minutesTextBox.TabIndex = 15;
            this.minutesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipWorkout.SetToolTip(this.minutesTextBox, "Type minutes here");
            // 
            // secondsTextBox
            // 
            this.secondsTextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsTextBox.Location = new System.Drawing.Point(240, 536);
            this.secondsTextBox.Name = "secondsTextBox";
            this.secondsTextBox.Size = new System.Drawing.Size(100, 29);
            this.secondsTextBox.TabIndex = 16;
            this.secondsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipWorkout.SetToolTip(this.secondsTextBox, "Type seconds in here");
            // 
            // autoFillButton
            // 
            this.autoFillButton.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoFillButton.Location = new System.Drawing.Point(361, 533);
            this.autoFillButton.Name = "autoFillButton";
            this.autoFillButton.Size = new System.Drawing.Size(125, 35);
            this.autoFillButton.TabIndex = 17;
            this.autoFillButton.Text = "Auto-Fill Details";
            this.toolTipWorkout.SetToolTip(this.autoFillButton, "Click to add a new workout");
            this.autoFillButton.UseVisualStyleBackColor = true;
            this.autoFillButton.Click += new System.EventHandler(this.autoFillButton_Click);
            // 
            // autoFillLabel
            // 
            this.autoFillLabel.AutoSize = true;
            this.autoFillLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoFillLabel.Location = new System.Drawing.Point(24, 500);
            this.autoFillLabel.Name = "autoFillLabel";
            this.autoFillLabel.Size = new System.Drawing.Size(378, 23);
            this.autoFillLabel.TabIndex = 13;
            this.autoFillLabel.Text = "Enter time here to automatically fill in details (optional): ";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursLabel.Location = new System.Drawing.Point(45, 571);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(52, 23);
            this.hoursLabel.TabIndex = 18;
            this.hoursLabel.Text = "Hours";
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesLabel.Location = new System.Drawing.Point(153, 571);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(64, 23);
            this.minutesLabel.TabIndex = 19;
            this.minutesLabel.Text = "Minutes";
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsLabel.Location = new System.Drawing.Point(254, 571);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(72, 23);
            this.secondsLabel.TabIndex = 20;
            this.secondsLabel.Text = "Seconds";
            // 
            // AddWorkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(498, 603);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.autoFillButton);
            this.Controls.Add(this.secondsTextBox);
            this.Controls.Add(this.minutesTextBox);
            this.Controls.Add(this.hoursTextBox);
            this.Controls.Add(this.autoFillLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(this.detailsTextBox);
            this.Controls.Add(this.mileageTextBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.commentsLabel);
            this.Controls.Add(this.detailsLabel);
            this.Controls.Add(this.mileageLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.blackWorkoutPanel);
            this.Controls.Add(this.redWorkoutPanel);
            this.Name = "AddWorkout";
            this.Text = "AddWorkout";
            this.redWorkoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoWorkoutPictureBox)).EndInit();
            this.blackWorkoutPanel.ResumeLayout(false);
            this.blackWorkoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workoutsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingLogDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel redWorkoutPanel;
        private System.Windows.Forms.PictureBox logoWorkoutPictureBox;
        private System.Windows.Forms.Panel blackWorkoutPanel;
        private System.Windows.Forms.Label addWorkoutLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label mileageLabel;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox mileageTextBox;
        private System.Windows.Forms.TextBox detailsTextBox;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.Button closeButton;
        internal TrainingLogDataSetTableAdapters.WorkoutsTableAdapter workoutsTableAdapter;
        internal TrainingLogDataSet trainingLogDataSet;
        internal System.Windows.Forms.BindingSource workoutsBindingSource;
        internal TrainingLogDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ToolTip toolTipWorkout;
        private System.Windows.Forms.Label autoFillLabel;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.TextBox minutesTextBox;
        private System.Windows.Forms.TextBox secondsTextBox;
        private System.Windows.Forms.Button autoFillButton;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label secondsLabel;
    }
}