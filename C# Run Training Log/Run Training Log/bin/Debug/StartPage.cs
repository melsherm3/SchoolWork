using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Run_Training_Log
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void addWorkoutButton_Click(object sender, EventArgs e)
        {
            //Create an instance of the AddWorkout Form
            AddWorkout workoutForm = new AddWorkout();
            //Display the form
            workoutForm.ShowDialog();
        }

        private void workoutsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workoutsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trainingLogDataSet);
        }

        private void StartPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainingLogDataSet.Workouts' table. You can move, or remove it, as needed.
            //this.workoutsTableAdapter.Fill(this.trainingLogDataSet.Workouts);
            this.workoutsTableAdapter.Fill(this.trainingLogDataSet.Workouts);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //Run SearchDetails query to search for submitted text
            this.workoutsTableAdapter.SearchDetails(this.trainingLogDataSet.Workouts, searchTextBox.Text);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Reset the data to show everything
            this.workoutsTableAdapter.Fill(this.trainingLogDataSet.Workouts);
        }

        private void paceCalculatorButton_Click(object sender, EventArgs e)
        {
            //Create an instance of the Pace Calculator Form
            PaceCalculator paceCalculator = new PaceCalculator();
            //Display the form
            paceCalculator.ShowDialog();
        }

        private void mileageSummaryButton_Click(object sender, EventArgs e)
        {         
            //Create an instance of the Mileage Summary Form
            MileageSummary mileageSummary = new MileageSummary();
            //Display the form
            mileageSummary.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close the start page
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Save changes made in DataGridView
            this.Validate();
            this.workoutsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trainingLogDataSet);
            this.trainingLogDataSet.AcceptChanges();
        }
    }
}
