using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionLibrary.Models
{
    public class OperationModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public MachineModel Machine { get; set; }
        public decimal SetupTime { get; set; }
        public decimal OperationTime { get; set; }
        public TechnologyModel TechnologyForQuantity { get; }
        public decimal TotalOperationCost {
            get
            {
                decimal totalPrice = (SetupTime * Machine.HourRate) + (TechnologyForQuantity.Quantity * Machine.HourRate * OperationTime);
                return totalPrice;
            }
        }

       
    }
}
