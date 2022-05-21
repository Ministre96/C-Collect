using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using CC_Cyx_Vansnick.Models.POCO;
using Newtonsoft.Json;
using CC_Cyx_Vansnick.DAL.IDAL;

namespace CC_Cyx_Vansnick.Controllers
{
    public class CommandController : Controller
    {
        private readonly IArticlesDAL _articlesDAL;
        public CommandController(IArticlesDAL articlesDAL)
        {
            _articlesDAL = articlesDAL;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add(int id)
        {
            if(HttpContext.Session.GetString("IdUser") == null)
            {
                return RedirectToAction("LogIn", "Connection");
            }
            else
            {
                if (HttpContext.Session.GetString("Command") == null)
                {
                    HttpContext.Session.SetString("Command", JsonConvert.SerializeObject(new List<Article>()));
                }
                var a = JsonConvert.DeserializeObject<List<Article>>(HttpContext.Session.GetString("Command"));
                var article = Article.FindById(id, _articlesDAL);
                a.Add(article);
                HttpContext.Session.SetString("Command", JsonConvert.SerializeObject(a));
                return RedirectToAction("Index", "Home");
            }
            
        }
    }
}
