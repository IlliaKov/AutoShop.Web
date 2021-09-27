using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AutoShop.Entities
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }
        public string OrderDate { get; set; }
        public int OrderNumber { get; set; }

        public int ClientID { get; set; }
        [ForeignKey(nameof(ClientID))]
        public Client Client { get; set; }

        public int ManagerID { get; set; }
        [ForeignKey(nameof(ManagerID))]
        public Manager Manager { get; set; }

        public int CarID { get; set; }
        [ForeignKey(nameof(CarID))]
        public Car Car { get; set; }

    }
}
