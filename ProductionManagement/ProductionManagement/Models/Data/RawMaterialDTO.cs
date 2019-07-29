using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProductionManagement.Models.Data
{
    //table annotation
    [Table("tblRawMaterial")]
    public class RawMaterialDTO
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public int RawTypeId { get; set; }
        public string RawTypeName { get; set; }
        public decimal Lenght { get; set; }
        public decimal Width { get; set; }
        public decimal Thickness { get; set; }
        public string MeasureUnit { get; set; }
        public decimal Price { get; set; }
        public decimal Stock { get; set; }

        //set the foreign key
        [ForeignKey("RawTypeId")]
        public RawMaterialTypeDTO RawMaterialType { get; set; }

    }
}