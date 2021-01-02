using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevOpsPractWA.Models
{
    public class CustomerData
    {
        public int ID;
        public string Name;

        public CustomerData(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
