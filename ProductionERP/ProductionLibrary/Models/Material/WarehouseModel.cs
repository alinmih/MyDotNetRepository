using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionLibrary.Models.Material
{
    public class WarehouseModel
    {
        /// <summary>
        /// Unique ID for Warehouse
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Warehouse Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Warehouse Number
        /// </summary>
        public int Number { get; set; }

    }
}
