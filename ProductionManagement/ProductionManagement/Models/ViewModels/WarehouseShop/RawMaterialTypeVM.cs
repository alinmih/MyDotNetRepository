using ProductionManagement.Models.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductionManagement.Models.ViewModels.WarehouseShop
{
    public class RawMaterialTypeVM
    {
        public RawMaterialTypeVM()
        {
        }

        public RawMaterialTypeVM(RawMaterialTypeDTO row)
        {
            Id = row.Id;
            Name = row.Name;
            Slug = row.Slug;
            Sorting = row.Sorting;
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Slug { get; set; }
        public int Sorting { get; set; }
    }
}