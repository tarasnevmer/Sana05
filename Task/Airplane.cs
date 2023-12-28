using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Airplane
    {
        protected string StartCity { get; set; }
        protected string FinishCity { get; set; }
        protected MyDate StartDate { get; set; }
        protected MyDate FinishDate { get; set; }

        public Airplane()
        {
            
        }

        public Airplane(string startCity, string finishCity, MyDate startDate, MyDate finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }

        public Airplane(Airplane otherAirplane)
        {
            StartCity = otherAirplane.StartCity;
            FinishCity = otherAirplane.FinishCity;
            StartDate = new MyDate(otherAirplane.StartDate); 
            FinishDate = new MyDate(otherAirplane.FinishDate); 
        }


        public int GetTotalTime()
        {
            int totalMinutes = (FinishDate.Year - StartDate.Year) * 365 * 24 * 60 +
                        (FinishDate.Month - StartDate.Month) * 30 * 24 * 60 +
                        (FinishDate.Day - StartDate.Day) * 24 * 60 +
                        (FinishDate.Hours - StartDate.Hours) * 60 +
                        (FinishDate.Minutes - StartDate.Minutes);

            return Math.Max(totalMinutes, 0);
        }

        public bool IsArrivingToday()
        {
            return StartDate.Year == FinishDate.Year && StartDate.Month == FinishDate.Month && StartDate.Day == FinishDate.Day;
        }

    }
}
