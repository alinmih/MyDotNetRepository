using ProductionManagement.Models.ViewModels.MachineShop;
using ProductionManagement.Models.ViewModels.WarehouseShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductionManagement.Models.ViewModels.Dashboard
{
    public class DashboardVM
    {
        public List<MachineVM> Machines { get; set; }
        public List<MachineCategoryVM> MachineCategory { get; set; }
        //public IEnumerable<RawMaterialVM> RawMaterials { get; set; }
    }
}