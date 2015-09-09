using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_Training_Log
{
    public class Workout
    {
        //Fields
        private DateTime _date;
        private double _mileage;
        private string _details;
        private string _comments;

        //Constructor
        public Workout()
        {
            _date = new DateTime(1990,1,1);
            _mileage = 0;
            _details = "";
            _comments = "";
        }

        //Date property
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        //Mileage property
        public double Mileage
        {
            get { return _mileage; }
            set { _mileage = value; }
        }

        //Details property
        public string Details
        {
            get { return _details; }
            set { _details = value; }
        }

        //Comments property
        public string Comments
        {
            get { return _comments; }
            set { _comments = value; }
        }
    }
}
