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
        }
        public static Cars DataBaseCarsJsonRead()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "Cars.json");
            var json = File.ReadAllText(path);
            Cars currency = JsonConvert.DeserializeObject<Cars>(json);
            return currency ?? new Cars();

        }

        private void AddCarToList_Click(object sender, EventArgs e)
        {
            Cars cars = new Cars();
            Car car = new Car(textBox8.Text, textBox1.Text, textBox2.Text, textBox4.Text, textBox3.Text, textBox5.Text, textBox6.Text);
            cars.CarsList.Add(car);
            Cars cars1 = DataBaseCarsJsonRead();
            cars1.CarsList.Add(car);
            string currency = JsonConvert.SerializeObject(cars1);
            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "Cars.json"), currency);
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
            Cars DeCars = cars.DeSerializeJsonCars();
            mark = textBox7.Text;
            foreach (Car cr in DeCars.CarsList)
            {
                if(cr.Mark == mark)
                {
                    Cars cars1 = DataBaseCarsJsonRead();
                    cars1.CarsList.RemoveAt(counter);
                    string currency = JsonConvert.SerializeObject(cars1);
                    File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "Cars.json"), currency);
                    label8.Show();
                }
                else
                {
                    counter++;
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int counter1 = 0;
            Cars Cars = new Cars();
            string MarkAndModel = textBox9.Text;
            Cars DeCars = Cars.DeSerializeJsonCars();
            foreach(Car cr in DeCars.CarsList)
            {
                if(cr.Mark == MarkAndModel)
                {
                    DeCars.CarsList.RemoveAt(counter1);
                    Car car = new Car(textBox10.Text, textBox9.Text, textBox16.Text, textBox13.Text, textBox14.Text,
                         textBox15.Text, textBox12.Text);
                    DeCars.CarsList.Add(car);
                    string currency = JsonConvert.SerializeObject(DeCars);
                    File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "Cars.json"), currency);
                    label17.Show();
                    return;
                }
                else
                {
                    counter1++;
                }
            }
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
                }
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
