using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AutoShop.Entities
{
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarID { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public string CarDocuments { get; set; }
        public int BuildYear { get; set; }
        public bool IsCarAvailable { get; set; }

        //public int OrderID { get; set; }
        //[ForeignKey(nameof(OrderID))]
        //public Order Order { get; set; }
    }
}
