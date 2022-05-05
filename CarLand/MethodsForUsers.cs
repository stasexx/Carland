using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLand
{
    public class MethodsForUsers
    {
        public int counter = 0;
        public int lenght = 0;
        public string Log = "";
        public void ReplacementUser()
        {
            MainUser mainUser = new MainUser();
            Car car = new Car();
            Users users = new Users();
            MainUser mainUser2 = mainUser.DeSerializeJsonUser();
            Users users2 = users.DeSerializeJsonUsers();
            mainUser2.SerializeUserJSON(mainUser2);
            foreach (User user in mainUser2.MainUserList)
            {
                Log = user.Login;
            }
            foreach (User user1 in users2.UsersList)
            {
                lenght++;
            }
            mainUser2.SerializeUserJSON(mainUser2);
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
                    PersonalPage page = new PersonalPage();
                    Main main = new Main();
                    page.Hide();
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
