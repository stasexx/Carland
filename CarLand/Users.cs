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
        public Users DeSerializeJson()
        {
            string data = File.ReadAllText("Users.json");
            return System.Text.Json.JsonSerializer.Deserialize<Users>(data);
        }
    }

}

