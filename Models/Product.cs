using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ders2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public bool isPuslish { get; set; }
        public int ExpireDate { get; set; }
        public string? Description { get; set; }
        public string Color { get; set; }
    }
}
