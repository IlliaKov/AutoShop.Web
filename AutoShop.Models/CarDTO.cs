using System;
using System.Collections.Generic;
using System.Text;

namespace AutoShop.Models
{
    public class CarDTO
    {
        public int CarID { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public string CarDocuments { get; set; }
        public int BuildYear { get; set; }
        public bool IsCarAvailable { get; set; }

        public int OrderID { get; set; }
        public OrderDTO Order { get; set; }
    }
}
