using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AutoShop.Entities
{
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientID { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Birthday { get; set; }
        public string PassportData { get; set; }
        public string HomeAdress { get; set; }
        public string PhoneNumber { get; set; }
    }
}
