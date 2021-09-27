using System;
using System.Collections.Generic;
using System.Text;

namespace AutoShop.Models
{
    public class ClientDTO
    {
        public int ClientID { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Birthday { get; set; }
        public string PassportData { get; set; }
        public string HomeAdress { get; set; }
        public string PhoneNumber { get; set; }
    }
}
