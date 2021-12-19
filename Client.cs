using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsEquipCatalog
{
    public class Client
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public bool IsRegular { get; set; }
        public Client(string Name, string Number, bool IsRegular)
        {
            this.Name = Name;
            this.Number = Number;
            this.IsRegular = IsRegular;
        }
    }
}
