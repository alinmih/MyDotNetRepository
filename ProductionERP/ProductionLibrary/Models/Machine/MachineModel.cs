using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionLibrary.Models.Machine
{
    public class MachineModel
    {
        /// <summary>
        /// Machine Unique ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Machine Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Machine Hour Rate in unit/hour
        /// </summary>
        public decimal HourRate { get; set; }

        /// <summary>
        /// Machine Category Model
        /// </summary>
        public MachineCategoryModel MachineCategory { get; set; }

    }
}
