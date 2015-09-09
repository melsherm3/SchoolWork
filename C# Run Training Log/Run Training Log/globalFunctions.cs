using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_Training_Log
{
    //Create a class with functions that all the forms can use
    public static class globalFunctions
    {
        //Calculate the workout pace and assign it's variables to the created workoutPace object
        public static void calcWorkoutPace(WorkoutPace workoutPace, double distance)
        {
            //Get variables
            int hours = workoutPace.Hours;
            int seconds = workoutPace.Seconds;
            int minutes = workoutPace.Minutes;

            //Calculate total minutes and seconds
            int totalMinutes = minutes + hours * 60;
            int totalSeconds = seconds + totalMinutes * 60;

            //Calculatoe the pace and assign to workoutPace object
            double secondsPerMile = totalSeconds / distance;
            double hourPaceDecimal = secondsPerMile / 3600;
            workoutPace.HourPace = Math.Floor(hourPaceDecimal);
            double minutePaceDecimal = 60 * (hourPaceDecimal - workoutPace.HourPace);
            workoutPace.MinutePace = Math.Floor(minutePaceDecimal);
            workoutPace.SecondPace = Math.Round(60 * (minutePaceDecimal - workoutPace.MinutePace));
        }

        //Format pace into a nicely formatted string
        public static string formatPace(double hourPace, double minutePace, double secondPace)
        {
            string formattedPace;
            //Show hour pace if it exists
            if (hourPace > 0)
            {
                formattedPace = hourPace.ToString() + ":" + minutePace.ToString("00") + ":" + secondPace.ToString("00");
            }
            //Don't show hour pace if it's 0
            else if (minutePace > 0)
            {
                formattedPace = minutePace.ToString() + ":" + secondPace.ToString("00");
            }
            //Don't show minutes pace if it's 0
            else
            {
                formattedPace = secondPace.ToString() + " seconds";
            }

            //Return the formatted string version of the pace
            return formattedPace;
        }
    }
}
