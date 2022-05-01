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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string FinOpot { get; set; }

        public User() { }
        public User(string Login, string Password, string FirstName, string LastName,
            string Country, string City, string FavoriteMark, string FinOpot)
        {
            this.Login = Login;
            this.Password = Password;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Country = Country;
            this.City = City;
            this.FavoriteMark = FavoriteMark;
            this.FinOpot = FinOpot;
        }
    }
}
