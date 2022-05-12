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
            Users usersList = users.DeSerializeJsonUsers();
            if(login == "admin" && password == "admin")
            {
                AdminForm adminForm = new AdminForm();
                Hide();
                adminForm.Show();
            }
            foreach (User ul in usersList.UsersList)
            {
                if(login == ul.Login)
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
                            Hide();    
                        }
                        else if(password != us.Password)
                        {
                            label1.Show();
                        }
                    }
                }
                else if (login != ul.Login)
                {
                    label1.Show();
                }
                counter++;
            }
            counter = 0;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Registration f = new Registration();
            f.Show();
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
