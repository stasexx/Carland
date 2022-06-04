using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CarLand
{
    public class CarsThatUserLike
    {
        public List<Car> CarsThatUserLikeList { get; set; } = new List<Car>();
        public CarsThatUserLike DeSerializeCarsJsonThatUserLike()
        {
            string data = File.ReadAllText("CarsThatUserLike.json");
            return System.Text.Json.JsonSerializer.Deserialize<CarsThatUserLike>(data);
        }
        public void SerializeCarsJsonThatUserLike(CarsThatUserLike carsThatUserLike)
        {
            string currency = JsonConvert.SerializeObject(carsThatUserLike);
            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "CarsThatUserLike.json"), currency);
        }
        public void deleteCarsFromLikeList()
        {
            int counter = 0;
            Car car = new Car();
            CarsThatUserLike CTUL = DeSerializeCarsJsonThatUserLike();
            if (CTUL.CarsThatUserLikeList.Count != 0)
            {
                for (int i = 0; i <= CTUL.CarsThatUserLikeList.Count; i++)
                {
                    i = 0;
                    CTUL.CarsThatUserLikeList.RemoveAt(i);
                    counter++;
                }
            }
            string currency = JsonConvert.SerializeObject(CTUL);
            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "CarsThatUserLike.json"), currency);
        }
        public void TxtHelper()
        {
            string MainString = "";
            Car car = new Car();
            CarsThatUserLike CTUL = new CarsThatUserLike();
            CarsThatUserLike CTUL1 = CTUL.DeSerializeCarsJsonThatUserLike();
            foreach (Car cr in CTUL1.CarsThatUserLikeList)
            {
                string line = $"Автомобіль, котрий вам сподобався!\r\nМарка автомобіля : {cr.Mark} \r\nТехнічні характеристики : {cr.TechChr} \r\n Ціна : {cr.Cost}";
                MainString += "\r\n\r\n\r\n\r\n" + line;
            }
            File.WriteAllText(@"D:\CarLand\CarLand\CarLand\documents\LikeList.txt", MainString);
        }
    }
}
