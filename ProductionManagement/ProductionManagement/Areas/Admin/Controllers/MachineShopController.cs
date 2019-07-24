using ProductionManagement.Models.Data;
using ProductionManagement.Models.ViewModels.MachineShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductionManagement.Areas.Admin.Controllers
{
    public class MachineShopController : Controller
    {
        // GET: Admin/MachineShop/MachineCategory
        [HttpGet]
        public ActionResult MachineCategory()
        {
            //TODO Implement MachineCategory View

            //set a list where to put machines categories
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
            return View(machineCategories);
        }

        //Post: Admin/Pages/ReorderPages
        [HttpPost]
        public void ReorderCategories(int[] id)
        {
            //connect to db
            using (ProductionDb productionDb = new ProductionDb())
            {
                //set the counter and dto object reference
                int counter = 1;
                MachineCategoryDTO dto;
                //for each item in id array search in database
                //set the sorting property to counter
                //savechanges
                //increment the counter
                foreach (var item in id)
                {
                    dto = productionDb.MachineCategories.Find(item);
                    dto.Sorting = counter;

                    productionDb.SaveChanges();
                    counter++;
                }
            }
        }

        //Get: /Admin/MachineShop/DeleteCategory/id
        [HttpGet]
        public ActionResult DeleteCategory(int id)
        {
            using (ProductionDb productionDb = new ProductionDb())
            {
                //get the dto by id
                MachineCategoryDTO dto = productionDb.MachineCategories.Find(id);

                //remove the dto from database
                productionDb.MachineCategories.Remove(dto);
                productionDb.SaveChanges();

            }
            return RedirectToAction("MachineCategory");
        }

        public string AddNewMachineCategory(string catName)
        {
            string id;
            using (ProductionDb productionDb = new ProductionDb())
            {
                //check if the category name allready exists in db
                if (productionDb.MachineCategories.Any(x=> x.Name ==catName))
                {
                    return "categoryTaken";
                }

                //set the dto oject
                MachineCategoryDTO dto = new MachineCategoryDTO();
                dto.Name = catName;
                dto.Slug = catName.Replace(" ", "-").ToLower();
                dto.Sorting = 100;

                //insert data into db
                productionDb.MachineCategories.Add(dto);
                productionDb.SaveChanges();
                id = dto.Id.ToString();
            }

            return id;
        }

        public string RenameCategory(string newCatName, int id)
        {

            using (ProductionDb productionDb = new ProductionDb())
            {
                //check if category allready exists
                if (productionDb.MachineCategories.Any(x=> x.Name == newCatName))
                {
                    return "titletaken";
                }
                MachineCategoryDTO dto = productionDb.MachineCategories.Find(id);
                dto.Name = newCatName;
                dto.Slug = newCatName.Replace(" ", "-").ToLower();

                productionDb.SaveChanges();
            }
            return "ok";
           
        }

        //Get: /Admin/MachineShop/AddMachine
        [HttpGet]
        public ActionResult AddMachine()
        {
            MachineVM model = new MachineVM();

            using (ProductionDb productionDb = new ProductionDb())
            {
                //get into model the db machinecategories from tblMachineCategories
                model.Categories = new SelectList(
                    productionDb.MachineCategories.OrderBy(x=>x.Sorting).ToList(),"Id","Name");
            }

            return View(model);
        }

        //Post: /Admin/MachineShop/AddMachine
        [HttpPost]
        public ActionResult AddMachine(MachineVM model)
        {
            //Check model state
            if (!ModelState.IsValid)
            {
                using (ProductionDb productionDb = new ProductionDb())
                {
                    model.Categories = new SelectList(
                        productionDb.MachineCategories.OrderBy(x => x.Sorting).ToList(), "Id", "Name");
                }                
                return View(model);
            }
            MachineDTO machineDTO = new MachineDTO();
            using (ProductionDb productionDb = new ProductionDb())
            {
                //check if name allready exists
                if (productionDb.Machines.Any(x=>x.Name == model.Name))
                {
                    //repopulate the categories
                    model.Categories = new SelectList(
                        productionDb.MachineCategories.OrderBy(x=>x.Sorting).ToList(),"Id","Name");
                    //Set model error
                    ModelState.AddModelError("", "That name allready exits.");
                    return View(model);
                    
                }

                //set the prop names
                machineDTO.Name = model.Name;
                machineDTO.Slug = model.Name.Replace(" ", "-").ToLower();
                machineDTO.MachineCategoryId = model.MachineCategoryId;
                machineDTO.HourRate = model.HourRate;
                //get the machinecategory name from db
                MachineCategoryDTO categoryDTO = productionDb.MachineCategories.FirstOrDefault(x => x.Id == model.MachineCategoryId);
                machineDTO.MachineCategoryName = categoryDTO.Name;

                //add machine to db
                productionDb.Machines.Add(machineDTO);
                productionDb.SaveChanges();
            }
            //set temp data
            TempData["SM"] = "You have added a machine";

            return RedirectToAction("AddMachine");
        }
    }
}
