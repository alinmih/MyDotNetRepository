using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionLibrary.Models.Material
{
    public class RawMaterialModel
    {

        /// <summary>
        /// Unique ID for material model
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Raw Material Name
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Raw Material Category Model
        /// </summary>
        public MaterialCategoryModel MaterialCategory { get; set; }
        
        /// <summary>
        /// Raw Material Lenght
        /// </summary>
        public double Lenght { get; set; }
        
        /// <summary>
        /// Raw Material Width
        /// </summary>
        public double Width { get; set; }
        
        /// <summary>
        /// Raw Material Thick
        /// </summary>
        public double Thick { get; set; }
        
        /// <summary>
        /// Raw Material Measuring Unit
        /// </summary>
        public MaterialMeasureUnit MaterialMeasureUnit { get; set; }
        
        /// <summary>
        /// Raw Material Price / Measuring unit
        /// </summary>
        public decimal Price { get; set; }
        
        /// <summary>
        /// Raw Material Stock Quantity
        /// </summary>
        public decimal Stock { get; set; }
        
        /// <summary>
        /// Raw Material Stock value, only get based on Price and current Stock
        /// </summary>
        public decimal Value {
            get
            {
                return Price * Stock;
            }
        }
        
        /// <summary>
        /// Raw Material Warehouse Location
        /// </summary>
        public WarehouseModel Location { get; set; }

    }
}
