using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Airplane
    {
        protected string StarCity;
        protected string FinishCity;
        protected MyDate StartDate;
        protected MyDate FinishDate;

        public Airplane(string startCity, string finishCity, MyDate startDate, MyDate finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }

        public int GetTotalTime()
        {
            TimeSpan totalTime = FinishDate - StartDate;
            return (int)totalTime.TotalMinutes;
        }

        public bool IsArrivingToday()
        {
            if (StartDate.Year == FinishDate.Year && StartDate.Month == FinishDate.Month && StartDate.Day == FinishDate.Day)
            {
                return true;
            }
            return false;
        }

    }
}
