using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using CC_Cyx_Vansnick.Models.POCO;

namespace CC_Cyx_Vansnick.Models.ViewModel
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "le pseudo est requis")]
        [Display(Name = "Pseudo")]
        [DataType(DataType.Text)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Le prénom est requis")]
        [Display(Name = "Prénom")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Le nom est requis")]
        [Display(Name = "Nom")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "L'Email est requis")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Le numéro de téléphone est requis")]
        [Display(Name = "Numéro de téléphone")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "La rue est requise")]
        [Display(Name = "Rue")]
        [DataType(DataType.Text)]
        public string Street { get; set; }

        [Required(ErrorMessage = "La numéro est requis")]
        [Display(Name = "Numéro")]
        public int Number { get; set; }

        [Required(ErrorMessage = "La ville est requise")]
        [Display(Name = "Ville")]
        [DataType(DataType.Text)]
        public string City { get; set; }

        [Required(ErrorMessage = "La code postal est requis")]  
        [Display(Name = "Code Postal")]
        [DataType(DataType.PostalCode)]
        public int Codep { get; set; }

        [Required(ErrorMessage = "Le mdp est requis")]
        [Display(Name = "Mot de Passe")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
