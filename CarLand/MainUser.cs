using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CarLand
{
    public class MainUser
    {
        public List<User> MainUserList { get; set; } = new List<User>();

        public MainUser DeSerializeJsonUser()
        {
            string data = File.ReadAllText("User.json");
            return System.Text.Json.JsonSerializer.Deserialize<MainUser>(data);
        }

        public void SerializeUserJSON(MainUser mainUser)
        {
            string UsersJson = System.Text.Json.JsonSerializer.Serialize(mainUser, typeof(MainUser));
            StreamWriter file = File.CreateText("User.json");
            file.WriteLine(UsersJson);
            file.Close();
        }
    }
}