using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarLand
{
    [Serializable]
    public class Users
    {
        public List<User> UsersList { get; set; } = new List<User>();
        public Users DeSerializeJsonUsers()
        {
            string data = File.ReadAllText("Users.json");
            return System.Text.Json.JsonSerializer.Deserialize<Users>(data);
        }
        public static Users DataBaseUsersJsonRead()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "Users.json");
            var json = File.ReadAllText(path);

            Users currency = JsonConvert.DeserializeObject<Users>(json);
            return currency ?? new Users();

        }
        public void Registration(string Login, string Password, string FIO,
            string Country, string City, string FavoriteMark, string FinOpot, string TechnicalCondition, string HorsePower)
        {
            Users users = DataBaseUsersJsonRead();
            User user = new User(Login, Password, FIO,
            Country, City, FavoriteMark, FinOpot, TechnicalCondition,HorsePower);
            users.UsersList.Add(user);
            Users users1 = DataBaseUsersJsonRead();
            users1.UsersList.Add(user);
            string currency = JsonConvert.SerializeObject(users1);
            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "Users.json"), currency);
        }
        public Users DeSerializeJson()
        {
            string data = File.ReadAllText("Users.json");
            return System.Text.Json.JsonSerializer.Deserialize<Users>(data);
        }
        public void PersonChanger(MainUser mainUser2, int counter)
        {
            Users users1 = Users.DataBaseUsersJsonRead();
            users1.UsersList.RemoveAt(counter);
            string data = File.ReadAllText("Users.json");
            users1.UsersList.Add(mainUser2.MainUserList[0]);
            string currency = JsonConvert.SerializeObject(users1);
            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "Users.json"), currency);
        }
        public void PreChanger(string favmark, string finopot)
        {
            MainUser mainUser = new MainUser();
            Car car = new Car();
            Users users = new Users();
            MainUser mainUser2 = mainUser.DeSerializeJsonUser();
            Users users2 = users.DeSerializeJsonUsers();
            string FavMark = favmark;
            string FinOpot = finopot;
            string Log = mainUser2.MainUserList[0].Login;
            foreach (User user in mainUser2.MainUserList)
            {
                user.FavoriteMark = FavMark;
                user.FinOpot = FinOpot;
            }
            mainUser2.SerializeUserJSON(mainUser2);
        }
        public void Doc(int ListViewCount, string car, string cost)
        {
            Random x = new Random();
            int n = x.Next(0, 1000000000);
            MainUser mainUser = new MainUser();
            MainUser mainUser2 = mainUser.DeSerializeJsonUser();
            var helper = new WordHelper("blank.docx");
            var items = new Dictionary<string, string>
            {
                {"<ORG>", "WorldCars" },
                {"<FIO>", mainUser2.MainUserList[0].FIO},
                {"<CITY>", mainUser2.MainUserList[0].City},
                {"<DATA>", DateTime.Now.ToString("yyyy.MM.dd")},
                {"<CAR>", car},
                {"<COST>", cost+"$"},
                {"<ID>", n.ToString()},
            };
            if (ListViewCount == 1)
            {
                MessageBox.Show("Документ успішно сформовано! Найближчим часом з вами зв'яжеться наш менеджер!");
                helper.Process(items);
            }
            else
            {
                MessageBox.Show("Спочатку оберіть автомобіль!");
            }
        }
        public void LogIn(string log, string pass)
        {
            int counter = 0;
            string login = log;
            string password = pass;
            Users usersList = DeSerializeJsonUsers();
            LoginCarLand loginCarLand = new LoginCarLand();
            if (login == "admin" && password == "admin")
            {
                AdminForm adminForm = new AdminForm();
                loginCarLand.Hide();
                adminForm.Show();
            }
            foreach (User ul in usersList.UsersList)
            {
                if (login == ul.Login)
                {
                    foreach (User us in usersList.UsersList)
                    {
                        if (password == us.Password)
                        {
                            MainUser mainuser = new MainUser();
                            mainuser.MainUserList.Add(usersList.UsersList[counter]);
                            mainuser.SerializeUserJSON(mainuser);
                            Main main = new Main();
                            main.Show();
                            loginCarLand.Hide();
                        }
                    }
                }
                counter++;
            }
            MessageBox.Show("Невірний логін або пароль!");
            counter = 0;
        }
    }
}

