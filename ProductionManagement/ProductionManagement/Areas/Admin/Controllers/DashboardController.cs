using ProductionManagement.Models.Data;
using ProductionManagement.Models.ViewModels.Dashboard;
using ProductionManagement.Models.ViewModels.MachineShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductionManagement.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Admin/Dashboard
        public ActionResult Index()
        {
            DashboardVM model = new DashboardVM();
            
            List<MachineVM> machines;
            
            using (ProductionDb productionDb = new ProductionDb())
            {
                //find all the machines and sort them by sortin property
                machines = productionDb.Machines
                    .ToArray()
                    .Select(x => new MachineVM(x)).ToList();
                   
            }
            model.Machines = machines;
            List<MachineCategoryVM> machineCategories;

            //connect to db
            using (ProductionDb productionDb = new ProductionDb())
            {
                //find all the machines and sort them by sortin property
                machineCategories = productionDb.MachineCategories
                    .ToArray()
                    .OrderBy(x => x.Sorting)
                    .Select(x => new MachineCategoryVM(x))
                    .ToList();
            }
            model.MachineCategory = machineCategories;
            return View(model);
            //TODO implement view
        }
    }
}