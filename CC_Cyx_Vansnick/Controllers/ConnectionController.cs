using CC_Cyx_Vansnick.DAL.IDAL;
using Microsoft.AspNetCore.Mvc;
using CC_Cyx_Vansnick.Models.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using CC_Cyx_Vansnick.Models.ViewModel;

namespace CC_Cyx_Vansnick.Controllers
{
    public class ConnectionController : Controller
    {
        private readonly IUsersDAL _usersDAL;
        private readonly IEmployeesDAL _employeesDAL;
       
        public ConnectionController(IUsersDAL usersDAL, IEmployeesDAL employeesDAL)
        {
            _usersDAL = usersDAL;
            _employeesDAL = employeesDAL;
        }

        public IActionResult LogIn()
        {
            ConnectionViewModel rvm = new ConnectionViewModel();
            rvm.Type = "Client";
            return View(rvm);
        }
        [HttpPost]
        public IActionResult LogIn(ConnectionViewModel connectionviewmodel)
        {
            if (connectionviewmodel.Type == "Client")
            {
                Client c = _usersDAL.FindUser(connectionviewmodel.Email, connectionviewmodel.Password);
                if (c != null)
                {
                    //Creation of the session variable
                    HttpContext.Session.SetString("IdUser", "A" + c.IdUser);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewData["ErrorMessage"] = "Email or Password incorrect";
                    return RedirectToAction("LogIn", "Connection");
                }
            }
            else
            {
                Employee e = _employeesDAL.FindEmployee(connectionviewmodel.Email, connectionviewmodel.Password);
                if (e != null)
                {
                    if (connectionviewmodel.Type == "Cashier")
                    {
                        HttpContext.Session.SetString("IdUser", "B" + e.IdUser);
                        return RedirectToAction("HomeOrderPicker", "OrderManagement");
                    }
                    else
                    {
                        HttpContext.Session.SetString("IdUser", "C" + e.IdUser);
                        return RedirectToAction("HomeCashier", "OrderManagement");
                    } 
                }else
                {
                    ViewData["ErrorMessage"] = "Email or Password incorrect";
                    return RedirectToAction("LogIn", "Connection");
                }
            }
            /*
            //if user exist
            if (u != null)
            {
                //Creation of the session variable
                HttpContext.Session.SetInt32("IdUser", u.IdUser);
                if(u.Type == "Client")
                {
                    // BIEN SPE LES VUES VERS OU ON VEUT ENVOYER ELLES SONT PAS ENCORE CRAFT 
                    return RedirectToAction("Index", "Home");
                }
                if (u.Type == "OrderPicker")
                {
                    return RedirectToAction("HomeOrderPicker", "OrderManagement");
                }
                else {
                    return RedirectToAction("HomeCashier", "OrderManagement");
                }
            }
            //If user doesn't exist -> redirection to sign in
            else
            {
                ViewData["ErrorMessage"] = "User or Password incorrect";
                return RedirectToAction("LogIn", "Connection");
            }*/
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
