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
            Cars cars = new Cars();
            Cars DeCars = cars.DeSerializeJsonCars();
            foreach(Car cr in DeCars.CarsList)
            {
                if(comboBox1.Items.Contains(cr.OnlyMark))
                {
                    continue;
                }
                else
                {
                    comboBox1.Items.Add(cr.OnlyMark);
                }
            }
            label9.Hide();
            label10.Hide();
        }
        private void RegButt_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.DeSerializeJsonUsers();
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" &&
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
                users.Registration(textBox1.Text, textBox2.Text, textBox3.Text,
                    comboBox2.SelectedItem.ToString(), comboBox3.SelectedItem.ToString(), comboBox1.SelectedItem.ToString(), comboBox4.SelectedItem.ToString(), comboBox5.SelectedItem.ToString(),
                    comboBox6.SelectedItem.ToString());
                Hide();
            }
            else
            {
                label9.Show();
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
