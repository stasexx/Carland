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
            label9.Hide();
            label10.Hide();
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
            DeSerializeJson();
            string data = File.ReadAllText("Users.json");
            users = System.Text.Json.JsonSerializer.Deserialize<Users>(data);
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" &&
                comboBox2.SelectedItem != null && comboBox3.SelectedItem != null &&
                comboBox1.SelectedItem != null && comboBox4.SelectedItem != null && comboBox5.SelectedItem != null &&
                comboBox5.SelectedItem != null)
            {
                foreach(User us in users.UsersList)
                {
                    if(us.Login == textBox1.Text)
                    {
                        label10.Show();
                        return;
                    }
                }
                User user = new User(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,
                    comboBox2.SelectedItem.ToString(), comboBox3.SelectedItem.ToString(), comboBox1.SelectedItem.ToString(), comboBox4.SelectedItem.ToString(), comboBox5.SelectedItem.ToString(),
                    comboBox6.SelectedItem.ToString());
                users.UsersList.Add(user);
                Users users1 = DataBaseUsersJsonRead();
                users1.UsersList.Add(user);
                string currency = JsonConvert.SerializeObject(users1);
                File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "Users.json"), currency);
                Hide();
            }
            else
            {
                label9.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private Users DeSerializeJson()
        {
            string data = File.ReadAllText("Users.json");
            return System.Text.Json.JsonSerializer.Deserialize<Users>(data);
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
