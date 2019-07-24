using ProductionManagement.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductionManagement.Models.ViewModels.Pages
{
    public class SidebarVM
    {
        public SidebarVM()
        {
        }

        public SidebarVM(SidebarDTO dto)
        {
            Id = dto.Id;
            Body = dto.Body;
        }
        public int Id { get; set; }
        public string Body { get; set; }
    }
}