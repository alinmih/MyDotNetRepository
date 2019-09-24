using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionLibrary.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductModel> Products { get; set; }
        public double Quantity { get; set; }
        

    }
}
