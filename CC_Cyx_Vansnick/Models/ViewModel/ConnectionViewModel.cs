using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CC_Cyx_Vansnick.Models.ViewModel
{
    public class ConnectionViewModel
    {
        [Required(ErrorMessage = "Le pseudo est requis")]
        [Display(Name = "Email")]
        [DataType(DataType.Text)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Le mdp est requis")]
        [Display(Name = "Mot de Passe")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string Type { get; set; }
        public List<SelectListItem> Types { get; } = new List<SelectListItem>()
        {
            new SelectListItem() { Value = "Client", Text = "Client"},
            new SelectListItem() { Value = "OrderPicker", Text = "OrderPicker"},
            new SelectListItem() { Value = "Cashier", Text = "Cashier"},
        };
        
    }
}
