using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProductionManagement.Models.Data
{
    //set table anotation
    [Table("tblMachines")]
    public class MachineDTO
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string MachineCategoryName { get; set; }
        public int MachineCategoryId { get; set; }
        public decimal HourRate { get; set; }


        //set the foreign key and the navigation property to MachineCategoryDTO
        [ForeignKey("MachineCategoryId")]
        public MachineCategoryDTO MachineCategory { get; set; }

    }
}