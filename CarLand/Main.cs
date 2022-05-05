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


namespace CarLand
{
    public partial class Main : Form
    {
        public string FinOpot;
        public Main()
        {
            InitializeComponent();
            Car car = new Car();
            Cars cars = new Cars();
            ListViewItem ListViewOfCars = new ListViewItem();
            ListViewOfCars.Tag = car;
            listViewOfCars.Items.Add(ListViewOfCars);
            cars.GetCars();
            foreach (Car cr in cars.CarsListView)
            {
                AddToListView(cr);
            }
        }
        public void AddToListView(Car car)
        {
            ListViewItem ListViewOfCars = new ListViewItem(car.Mark);
            ListViewOfCars.Tag = car;
            listViewOfCars.Items.Add(ListViewOfCars);
        }
        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewOfCars.SelectedItems.Count == 1)
            {
                Car car = (Car)listViewOfCars.SelectedItems[0].Tag;
                if(car != null)
                {
                    textBox3.Text = car.Mark;
                    textBox2.Text = car.Cost;
                    textBox1.Text = car.TechChr;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {          
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var helper = new WordHelper("D:/CarLand/CarLand/documents/blank.docx");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PersonalPage personalPage = new PersonalPage();
            personalPage.Show();
            Hide();
        }
    }
}
