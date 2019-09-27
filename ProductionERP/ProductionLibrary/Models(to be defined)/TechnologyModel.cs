using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionLibrary.Models
{
    public class TechnologyModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Quantity { get; set; }

        public List<OperationModel> Operations { get; set; }
        public List<RawMaterialModel> RawMaterials { get; set; }
        

    }
}
