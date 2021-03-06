using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLand
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string FavoriteMark { get; set; }
        
        public string FIO { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string FinOpot { get; set; }
        public string TechnicalCondition { get; set; }
        public string HorsePower { get; set; }

        public User() { }
        public User(string Login, string Password, string FIO,
            string Country, string City, string FavoriteMark, string FinOpot, string TechnicalCondition, string HorsePower)
        {
            this.Login = Login;
            this.Password = Password;
            this.FIO = FIO;
            this.Country = Country;
            this.City = City;
            this.FavoriteMark = FavoriteMark;
            this.FinOpot = FinOpot;
            this.TechnicalCondition = TechnicalCondition;
            this.HorsePower = HorsePower;
        }
    }
}
