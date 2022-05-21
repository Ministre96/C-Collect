using CC_Cyx_Vansnick.DAL.IDAL;
using CC_Cyx_Vansnick.Models.POCO;
using CC_Cyx_Vansnick.Models.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CC_Cyx_Vansnick.Controllers
{
    public class ValidationCommandController : Controller
    {
        private readonly IArticlesDAL _articlesDAL;
        private readonly IStoresDAL _storesDAL;
        public ValidationCommandController(IArticlesDAL articlesDAL, IStoresDAL storesDAL)
        {
            _articlesDAL = articlesDAL;
            _storesDAL = storesDAL;

        }
        public IActionResult Index()
        {
            Command c = new Command();
            List<Article> articles = JsonConvert.DeserializeObject<List<Article>>(HttpContext.Session.GetString("Command"));
            foreach (Article test in Article.FindAllArticle(_articlesDAL))
            {
                int i = articles.FindAll(d => d.IdArticle == test.IdArticle).Count;
                c.Articles.Add(test, i);
            }
            List<Store> stores = Store.FindAllStore(_storesDAL);
            ViewBag.Store = stores;
        return View(c);
        }
        public IActionResult ChooseDay(int id)
        {
            HttpContext.Session.SetInt32("IdStore", id);
            DDLDayViewModel dddld = new DDLDayViewModel();

            return View(dddld);
        }
        [HttpPost]
        public IActionResult ChooseTimeSlot(DDLDayViewModel dDLDayViewModel)
        {
            HttpContext.Session.SetInt32("Day", Convert.ToInt32(dDLDayViewModel.Day));
            
            return View();
        }
    }
}
