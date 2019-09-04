using ProductionManagement.Models.Data;
using ProductionManagement.Models.ViewModels.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductionManagement.Controllers
{
    public class PagesController : Controller
    {
        // GET: Pages
        public ActionResult Index(string page="")
        {
            //check if page is empty
            if (page =="")
            {
                page = "home";
            }

            //declare model and dto
            PageVM model;
            PagesDTO dto;

            //check if page exists, if not set it to home and redirect according
            using (ProductionDb productionDb = new ProductionDb())
            {
                if (!productionDb.Pages.Any(x=>x.Slug.Equals(page)))
                {
                    return RedirectToAction("Index", new { page=""});
                }
            }

            //get the dto
            using (ProductionDb productionDb = new ProductionDb())
            {
                dto = productionDb.Pages.Where(x => x.Slug.Equals(page)).FirstOrDefault();
            }

            //set the title with ViewBag object
            ViewBag.PageTitle = dto.Title;

            //check if have sidebar
            if (dto.HasSideBar == true)
            {
                ViewBag.SideBar = "Yes";
            } else
            {
                ViewBag.SideBar = "No";
            }

            //set the model
            model = new PageVM(dto);

            return View(model);
        }

        //controller to render partial view
        public ActionResult PagesMenuPartial()
        {
            //declare a list of pages
            List<PageVM> pageVMList;

            //get all the pages from db except home
            using (ProductionDb productionDb = new ProductionDb())
            {
                pageVMList = productionDb.Pages.ToArray().OrderBy(x => x.Sorting).Where(x => x.Slug != "home").Select(x => new PageVM(x)).ToList();
            }

            return PartialView(pageVMList);
        }
    }
}