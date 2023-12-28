﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class MyDate
    {
        internal int Year { get; set; }
        internal int Month { get; set; }
        internal int Day { get; set; }
        internal int Hours { get; set; }
        internal int Minutes { get; set; }


        public MyDate()
        {
            
        }
        public MyDate(int year, int month, int day, int hours, int minutes)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = hours;
            Minutes = minutes;
        }

        public MyDate(MyDate otherDate)
        {
            Year = otherDate.Year;
            Month = otherDate.Month;
            Day = otherDate.Day;
            Hours = otherDate.Hours;
            Minutes = otherDate.Minutes;
        }
    }
}
