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
            string FMark = "";
            InitializeComponent();
            Car car = new Car();
            Cars cars = DeSerializeJsonCars();
            ListViewItem ListViewOfCars = new ListViewItem();
            ListViewOfCars.Tag = car;
            listViewOfCars.Items.Add(ListViewOfCars);
            MainUser mainUser = DeSerializeJsonUser();
            foreach (User us in mainUser.MainUserList)
            {
                FMark = us.FavoriteMark;
            }
            foreach (Car cr in cars.CarsList)
            {
                if (cr.Mark.Contains(FMark))
                {
                    foreach(User us in mainUser.MainUserList)
                    {
                        if (us.FinOpot == "25000 - 50000")
                        {
                            int costOfCar = Convert.ToInt32(cr.Cost);
                            if(costOfCar >= 20000 && costOfCar <= 50000)
                            {
                                Add(cr);
                            }

                        }
                        if (us.FinOpot == "10000 - 25000")
                        {
                            int costOfCar = Convert.ToInt32(cr.Cost);
                            if (costOfCar >= 10000 && costOfCar <= 25000)
                            {
                                Add(cr);
                            }

                        }
                        if (us.FinOpot == "50000 - 100000")
                        {
                            int costOfCar = Convert.ToInt32(cr.Cost);
                            if (costOfCar >= 50000 && costOfCar <= 100000)
                            {
                                Add(cr);
                            }

                        }
                        if (us.FinOpot == "100000 - 200000")
                        {
                            int costOfCar = Convert.ToInt32(cr.Cost);
                            if (costOfCar >= 100000 && costOfCar <= 2000000)
                            {
                                Add(cr);
                            }

                        }
                    }
                }
            }
        }

        private Cars DeSerializeJsonCars()
        {
            string data = File.ReadAllText("Cars.json");
            return JsonSerializer.Deserialize<Cars>(data);
        }
        private Users DeSerializeJsonUsers()
        {
            string data = File.ReadAllText("Users.json");
            return JsonSerializer.Deserialize<Users>(data);
        }
        private MainUser DeSerializeJsonUser()
        {
            string data = File.ReadAllText("User.json");
            return JsonSerializer.Deserialize<MainUser>(data);
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
    }
}
