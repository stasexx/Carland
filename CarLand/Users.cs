using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLand
{
    [Serializable]
    public class Users
    {
        public List<User> UsersList { get; set; } = new List<User>();
    }
}
