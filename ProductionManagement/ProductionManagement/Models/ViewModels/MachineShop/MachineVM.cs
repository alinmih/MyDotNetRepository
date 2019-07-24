using ProductionManagement.Models.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductionManagement.Models.ViewModels.MachineShop
{
    public class MachineVM
    {
        public MachineVM()
        {
        }

        public MachineVM(MachineDTO row)
        {
            Id = row.Id;
            Name = row.Name;
            Slug = row.Slug;
            MachineCategoryName = row.MachineCategoryName;
            MachineCategoryId = row.MachineCategoryId;
            HourRate = row.HourRate;
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Slug { get; set; }
        public string MachineCategoryName { get; set; }
        [Required]
        public int MachineCategoryId { get; set; }
        public decimal HourRate { get; set; }

        //declare the Categories list prop with IEnumerable<SelectListItem> class
        public IEnumerable<SelectListItem> Categories { get; set; }
    }
}