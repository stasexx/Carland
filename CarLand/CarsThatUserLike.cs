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
            return JsonSerializer.Deserialize<CarsThatUserLike>(data);
        }
    }

}
