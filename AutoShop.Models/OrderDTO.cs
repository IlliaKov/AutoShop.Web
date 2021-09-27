using System;
using System.Collections.Generic;
using System.Text;

namespace AutoShop.Models
{
    public class OrderDTO
    {
        public int OrderID { get; set; }
        public string OrderDate { get; set; }
        public int OrderNumber { get; set; }

        public int ClientID { get; set; }
        public ClientDTO Client { get; set; }

        public int ManagerID { get; set; }
        public ManagerDTO Manager { get; set; }

        public int CarID { get; set; }
        public CarDTO Car { get; set; }
    }
}
