using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionLibrary.Models
{
    public class RawMaterialModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string MeasureUnit { get; set; }
        public TechnologyModel QuantityforTechnology { get; }
        public decimal TotalPrice
        {
            get
            {
                decimal totalPrice = Price * QuantityforTechnology.Quantity;
                return totalPrice;
            }
        }
    }
}
