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
        public string TechnicalCondition { get; set; }
        public string HorsePower { get; set; }
        public Car() { }
        public Car(string Mark, string YearOf, string Cost, string TechChr, string TechnicalCondition, string HorsePower)
        {
            this.Mark = Mark;
            this.YearOf = YearOf;
            this.Cost = Cost;
            this.TechChr = TechChr;
            this.TechnicalCondition = TechnicalCondition;
            this.HorsePower = HorsePower;
        }
    }
}
