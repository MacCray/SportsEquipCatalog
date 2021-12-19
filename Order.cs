using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsEquipCatalog
{
    public class Order
    {
        public List<Equipment> equipmentForRent = new();
        public double TotalPrice { get; set; }
        public double Pledge { get; set; }
        public int OrderTime { get; set; }
        public Client client { get; set; }

        public Order(List<Equipment> equipmentForRent,int OrderTime,Client client)
        {
            this.equipmentForRent = equipmentForRent;
            this.OrderTime = OrderTime;
            this.client = client;
            CalculateTotalPrice();
            Pledge = TotalPrice * 5;
        }
        void CalculateTotalPrice()
        {
            equipmentForRent.ForEach(equ => TotalPrice += equ.Price);
            if (OrderTime >= 7 || client.IsRegular)
            {
                TotalPrice *= 0.95;
            }
        }
    }
}
