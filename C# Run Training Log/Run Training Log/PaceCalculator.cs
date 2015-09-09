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
    public partial class PaceCalculator : Form
    {
        public PaceCalculator()
        {
            InitializeComponent();
        }

        private void submitPaceButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Get input from user
                double distance = double.Parse(distanceTextBox.Text);
                int hours = int.Parse(hoursTextBox.Text);
                int minutes = int.Parse(minutesTextBox.Text);
                int seconds = int.Parse(secondsTextBox.Text);

                if (distance <= 0 || hours < 0 || minutes < 0 || seconds < 0)
                {
                    MessageBox.Show("You must enter valid times and distances.");
                }
                else
                {
                    //Create a new workout object
                    WorkoutPace workout = new WorkoutPace();
                    //Assign variable values to workout object
                    workout.Hours = hours;
                    workout.Minutes = minutes;
                    workout.Seconds = seconds;
                    //Calculate the pace
                    globalFunctions.calcWorkoutPace(workout, distance);
                    //Create variables to hold the pace
                    double hourPace = workout.HourPace;
                    double minutePace = workout.MinutePace;
                    double secondPace = workout.SecondPace;

                    //Display the pace
                    paceTextBox.Visible = true;
                    paceResultLabel.Visible = true;

                    //Show pace
                    paceTextBox.Text = globalFunctions.formatPace(hourPace, minutePace, secondPace);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void closePaceButton_Click(object sender, EventArgs e)
        {
            //Close pace calculator form
            this.Close();
        }
    }
}
