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
            ListView();
            label1.Hide();
            label2.Hide();
        }
        public void ListView()
        {
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
        private void TakeOrder_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Doc(listViewOfCars.SelectedItems.Count, textBox3.Text, textBox2.Text);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void PersonalOffice_Click(object sender, EventArgs e)
        {
            PersonalPage personalPage = new PersonalPage();
            personalPage.Show();
            Hide();
        }
        private void LIKE_Click(object sender, EventArgs e)
        {
            CarsThatUserLike CTUL = new CarsThatUserLike();
            CarsThatUserLike CTUL1 = CTUL.DeSerializeCarsJsonThatUserLike();
            if (listViewOfCars.SelectedItems.Count == 1)
            {
                Car car = (Car)listViewOfCars.SelectedItems[0].Tag;
                CTUL1.CarsThatUserLikeList.Add(car);
                CTUL.SerializeCarsJsonThatUserLike(CTUL1);
            }
            else
            {
                label2.Show();
            }
        }
        private void ShowAllCars_Click(object sender, EventArgs e)
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
        private void CarsThatLikes_Click(object sender, EventArgs e)
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
        private void ClearListOfCarsThatLikes_Click(object sender, EventArgs e)
        {
            CarsThatUserLike CTUL = new CarsThatUserLike();
            CTUL.deleteCarsFromLikeList();
            listViewOfCars.Clear();
        }
        private void SaveLikeList_Click(object sender, EventArgs e)
        {
            CarsThatUserLike CTUL = new CarsThatUserLike();
            CTUL.TxtHelper();            
        }
    }
}
