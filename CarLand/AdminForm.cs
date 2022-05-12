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
    public partial class AdminForm : Form
    {
        public string mark = "";
        public int counter = 0;
        public AdminForm()
        {
            InitializeComponent();
            ListView();
        }
        private void ListView()
        {
            Car car = new Car();
            Cars cars = new Cars();
            ListViewItem ListViewOfCars = new ListViewItem();
            ListViewOfCars.Tag = car;
            listViewOfCars.Items.Add(ListViewOfCars);
            cars.GetAllCars();
            foreach (Car cr in cars.AllCarsListView)
            {
                AddToListView(cr);
            }
            label8.Hide();
            label17.Hide();
            label18.Hide();
        }
        private void AddCarToList_Click(object sender, EventArgs e)
        {
            Cars cars = new Cars();
            cars.AddCarToList(textBox8.Text, textBox1.Text, textBox2.Text, textBox4.Text, textBox3.Text, textBox5.Text, textBox6.Text);
            listViewOfCars.Clear();
            ListView();
            label18.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginCarLand loginCarLand = new LoginCarLand();
            Close();
            loginCarLand.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cars cars = new Cars();
            cars.CarDelete(textBox7.Text);
            listViewOfCars.Clear();
            ListView();
            label8.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Cars Cars = new Cars();
            Cars.CarChanger(textBox9.Text, textBox10.Text, textBox9.Text, textBox16.Text, textBox13.Text, textBox14.Text,
                         textBox15.Text, textBox12.Text);
            label17.Show();
            listViewOfCars.Clear();
            ListView();
        }
        public void AddToListView(Car car)
        {
            ListViewItem ListViewOfCars = new ListViewItem(car.Mark);
            ListViewOfCars.Tag = car;
            listViewOfCars.Items.Add(ListViewOfCars);
        }

        private void listViewOfCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOfCars.SelectedItems.Count == 1)
            {
                Car car = (Car)listViewOfCars.SelectedItems[0].Tag;
                if (car != null)
                {
                    textBox10.Text = car.OnlyMark;
                    textBox9.Text = car.Mark;
                    textBox16.Text = car.YearOf;
                    textBox15.Text = car.TechnicalCondition;
                    textBox12.Text = car.HorsePower;
                    textBox14.Text = car.TechChr;
                    textBox13.Text = car.Cost;
                    textBox7.Text = car.Mark;
                }
            }
        }
    }
}
