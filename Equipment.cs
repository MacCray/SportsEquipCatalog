using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsEquipCatalog
{
    public class Equipment
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public bool Available { get; set; }

        public Equipment(string Name, double Price, bool Available)
        {
            this.Name = Name;
            this.Price = Price;
            this.Available = Available;
        }
    }
}
