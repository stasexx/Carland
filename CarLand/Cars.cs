using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CarLand
{
    public class Cars
    {
        public List<Car> CarsList { get; set; } = new List<Car>();
        public List<Car> CarsListView { get; set; } = new List<Car>();
        public List<Car> AllCarsListView { get; set; } = new List<Car>();

        public void GetCars()
        {
            string FMark = "";
            Car car = new Car();
            Cars cars = DeSerializeJsonCars();
            MainUser mainUser = DeSerializeJsonUser();
            foreach (User us in mainUser.MainUserList)
            {
                FMark = us.FavoriteMark;
            }
            foreach (Car cr in cars.CarsList)
            {
                if (cr.Mark.Contains(FMark))
                {
                    foreach (User us in mainUser.MainUserList)
                    {
                        if (us.FinOpot == "25000 - 50000")
                        {
                            int costOfCar = Convert.ToInt32(cr.Cost);
                            if (costOfCar >= 20000 && costOfCar <= 50000)
                            {
                                CarsListView.Add(cr);
                            }
                        }
                        if (us.FinOpot == "10000 - 25000")
                        {
                            int costOfCar = Convert.ToInt32(cr.Cost);
                            if (costOfCar >= 10000 && costOfCar <= 25000)
                            {
                                CarsListView.Add(cr);
                            }
                        }
                        if (us.FinOpot == "50000 - 100000")
                        {
                            int costOfCar = Convert.ToInt32(cr.Cost);
                            if (costOfCar >= 50000 && costOfCar <= 100000)
                            {
                                CarsListView.Add(cr);
                            }
                        }
                        if (us.FinOpot == "100000 - 200000")
                        {
                            int costOfCar = Convert.ToInt32(cr.Cost);
                            if (costOfCar >= 100000 && costOfCar <= 2000000)
                            {
                                CarsListView.Add(cr);
                            }
                        }
                    }
                }
            }
        }
        public void GetAllCars()
        {
            Car car = new Car();
            Cars cars = DeSerializeJsonCars();
            foreach (Car cr in cars.CarsList)
            {
                AllCarsListView.Add(cr);
            }
        }
        public Cars DeSerializeJsonCars()
        {
            string data = File.ReadAllText("Cars.json");
            return JsonSerializer.Deserialize<Cars>(data);
        }
        private MainUser DeSerializeJsonUser()
        {
            string data = File.ReadAllText("User.json");
            return JsonSerializer.Deserialize<MainUser>(data);
        }
    }
}
