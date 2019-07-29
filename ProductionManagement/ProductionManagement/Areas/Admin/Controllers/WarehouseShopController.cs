using ProductionManagement.Models.Data;
using ProductionManagement.Models.ViewModels.WarehouseShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductionManagement.Areas.Admin.Controllers
{
    public class WarehouseShopController : Controller
    {
        // GET: Admin/WarehouseShop/RawMaterialType
        [HttpGet]
        public ActionResult RawMaterialType()
        {
            //set a list where to put raw material categories
            List<RawMaterialTypeVM> rawMaterialTypes;

            //connect to db
            using (ProductionDb productionDb = new ProductionDb())
            {
                //find all the materials and sort them by sorting property
                rawMaterialTypes = productionDb.RawMaterialTypes
                    .ToArray()
                    .OrderBy(x => x.Sorting)
                    .Select(x => new RawMaterialTypeVM(x))
                    .ToList();

            }
            return View(rawMaterialTypes);
        }

        //Post: Admin/WarehouseShop/ReorderPages
        [HttpPost]
        public void ReorderCategories(int[] id)
        {
            //connect to db
            using (ProductionDb productionDb = new ProductionDb())
            {
                //set the counter and dto object reference
                int counter = 1;
                RawMaterialTypeDTO dto;

                //for each item in id array search in database
                //set the sorting property to counter
                //savechanges
                //increment the counter
                foreach (var item in id)
                {
                    dto = productionDb.RawMaterialTypes.Find(item);
                    dto.Sorting = counter;
                    productionDb.SaveChanges();
                    counter++;
                }
            }
        }

        //Get: /Admin/WarehouseShop/DeleteType/id
        [HttpGet]
        public ActionResult DeleteType(int id)
        {
            using (ProductionDb productionDb=new ProductionDb())
            {
                RawMaterialTypeDTO dto = productionDb.RawMaterialTypes.Find(id);

                productionDb.RawMaterialTypes.Remove(dto);
                productionDb.SaveChanges();
            }

            return RedirectToAction("RawMaterialType");
        }

        //Get: /Admin/WarehouseShop/AddNewRawMaterialType
        public string AddNewRawMaterialType(string typeName)
        {
            string id;

            using (ProductionDb productionDb=new ProductionDb())
            {
                if (productionDb.RawMaterialTypes.Any(x=>x.Name==typeName))
                {
                    return "typeTaken";
                }

                RawMaterialTypeDTO dto = new RawMaterialTypeDTO();
                dto.Name = typeName;
                dto.Slug = typeName.Replace(" ", "-").ToLower();
                dto.Sorting = 100;

                productionDb.RawMaterialTypes.Add(dto);
                productionDb.SaveChanges();
                id = dto.Id.ToString();
            }

            return id;
        }

        //Get: /Admin/WarehouseShop/RenameType
        public string RenameType(string newTypeName, int id)
        {
            using (ProductionDb productionDb=new ProductionDb())
            {
                if (productionDb.RawMaterialTypes.Any(x=>x.Name==newTypeName))
                {
                    return "typeTaken";
                }
                RawMaterialTypeDTO dto = productionDb.RawMaterialTypes.Find(id);
                dto.Name = newTypeName;
                dto.Slug = newTypeName.Replace(" ", "-");

                productionDb.SaveChanges();
            }
            return "ok";
        }

    }
}