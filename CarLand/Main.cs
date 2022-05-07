using Newtonsoft.Json;
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
            Random x = new Random();
            int n = x.Next(0, 1000000000);
            MainUser mainUser = new MainUser();
            MainUser mainUser2 = mainUser.DeSerializeJsonUser();
            var helper = new WordHelper("blank.docx");
            var items = new Dictionary<string, string>
            {
                {"<ORG>", "WorldCars" },
                {"<FIO>", mainUser2.MainUserList[0].FIO},
                {"<CITY>", mainUser2.MainUserList[0].City},
                {"<DATA>", DateTime.Now.ToString("yyyy.MM.dd")},
                {"<CAR>", textBox3.Text},
                {"<COST>", textBox2.Text+"$"},
                {"<ID>", n.ToString()},
            };
            MessageBox.Show("Документ успішно сформовано!Найближчим часом з вами зв'яжеться наш менеджер!");
            helper.Process(items);
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

        private void button2_Click(object sender, EventArgs e)
        {
            Car car = (Car)listViewOfCars.SelectedItems[0].Tag;
            CarsThatUserLike CTUL = new CarsThatUserLike();
            CarsThatUserLike CTUL1 = CTUL.DeSerializeCarsJsonThatUserLike();
            CTUL1.CarsThatUserLikeList.Add(car);
            string currency = JsonConvert.SerializeObject(CTUL1);
            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "CarsThatUserLike.json"), currency);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listViewOfCars.Clear();
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

        private void button5_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            CarsThatUserLike CTUL = new CarsThatUserLike();
            ListViewItem ListViewOfCars = new ListViewItem();
            CarsThatUserLike CTUL1 = CTUL.DeSerializeCarsJsonThatUserLike();
            listViewOfCars.Clear();
            ListViewOfCars.Tag = car;
            listViewOfCars.Items.Add(ListViewOfCars);
            foreach (Car cr in CTUL1.CarsThatUserLikeList)
            {
                AddToListView(cr);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            CarsThatUserLike CTUL = new CarsThatUserLike();
            CarsThatUserLike CTUL1 = CTUL.DeSerializeCarsJsonThatUserLike();
            for(int i = 0; i< CTUL1.CarsThatUserLikeList.Count; i++)
            {
                CTUL1.CarsThatUserLikeList.RemoveAt(i);
            }
            string currency = JsonConvert.SerializeObject(CTUL1);
            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "CarsThatUserLike.json"), currency);
            listViewOfCars.Clear();
        }
    }
}
