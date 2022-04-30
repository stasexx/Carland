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
        public AdminForm()
        {
            InitializeComponent();
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
            Car car = new Car(textBox1.Text, textBox2.Text, textBox4.Text,textBox3.Text);
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
    }
}
