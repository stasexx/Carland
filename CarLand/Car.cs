using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLand
{
    public class Car
    {
        public string Mark { get; set; }
        public string YearOf { get; set; }
        public string TechChr { get; set; }
        public string Cost { get; set; }

        public Car() { }
        public Car(string Mark, string YearOf, string Cost, string TechChr)
        {
            this.Mark = Mark;
            this.YearOf = YearOf;
            this.Cost = Cost;
            this.TechChr = TechChr;
        }
    }
}
