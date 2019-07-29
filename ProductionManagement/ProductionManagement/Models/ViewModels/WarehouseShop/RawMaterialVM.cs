using ProductionManagement.Models.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductionManagement.Models.ViewModels.WarehouseShop
{
    public class RawMaterialVM
    {
        public RawMaterialVM()
        {
        }

        public RawMaterialVM(RawMaterialDTO row)
        {
            Id = row.Id;
            Name = row.Name;
            Slug = row.Slug;
            RawTypeId = row.RawTypeId;
            RawTypeName = row.RawTypeName;
            Lenght = row.Lenght;
            Width = row.Width;
            Thickness = row.Thickness;
            MeasureUnit = row.MeasureUnit;
            Price = row.Price;
            Stock = row.Stock;
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Slug { get; set; }
        [Required]
        public int RawTypeId { get; set; }
        public string RawTypeName { get; set; }
        public decimal Lenght { get; set; }
        public decimal Width { get; set; }
        public decimal Thickness { get; set; }
        public string MeasureUnit { get; set; }
        public decimal Price { get; set; }
        public decimal Stock { get; set; }

        //declare the types of raw material in a Ienumerable SelectListItem object type
        public IEnumerable<SelectListItem> RawTypes{ get; set; }
    }
}