using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CC_Cyx_Vansnick.Models.ViewModel
{
    public class DDLDayViewModel
    {
        public string Day { get; set; }
        public List<SelectListItem> Days { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = DateTime.Today.AddDays(1).ToString("MM/dd/yyyy") },
            new SelectListItem { Value = "2", Text = DateTime.Today.AddDays(2).ToString("MM/dd/yyyy") },
            new SelectListItem { Value = "3", Text = DateTime.Today.AddDays(3).ToString("MM/dd/yyyy") },
            new SelectListItem { Value = "4", Text = DateTime.Today.AddDays(4).ToString("MM/dd/yyyy") },
            new SelectListItem { Value = "5", Text = DateTime.Today.AddDays(5).ToString("MM/dd/yyyy") },
            new SelectListItem { Value = "6", Text = DateTime.Today.AddDays(6).ToString("MM/dd/yyyy") },
            new SelectListItem { Value = "7", Text = DateTime.Today.AddDays(7).ToString("MM/dd/yyyy") }
        };
    }
}
