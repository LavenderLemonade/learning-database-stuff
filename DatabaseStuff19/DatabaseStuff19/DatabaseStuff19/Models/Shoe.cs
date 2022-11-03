using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseStuff19.Models
{
    public class Shoe
    {
        public int ShoeId { get; set; }
        public string ShoeName { get; set; }
        public string Manufacturer { get; set; }
        public string ShoeType { get; set; }
        public int ShoeSize { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
