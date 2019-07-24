using ProductionManagement.Models.Data;
using ProductionManagement.Models.ViewModels.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductionManagement.Areas.Admin.Controllers
{
    public class PagesController : Controller
    {
        // GET: Admin/Pages
        public ActionResult Index()
        {
            List<PageVM> pages;

            using (ProductionDb productionDb = new ProductionDb())
            {
                //get pages from db and put them in list
                pages = productionDb.Pages.ToArray().OrderBy(x => x.Sorting).Select(x => new PageVM(x)).ToList();
            }
            return View(pages);
        }

        //Get: Admin/Pages/AddPage
        [HttpGet]
        public ActionResult AddPage()
        {
            return View();
        }

        //Post: Admin/Pages/AddPage
        [HttpPost]
        public ActionResult AddPage(PageVM page)
        {
            //check if model is valid
            if (!ModelState.IsValid)
            {
                return View(page);
            }
            //connect to db
            using (ProductionDb productionDb = new ProductionDb())
            {
                //init page DTO
                PagesDTO dto = new PagesDTO();

                string slug = "";
                //check if slug is empty of has any spaces
                if (string.IsNullOrWhiteSpace(page.Slug))
                {
                    slug = page.Title.Replace(" ", "-").ToLower();
                }
                else
                {
                    slug = page.Slug.Replace(" ", "-").ToLower();
                }
                //check if exists allready anothe title or slug with the same name
                if(productionDb.Pages.Any(x=>x.Title == page.Title) || productionDb.Pages.Any(x=>x.Slug == slug))
                {
                    ModelState.AddModelError("", "That title or slug allready exists!");
                    return View(page);
                }
                //if reach this point set dto values with model values
                dto.Title = page.Title;
                dto.Slug = slug;
                dto.Body = page.Body;
                dto.Sorting = 100;
                dto.HasSideBar = page.HasSideBar;

                //add dto to pages and save to Db
                productionDb.Pages.Add(dto);
                productionDb.SaveChanges();
            }

            //set temp data to alert the user if added a new page
            TempData["SM"] = "You have added a new page";

            return RedirectToAction("AddPage");
        }

        //Get: Admin/Pages/EditPage/id
        [HttpGet]
        public ActionResult EditPage(int id)
        {
            PageVM model;

            using (ProductionDb productionDb = new ProductionDb())
            {
                //check if id exists in db
                PagesDTO dto = productionDb.Pages.Find(id);
                if(dto == null)
                {
                    return Content("That page doesn't exists!");
                }
                //get the item with that id
                model = new PageVM(dto);
            }
            return View(model);
        }

        //Post: Admin/Pages/EditPage/id
        [HttpPost]
        public ActionResult EditPage(PageVM page)
        {
            if (!ModelState.IsValid)
            {
                return View(page);
            }
            
            using (ProductionDb productionDb = new ProductionDb())
            {
                //get the current page from DB
                int id = page.Id;
                PagesDTO dto = productionDb.Pages.Find(id);
                string slug = "home";
                
                if (page.Slug != "home")
                {
                    if (string.IsNullOrWhiteSpace(page.Slug))
                    {
                        slug = page.Title.Replace(" ", "-").ToLower();
                    }
                    else
                    {
                        slug = page.Slug.Replace(" ", "-").ToLower();
                    }
                }

                //check if title or slug allready exists in DB
                if (productionDb.Pages.Where(x=>x.Id != id).Any(x=>x.Title == page.Title)||
                    productionDb.Pages.Where(x=>x.Id != id).Any(x=>x.Slug == slug))
                {
                    ModelState.AddModelError("", "Title or slug allready exists!");
                    return View(page);
                }
                dto.Title = page.Title;
                dto.Slug = slug;
                dto.Body = page.Body;
                //dto.Sorting = 100;
                dto.HasSideBar = page.HasSideBar;

                productionDb.SaveChanges();
            }
            TempData["SM"] = "You have edited a page!";
            return RedirectToAction("EditPage");
        }

        //Get: Admin/Pages/DetailsPage/id
        [HttpGet]
        public ActionResult DetailsPage(int id)
        {
            PagesDTO dto;
            using (ProductionDb productionDb = new ProductionDb())
            {
               dto = productionDb.Pages.Find(id);

                if (dto == null)
                {
                    return Content("Requested page does not exists!");
                }
            }
            PageVM page = new PageVM(dto);
            return View(page);
        }

        //Post: Admin/Pages/Delete/id
        [HttpGet]
        public ActionResult DeletePage(int id)
        {
            using (ProductionDb productionDb = new ProductionDb())
            {
                PagesDTO dto = productionDb.Pages.Find(id);

                productionDb.Pages.Remove(dto);
                productionDb.SaveChanges();

            }
            TempData["SM"] = "You have deleted a page!";
            return RedirectToAction("Index");
        }

        //Post: Admin/Pages/ReorderPages
        [HttpPost]
        public void ReorderPages(int[] id)
        {
            //set connection to db
            using (ProductionDb productionDb = new ProductionDb())
            {
                //set counter to 1
                int count = 1;
                //declare DTO
                PagesDTO dto;
                //Set sorting for every page
                foreach (var item in id)
                {
                    dto = productionDb.Pages.Find(item);
                    dto.Sorting = count;

                    productionDb.SaveChanges();
                    count++;
                }
            }
        }

        //Get: Admin/Pages/EditSidebar
        [HttpGet]
        public ActionResult EditSidebar()
        {
            int id = 1;
            SidebarVM model;
            using (ProductionDb productionDb = new ProductionDb())
            {
                SidebarDTO dto = productionDb.Sidebar.Find(id);
                model = new SidebarVM(dto);
            }

            return View(model);
        }

        //Post: Admin/Pages/EditSidebar
        [HttpPost]
        public ActionResult EditSidebar(SidebarVM model)
        {
            using (ProductionDb productionDb = new ProductionDb())
            {
                //find the single entry from Sidebar table
                SidebarDTO dto = productionDb.Sidebar.Find(1);
                //dto.Id = model.Id;
                dto.Body = model.Body;

                //productionDb.Sidebar.Add(dto);
                productionDb.SaveChanges();

            }
            TempData["SM"] = "You have edited the sidebar!";

            return RedirectToAction("EditSidebar");
        }
    }
}