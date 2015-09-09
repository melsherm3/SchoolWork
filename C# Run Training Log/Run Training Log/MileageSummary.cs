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
    public partial class MileageSummary : Form
    {
        public MileageSummary()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Get year month and date values as ints
                int startYear = dateStartTimePicker.Value.Year;
                int startMonth = dateStartTimePicker.Value.Month;
                int startDay = dateStartTimePicker.Value.Day;

                //Create a start date object
                DateTime dateStart = new DateTime(startYear, startMonth, startDay);

                //Get year month and date values for end date as ints
                int endYear = dateEndTimePicker.Value.Year;
                int endMonth = dateEndTimePicker.Value.Month;
                int endDay = dateEndTimePicker.Value.Day;
                //Create an end date object
                DateTime dateEnd = new DateTime(endYear, endMonth, endDay);

                //Show total mileage or error result
                showMileageResult(dateStart, dateEnd);
                
            }
            //Show error message in popup if there is an error
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void closeMileageButton_Click(object sender, EventArgs e)
        {
            //Close mileage summary form
            this.Close();
        }

        //Take the date inputs and show the mileage results
        private void showMileageResult(DateTime dateStart, DateTime dateEnd)
        {
            //Declare variable for total mileage
            double? totalMileage;
            //If the start date is after the end date
            if (dateStart > dateEnd)
            {
                MessageBox.Show("Starting date must be before Ending date.");
                totalMileage = null;
            }
            else
            {
                //If the start and end date are the same
                if (dateStart == dateEnd)
                {
                    //Show the day's mileage
                    totalMileage = (double?)this.workoutsTableAdapter1.DayMileage(dateStart);
                }
                else
                {
                    //Calculate the total mileage and assign to totalMileage
                    totalMileage = (double?)this.workoutsTableAdapter1.CalcMileage(dateStart, dateEnd);
                }

                //Display result
                totalMileageResultLabel.Visible = true;
                totalMileageLabel.Visible = true;

                //If no entries it the time period, write 0 miles
                if (totalMileage == null)
                {
                    totalMileageResultLabel.Text = "0 miles.";
                }
                //Otherwise write the total mileage value
                else if (totalMileage == 1.0)
                {
                    totalMileageResultLabel.Text = totalMileage.ToString() + " mile.";
                }
                else
                {
                    totalMileageResultLabel.Text = totalMileage.ToString() + " miles.";
                }

                //Show mileage per week for date range
                showMileagePerWeek(dateStart, dateEnd);
            }
        }
        //Give a summary of each week's mileage in a given time frame
        private void showMileagePerWeek(DateTime dateStart, DateTime dateEnd)
        {
            //Alter the start date to start on Sunday of the selected week
            switch (dateStart.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    dateStart = dateStart.AddDays(-1);
                    break;
                case DayOfWeek.Tuesday:
                    dateStart = dateStart.AddDays(-2);
                    break;
                case DayOfWeek.Wednesday:
                    dateStart = dateStart.AddDays(-3);
                    break;
                case DayOfWeek.Thursday:
                    dateStart = dateStart.AddDays(-4);
                    break;
                case DayOfWeek.Friday:
                    dateStart = dateStart.AddDays(-5);
                    break;
                case DayOfWeek.Saturday:
                    dateStart = dateStart.AddDays(-6);
                    break;
            }

            //Add dates to ending date to fill out the week through Saturday
            switch (dateEnd.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    dateEnd = dateEnd.AddDays(5);
                    break;
                case DayOfWeek.Tuesday:
                    dateEnd = dateEnd.AddDays(4);
                    break;
                case DayOfWeek.Wednesday:
                    dateEnd = dateEnd.AddDays(3);
                    break;
                case DayOfWeek.Thursday:
                    dateEnd = dateEnd.AddDays(2);
                    break;
                case DayOfWeek.Friday:
                    dateEnd = dateEnd.AddDays(1);
                    break;
                case DayOfWeek.Sunday:
                    dateEnd = dateEnd.AddDays(6);
                    break;
            }

            //Declare variables for the Mileage result string and the week's mileage
            string weeklyMileageString = "";
            double? weeksMileage;
            //Declare variable for the end of the week date
            DateTime dayEnd;
            //While the starting day is less than the ending day
            while (dateStart <= dateEnd)
            {
                //Set the last day of the week
                dayEnd = dateStart.AddDays(6);
                //Calculate the mileage for that wee
                weeksMileage = (double?)this.workoutsTableAdapter1.CalcMileage(dateStart, dayEnd);
                //If the mileage for the week is null, set it to zero
                if (weeksMileage == null) weeksMileage = 0;
                //Create a string with the weekly mileage summary
                weeklyMileageString = weeklyMileageString + "Week of: " + dateStart.ToString("MM/dd/yyyy") + " Total Mileage: " + weeksMileage + Environment.NewLine;
                //Add 7 days to the starting day to continue the loop
                dateStart = dateStart.AddDays(7);
            }
            //Show the weekly mileage labels and text box
            weeklyMileageLabel.Visible = true;
            weeklyMileageTextBox.Visible = true;
            //Set the weekly mileage textbox string text value
            weeklyMileageTextBox.Text = weeklyMileageString;
        }
    }
}
