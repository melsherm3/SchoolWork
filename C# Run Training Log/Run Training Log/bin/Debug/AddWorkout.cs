using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Run_Training_Log
{
    
    public partial class AddWorkout : Form
    {
        public AddWorkout()
        {
            InitializeComponent();
        }

        //Assign user input to workout object
        private void getWorkoutData(Workout workout)
        {
            //Declare variables for each field
            int year = dateTimePicker.Value.Year;
            int month = dateTimePicker.Value.Month;
            int day = dateTimePicker.Value.Day;
            //Assign date to workout object
            workout.Date = new DateTime(year, month, day);
            double mileage;
            //If mileage entry is valid, assign mileage to workout object
            if (double.TryParse(mileageTextBox.Text, out mileage) && mileage > 0)
            {
                workout.Mileage = mileage;
            }
            //Otherwise show an error
            else
            {
                MessageBox.Show("Mileage entry is invalid.");
            }
            //Assign details and comments to workout object
            workout.Details = detailsTextBox.Text;
            workout.Comments = commentsTextBox.Text;
        }

        //Assign user input to workoutPace object
        private void getWorkoutPace(WorkoutPace workoutPace, double distance)
        {
            //Declare variables for each field
            int hours, minutes, seconds;

            //If hours entry is valid, assign hours to workoutPace object
            if (int.TryParse(hoursTextBox.Text, out hours) && hours >= 0)
            {
                workoutPace.Hours = hours;
            }
            //Otherwise show an error
            else
            {
                MessageBox.Show("Hours entry is invalid.");
            }
            //If minutes entry is valid, assign minutes to workoutPace object
            if (int.TryParse(minutesTextBox.Text, out minutes) && minutes >= 0 && minutes < 60)
            {
                workoutPace.Minutes = minutes;
            }
            //Otherwise show an error
            else
            {
                MessageBox.Show("Minutes entry is invalid.");
            }
            //If seconds entry is valid, assign seconds to workoutPace object
            if (int.TryParse(secondsTextBox.Text, out seconds) && seconds >= 0 && seconds < 60)
            {
                workoutPace.Seconds = seconds;
            }
            //Otherwise show an error
            else
            {
                MessageBox.Show("Seconds entry is invalid.");
            }
            
            //Calculate the workout pace
            globalFunctions.calcWorkoutPace(workoutPace, distance);            
        }
        
        private void closeButton_Click(object sender, EventArgs e)
        {
            //Close AddWorkout form
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Throw exception if there are any problems
            try
            {
                //Create a new Workout object
                Workout newWorkout = new Workout();
                getWorkoutData(newWorkout);
                //Assign Workout object's properties to variables
                DateTime workoutDate = newWorkout.Date;
                double mileage = newWorkout.Mileage;
                string details = newWorkout.Details;
                string comments = newWorkout.Comments;
                //Don't save to table if mileage is zero
                if (mileage > 0)
                {
                    //Add a new row to the table with the workout details
                    addWorkoutToTable(workoutDate, mileage, details, comments);
                }
            }
            //Show exception message
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void addWorkoutToTable(DateTime date, double mileage, string details, string comments)
        {
            //Use the workoutsTableAdapter's Insert function to insert a new workout
            this.workoutsTableAdapter.AddWorkout(date, mileage, details, comments);

            //Save the workout
            this.Validate();
            this.workoutsBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.trainingLogDataSet);
            this.trainingLogDataSet.AcceptChanges();

            //Confirm that the workout was added
            MessageBox.Show("Workout Saved.");
        }

        private void autoFillButton_Click(object sender, EventArgs e)
        {
            //Throw exception if there are any problems
            try
            {
                //Create a new WorkoutPace object
                WorkoutPace workoutPace = new WorkoutPace();
                //Get workout data 
                getWorkoutData(workoutPace);
                double distance = workoutPace.Mileage;
                //Get workout pace data
                getWorkoutPace(workoutPace, distance);
                //Fill in details text box
                double hourPace = workoutPace.HourPace;
                double minutePace = workoutPace.MinutePace;
                double secondPace = workoutPace.SecondPace;
                detailsTextBox.Text = "Total workout mileage pace was: " + globalFunctions.formatPace(hourPace, minutePace, secondPace);

            }
            //Show exception message
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
