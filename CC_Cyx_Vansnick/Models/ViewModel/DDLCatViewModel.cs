using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CC_Cyx_Vansnick.Models.ViewModel
{
    public class DDLCatViewModel
    {
        public string ProductType { get; set; }
        public List<SelectListItem> ProductTypes { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "Tout", Text = "Tout" },
            new SelectListItem { Value = "Viande", Text = "Viande" },
            new SelectListItem { Value = "Poisson", Text = "Poisson" },
            new SelectListItem { Value = "Légume", Text = "Légume" },
            new SelectListItem { Value = "Fruit", Text = "Fruit" },
            new SelectListItem { Value = "Boisson", Text = "Boisson" },
        };
        public DDLCatViewModel(string pt)
        {
            ProductType = pt;
        }
    }
}
