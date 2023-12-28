using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Currency
    {
        protected string Name { get; set; }
        protected double ExRate { get; set; }

        public Currency()
        {
            
        }

        public Currency(string name, double exRate)
        {
            Name = name;
            ExRate = exRate;
        }

        public Currency(Currency otherCurrency)
        {
            Name = otherCurrency.Name;
            ExRate = otherCurrency.ExRate;
        }
    }
}
