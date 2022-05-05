using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CarLand
{
    public partial class LoginCarLand : Form
    {
        public int counter;
        public string login;
        string password;
        public LoginCarLand()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Hide();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            login = textBox1.Text;
            password = textBox2.Text;
            DeSerializeJson();
            string data = File.ReadAllText("Users.json");
            users = JsonSerializer.Deserialize<Users>(data);
            if(login == "admin" && password == "admin")
            {
                AdminForm adminForm = new AdminForm();
                Hide();
                adminForm.Show();
            }
            foreach (User ul in users.UsersList)
            {
                if(login == ul.Login)
                {
                    foreach (User us in users.UsersList)
                    {
                        if (password == us.Password)
                        {
                            MainUser mainuser = new MainUser();
                            mainuser.MainUserList.Add(users.UsersList[counter]);
                            SerializeJSON(mainuser);
                            Main main = new Main();
                            main.Show();
                            Hide();    
                        }
                        else if(password != us.Password)
                        {
                            label1.Show();
                        }
                    }
                }
                else if (login == ul.Login)
                {
                    label1.Show();
                }
                counter++;
            }
        }
        private void SerializeJSON(MainUser mainUser)
        {
            string UsersJson = System.Text.Json.JsonSerializer.Serialize(mainUser, typeof(MainUser));
            StreamWriter file = File.CreateText("User.json");
            file.WriteLine(UsersJson);
            file.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Registration f = new Registration();
            f.Show();
        }

        private Users DeSerializeJson()
        {
            string data = File.ReadAllText("Users.json");
            return JsonSerializer.Deserialize<Users>(data);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
