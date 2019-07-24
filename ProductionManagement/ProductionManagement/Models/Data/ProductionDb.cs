using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProductionManagement.Models.Data
{
    public class ProductionDb : DbContext
    {
        public DbSet<PagesDTO> Pages { get; set; }
        public DbSet<SidebarDTO> Sidebar { get; set; }
        public DbSet<MachineCategoryDTO> MachineCategories { get; set; }
        public DbSet<MachineDTO> Machines { get; set; }

    }
}