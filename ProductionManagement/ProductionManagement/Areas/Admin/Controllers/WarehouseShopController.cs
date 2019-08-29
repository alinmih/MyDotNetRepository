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
            using (ProductionDb productionDb = new ProductionDb())
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

            using (ProductionDb productionDb = new ProductionDb())
            {
                if (productionDb.RawMaterialTypes.Any(x => x.Name == typeName))
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
            using (ProductionDb productionDb = new ProductionDb())
            {
                if (productionDb.RawMaterialTypes.Any(x => x.Name == newTypeName))
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


        //GET: Admin/WarehouseShop/RawMaterials
        [HttpGet]
        public ActionResult RawMaterials(int? catId)
        {
            //TODO implement controller
            List<RawMaterialVM> rawMaterials;
            
            using (ProductionDb productionDb = new ProductionDb())
            {
                //get the list of rawMaterials from db
                rawMaterials = productionDb.RawMaterials.ToArray().
                    Where(x => x.RawTypeId == catId || catId == 0 || catId == null).
                    Select(x => new RawMaterialVM(x)).ToList();

                //get the material types from rawMaterials list
                var materialTypes = rawMaterials.Select((id, matType)=> new { id.RawTypeId, id.RawTypeName}).ToList();
                

                //populate the rawMaterials categories select list in a ViewBag object
                ViewBag.RawMaterialsCategories = new SelectList(materialTypes.ToList(), "RawTypeId", "RawTypeName");

                //get the selected category
                ViewBag.SelectedCategory = catId.ToString();
            }

            return View(rawMaterials);
        }

        //GET: Admin/WarehouseShop/AddRawMaterial
        [HttpGet]
        public ActionResult AddRawMaterial()
        {
            RawMaterialVM model = new RawMaterialVM();

            using (ProductionDb productionDb = new ProductionDb())
            {
                model.RawTypes = new SelectList(
                    productionDb.RawMaterialTypes.OrderBy(x => x.Sorting).ToList(), "Id", "Name");
            }

            return View(model);
        }

        //POST: Admin/WarehouseShop/AddRawMaterial
        [HttpPost]
        public ActionResult AddRawMaterial(RawMaterialVM model)
        {
            if (!ModelState.IsValid)
            {
                using (ProductionDb productionDb = new ProductionDb())
                {
                    //repopulate the categories
                    model.RawTypes = new SelectList(
                        productionDb.RawMaterialTypes.OrderBy(x => x.Sorting).ToList(), "Id", "Name");

                }
                return View(model);
            }

            RawMaterialDTO rawMaterialDTO = new RawMaterialDTO();

            using (ProductionDb productionDb = new ProductionDb())
            {
                //check if name allready exists
                if (productionDb.RawMaterials.Any(x=>x.Name == model.Name))
                {
                    //repopulate the categories
                    model.RawTypes = new SelectList(
                        productionDb.RawMaterialTypes.OrderBy(x => x.Sorting).ToList(), "Id", "Name");
                    ModelState.AddModelError("", "That name allready exists.");
                    return View(model);
                }

                //set the prop names
                rawMaterialDTO.Name = model.Name;
                rawMaterialDTO.Slug = model.Name.Replace(" ", "-").ToLower();
                rawMaterialDTO.RawTypeId = model.RawTypeId;
                RawMaterialTypeDTO typeDTO = productionDb.RawMaterialTypes.FirstOrDefault(x => x.Id == model.RawTypeId);
                rawMaterialDTO.RawTypeName = typeDTO.Name;
                rawMaterialDTO.Lenght = model.Lenght;
                rawMaterialDTO.Width = model.Width;
                rawMaterialDTO.Thickness = model.Thickness;
                rawMaterialDTO.MeasureUnit = model.MeasureUnit;
                rawMaterialDTO.Price = model.Price;
                rawMaterialDTO.Stock = model.Stock;

                //add rawMaterialDTO to db
                productionDb.RawMaterials.Add(rawMaterialDTO);
                productionDb.SaveChanges();
            }

            //set temp data message
            TempData["SM"] = "You have added a material.";

            return RedirectToAction("AddRawMaterial");
        }

        //GET: Admin/WarehouseShop/EditRawMaterial/id
        [HttpGet]
        public ActionResult EditRawMaterial(int id)
        {
            RawMaterialVM model;

            //connect to db
            using (ProductionDb productionDb = new ProductionDb())
            {
                //GetHashCode the object from db
                RawMaterialDTO dto = productionDb.RawMaterials.Find(id);

                if (dto == null)
                {
                    return Content("That material does not exists");
                }

                model = new RawMaterialVM(dto);

                model.RawTypes = new SelectList(productionDb.RawMaterialTypes.ToList(), "Id", "Name");
            }

            return View(model);
        }

        //GET: Admin/WarehouseShop/EditRawMaterial/id
        [HttpPost]
        public ActionResult EditRawMaterial(RawMaterialVM model)
        {
            int id = model.Id;

            //populare dropdown list
            using (ProductionDb productionDb = new ProductionDb())
            {
                model.RawTypes = new SelectList(productionDb.RawMaterialTypes.ToList(), "Id", "Name");
            }

            //check model state
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            //check if name is unique
            using (ProductionDb productionDb = new ProductionDb())
            {
                if (productionDb.RawMaterials.Where(x=>x.Id != id).Any(x=>x.Name == model.Name))
                {
                    ModelState.AddModelError("", "That material allready exists");
                    return View(model);
                }
            }

            //post the data to db
            using (ProductionDb productionDb = new ProductionDb())
            {
                RawMaterialDTO dto = productionDb.RawMaterials.Find(id);

                dto.Name = model.Name;
                dto.Slug = model.Name.Replace(" ", "-").ToLower();
                dto.RawTypeId = model.RawTypeId;
                //get the material type name from table RawMaterialTypes
                RawMaterialTypeDTO materialTypeDTO = productionDb.RawMaterialTypes.FirstOrDefault(x => x.Id == model.RawTypeId);
                dto.RawTypeName = materialTypeDTO.Name;

                dto.Lenght = model.Lenght;
                dto.Width = model.Width;
                dto.Thickness = model.Thickness;
                dto.MeasureUnit = model.MeasureUnit;
                dto.Price = model.Price;
                dto.Stock = model.Stock;

                productionDb.SaveChanges();

            }

            TempData["SM"] = "Material has been updated";

            return View(model);
        }

        [HttpGet]
        public ActionResult DeleteRawMaterial(int id)
        {
            using (ProductionDb productionDb = new ProductionDb())
            {
                RawMaterialDTO dto = productionDb.RawMaterials.Find(id);

                productionDb.RawMaterials.Remove(dto);

                productionDb.SaveChanges();
            }

            return RedirectToAction("RawMaterials");
        }
    }
}