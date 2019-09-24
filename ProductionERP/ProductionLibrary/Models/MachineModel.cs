using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionLibrary.Models
{
    public class MachineModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal HourRate { get; set; }
        public MachineCategoryModel MachineCategory { get; set; }


    }
}
