namespace Run_Training_Log
{
    partial class StartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.redPanel = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.blackPanel = new System.Windows.Forms.Panel();
            this.paceCalculatorButton = new System.Windows.Forms.Button();
            this.mileageSummaryButton = new System.Windows.Forms.Button();
            this.addWorkoutButton = new System.Windows.Forms.Button();
            this.trainingLogDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workoutsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainingLogDataSet = new Run_Training_Log.TrainingLogDataSet();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.startPageToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workoutsTableAdapter = new Run_Training_Log.TrainingLogDataSetTableAdapters.WorkoutsTableAdapter();
            this.tableAdapterManager = new Run_Training_Log.TrainingLogDataSetTableAdapters.TableAdapterManager();
            this.redPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.blackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingLogDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workoutsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingLogDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // redPanel
            // 
            this.redPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.redPanel.Controls.Add(this.logoPictureBox);
            this.redPanel.Location = new System.Drawing.Point(1, 25);
            this.redPanel.Name = "redPanel";
            this.redPanel.Size = new System.Drawing.Size(602, 64);
            this.redPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(166, 58);
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // blackPanel
            // 
            this.blackPanel.BackColor = System.Drawing.Color.Black;
            this.blackPanel.Controls.Add(this.paceCalculatorButton);
            this.blackPanel.Controls.Add(this.mileageSummaryButton);
            this.blackPanel.Controls.Add(this.addWorkoutButton);
            this.blackPanel.Location = new System.Drawing.Point(2, 90);
            this.blackPanel.Name = "blackPanel";
            this.blackPanel.Size = new System.Drawing.Size(601, 42);
            this.blackPanel.TabIndex = 1;
            // 
            // paceCalculatorButton
            // 
            this.paceCalculatorButton.FlatAppearance.BorderSize = 0;
            this.paceCalculatorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paceCalculatorButton.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paceCalculatorButton.ForeColor = System.Drawing.Color.White;
            this.paceCalculatorButton.Location = new System.Drawing.Point(465, 5);
            this.paceCalculatorButton.Name = "paceCalculatorButton";
            this.paceCalculatorButton.Size = new System.Drawing.Size(133, 32);
            this.paceCalculatorButton.TabIndex = 2;
            this.paceCalculatorButton.Text = "Pace Calculator";
            this.paceCalculatorButton.UseVisualStyleBackColor = true;
            this.paceCalculatorButton.Click += new System.EventHandler(this.paceCalculatorButton_Click);
            // 
            // mileageSummaryButton
            // 
            this.mileageSummaryButton.FlatAppearance.BorderSize = 0;
            this.mileageSummaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mileageSummaryButton.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mileageSummaryButton.ForeColor = System.Drawing.Color.White;
            this.mileageSummaryButton.Location = new System.Drawing.Point(298, 5);
            this.mileageSummaryButton.Name = "mileageSummaryButton";
            this.mileageSummaryButton.Size = new System.Drawing.Size(161, 32);
            this.mileageSummaryButton.TabIndex = 1;
            this.mileageSummaryButton.Text = "Mileage Summary";
            this.mileageSummaryButton.UseVisualStyleBackColor = true;
            this.mileageSummaryButton.Click += new System.EventHandler(this.mileageSummaryButton_Click);
            // 
            // addWorkoutButton
            // 
            this.addWorkoutButton.FlatAppearance.BorderSize = 0;
            this.addWorkoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addWorkoutButton.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWorkoutButton.ForeColor = System.Drawing.Color.White;
            this.addWorkoutButton.Location = new System.Drawing.Point(159, 5);
            this.addWorkoutButton.Name = "addWorkoutButton";
            this.addWorkoutButton.Size = new System.Drawing.Size(133, 32);
            this.addWorkoutButton.TabIndex = 0;
            this.addWorkoutButton.Text = "Add a Workout";
            this.addWorkoutButton.UseVisualStyleBackColor = true;
            this.addWorkoutButton.Click += new System.EventHandler(this.addWorkoutButton_Click);
            // 
            // trainingLogDataGridView
            // 
            this.trainingLogDataGridView.AllowUserToDeleteRows = false;
            this.trainingLogDataGridView.AutoGenerateColumns = false;
            this.trainingLogDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.trainingLogDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.trainingLogDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trainingLogDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.trainingLogDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.trainingLogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainingLogDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.trainingLogDataGridView.DataSource = this.workoutsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.trainingLogDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.trainingLogDataGridView.GridColor = System.Drawing.Color.Maroon;
            this.trainingLogDataGridView.Location = new System.Drawing.Point(29, 156);
            this.trainingLogDataGridView.Name = "trainingLogDataGridView";
            this.trainingLogDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.trainingLogDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.trainingLogDataGridView.RowHeadersVisible = false;
            this.trainingLogDataGridView.Size = new System.Drawing.Size(562, 217);
            this.trainingLogDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Mileage";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mileage";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Details";
            this.dataGridViewTextBoxColumn4.HeaderText = "Details";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Comments";
            this.dataGridViewTextBoxColumn5.HeaderText = "Comments";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
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
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(36, 379);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(110, 23);
            this.searchLabel.TabIndex = 4;
            this.searchLabel.Text = "Search Details";
            // 
            // searchTextBox
            // 
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(161, 379);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(150, 29);
            this.searchTextBox.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(331, 379);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(95, 29);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.startPageToolTip.SetToolTip(this.searchButton, "Enter a keyword to search the Details column");
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(441, 379);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(95, 29);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Refresh";
            this.startPageToolTip.SetToolTip(this.clearButton, "Refresh this chart");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(602, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // workoutsTableAdapter
            // 
            this.workoutsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Run_Training_Log.TrainingLogDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkoutsTableAdapter = this.workoutsTableAdapter;
            // 
            // StartPage
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(602, 421);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.trainingLogDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.blackPanel);
            this.Controls.Add(this.redPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StartPage";
            this.Text = "Start Page";
            this.Load += new System.EventHandler(this.StartPage_Load);
            this.redPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.blackPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trainingLogDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workoutsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingLogDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel redPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Panel blackPanel;
        private System.Windows.Forms.Button paceCalculatorButton;
        private System.Windows.Forms.Button mileageSummaryButton;
        private System.Windows.Forms.Button addWorkoutButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearButton;
        internal System.Windows.Forms.DataGridView trainingLogDataGridView;
        internal TrainingLogDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolTip startPageToolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        internal System.Windows.Forms.BindingSource workoutsBindingSource;
        internal TrainingLogDataSetTableAdapters.WorkoutsTableAdapter workoutsTableAdapter;
        internal TrainingLogDataSet trainingLogDataSet;
    }
}

