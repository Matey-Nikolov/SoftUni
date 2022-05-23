using System;
using System.Collections.Generic;

namespace ASP_NET_MVC_Task2.Models
{
    public partial class Vending
    {
        public int Id { get; set; }
        public decimal Lat { get; set; }
        public decimal Lot { get; set; }
        public string? Date { get; set; }
    }
}
