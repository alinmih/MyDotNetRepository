using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProductionManagement.Models.Data
{
    public class ProductionDb : DbContext
    {
        //set the layout
        public DbSet<PagesDTO> Pages { get; set; }
        public DbSet<SidebarDTO> Sidebar { get; set; }

        //set the machines
        public DbSet<MachineCategoryDTO> MachineCategories { get; set; }
        public DbSet<MachineDTO> Machines { get; set; }

        //set the rawmaterial
        public DbSet<RawMaterialTypeDTO> RawMaterialTypes { get; set; }
        public DbSet<RawMaterialDTO> RawMaterials { get; set; }


    }
}