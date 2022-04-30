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
using System.Xml.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace CarLand
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        public static Users DataBaseUsersJsonRead()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "Users.json");
            var json = File.ReadAllText(path);

            Users currency = JsonConvert.DeserializeObject<Users>(json);
            return currency ?? new Users();

        }
        private void SerializeJSON(Users users)
        {
            string UsersJson = System.Text.Json.JsonSerializer.Serialize(users, typeof(Users));
            StreamWriter file = File.CreateText("Users.json");
            file.WriteLine(UsersJson);
            file.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            User user = new User(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,
                comboBox2.SelectedItem.ToString(), comboBox3.SelectedItem.ToString(), comboBox1.SelectedItem.ToString());        
            users.UsersList.Add(user);
            Users users1 = DataBaseUsersJsonRead();
            users1.UsersList.Add(user);
            string currency = JsonConvert.SerializeObject(users1);
            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "Users.json"), currency);
            Hide();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
