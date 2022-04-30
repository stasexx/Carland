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

        public Main()
        {
            InitializeComponent();
            Car car = new Car();
            Cars cars = DeSerializeJsonCars();
            foreach (Car cr in cars.CarsList)
            {
                Add(cr);
            }
            ListViewItem ListViewOfCars = new ListViewItem();
            ListViewOfCars.Tag = car;
            listViewOfCars.Items.Add(ListViewOfCars);
            string data = File.ReadAllText("Users.json");
            cars = JsonSerializer.Deserialize<Cars>(data);
        }

        private Cars DeSerializeJsonCars()
        {
            string data = File.ReadAllText("Cars.json");
            return JsonSerializer.Deserialize<Cars>(data);
        }
        private void Add(Car car)
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

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
