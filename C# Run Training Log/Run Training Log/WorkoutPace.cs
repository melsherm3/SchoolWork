using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_Training_Log
{
    public class WorkoutPace : Workout
    {
        //Time the workout took
        private int _hours;
        private int _minutes;
        private int _seconds;
        private double _hourPace;
        private double _minutePace;
        private double _secondPace;

        //Constructor
        public WorkoutPace()
        {
            _hours = 0;
            _minutes = 0;
            _seconds = 0;
        }

        //Hours property
        public int Hours
        {
            get { return _hours; }
            set { _hours = value; }
        }

        //Minutes property
        public int Minutes
        {
            get { return _minutes; }
            set { _minutes = value; }
        }

        //Seconds property
        public int Seconds
        {
            get { return _seconds; }
            set { _seconds = value; }
        }

        //Hour Pace property
        public double HourPace
        {
            get { return _hourPace; }
            set { _hourPace = value; }
        }

        //Minute Pace property
        public double MinutePace
        {
            get { return _minutePace; }
            set { _minutePace = value; }
        }

        //Second Pace property
        public double SecondPace
        {
            get { return _secondPace; }
            set { _secondPace = value; }
        }
    }
}
