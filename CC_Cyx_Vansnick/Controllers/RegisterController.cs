using CC_Cyx_Vansnick.DAL.IDAL;
using Microsoft.AspNetCore.Http;
using CC_Cyx_Vansnick.Models.POCO;
using CC_Cyx_Vansnick.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CC_Cyx_Vansnick.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IUsersDAL _usersDAL;
        public RegisterController(IUsersDAL usersDAL)
        {
            _usersDAL = usersDAL;
        }
        public IActionResult Index()
        {
            RegisterViewModel rvm = new RegisterViewModel();
            return View(rvm);
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                Client client = new Client
                {
                    FirstName = registerViewModel.FirstName,
                    LastName = registerViewModel.LastName,
                    Email = registerViewModel.Email,
                    Address = registerViewModel.Street + " " + registerViewModel.Number + ", " + registerViewModel.City + " " + registerViewModel.Codep,
                    PhoneNumber = registerViewModel.PhoneNumber,
                    Password = registerViewModel.Password,
                };
                client = new Client(client.Password, client.FirstName, client.LastName, client.Email, client.PhoneNumber, client.Address);
                client.Create(_usersDAL);

                return RedirectToAction("Index", "Home");
            }
            return View();


        }
    }
}
