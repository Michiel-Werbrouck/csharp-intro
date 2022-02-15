using System;
using System.Collections.Generic;
using System.Text;

namespace TimeExercise
{
    public class Time
    {
        public int Hours { get; set; }

        public int Minutes { 
            get { return Minutes; } 
            set { if (value < 0 || value > 59) throw new ArgumentException("Minutes need to be between 0 and 59"); } 
        }

        public int Seconds
        {
            get { return Seconds; }
            set { if (value < 0 || value > 59) throw new ArgumentException("Seconds need to be between 0 and 59"); }
        }

        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public int TotalSeconds
        {
            get
            {
                return Hours * 60 * 60 + Minutes * 60 + Seconds;
            }
        }
    }
}
