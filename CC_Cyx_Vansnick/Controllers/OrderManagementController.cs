using CC_Cyx_Vansnick.DAL.IDAL;
using CC_Cyx_Vansnick.Models.POCO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CC_Cyx_Vansnick.Controllers
{
    public class OrderManagementController : Controller
    {
        private readonly ICommandsDAL _commandsDAL;
        public OrderManagementController(ICommandsDAL commandsDAL)
        {
            _commandsDAL = commandsDAL;
        }
        
        public IActionResult HomeCashier()
        {

            //List<Command> commands = FindTimeSlotCommand();
            DateTime thisDay = DateTime.Today;

            return View();
        }

        public IActionResult HomeOrderPicker()
        {
            return View();
        }
    }
}
