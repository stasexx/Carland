using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarLand
{
    public partial class PersonalPage : Form
    {
        public string Log = "";
        public string FinOpot = "";
        public string FavMark = "";
        public int counter = 0;
        public int lenght = 0;
        public PersonalPage()
        {
            InitializeComponent();
            Cars cars = new Cars();
            Cars DeCars = cars.DeSerializeJsonCars();
            foreach (Car cr in DeCars.CarsList)
            {
                if (comboBox1.Items.Contains(cr.OnlyMark))
                {
                    continue;
                }
                else
                {
                    comboBox1.Items.Add(cr.OnlyMark);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User uSer = new User();
            MainUser mainUser = new MainUser();
            Car car = new Car();
            Users users = new Users();
            MainUser mainUser2 = mainUser.DeSerializeJsonUser();
            Users users2 = users.DeSerializeJsonUsers();
            FavMark = comboBox1.Text;
            FinOpot = comboBox4.Text;
            Log = mainUser2.MainUserList[0].Login;
            foreach(User user in mainUser2.MainUserList)
            {
                user.FavoriteMark = FavMark;
                user.FinOpot = FinOpot;
            }
            mainUser2.SerializeUserJSON(mainUser2);
            foreach (User user1 in users2.UsersList)
            {
                lenght++;
            }
            foreach (User user1 in users2.UsersList)
            {
                if (user1.Login == Log)
                {
                    Users users1 = Users.DataBaseUsersJsonRead();
                    users1.UsersList.RemoveAt(counter);
                    string data = File.ReadAllText("Users.json");
                    users1.UsersList.Add(mainUser2.MainUserList[0]);
                    string currency = JsonConvert.SerializeObject(users1);
                    File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "Users.json"), currency);
                    Main main = new Main();
                    Hide();
                    main.Show();
                    return;
                }
                else
                {
                    counter++;
                }
            }
        }
    }
}
