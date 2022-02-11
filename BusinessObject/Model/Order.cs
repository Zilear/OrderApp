using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Model
{
    public class Order
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; } = new();
        public int Quantity { get; set; } 
        public DateTime DateTime { get; set; } = DateTime.Now;
        
    }
}
