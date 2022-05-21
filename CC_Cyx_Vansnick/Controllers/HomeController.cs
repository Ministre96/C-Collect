using CC_Cyx_Vansnick.DAL.IDAL;
using CC_Cyx_Vansnick.Models;
using CC_Cyx_Vansnick.Models.POCO;
using CC_Cyx_Vansnick.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CC_Cyx_Vansnick.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly IArticlesDAL _articlesDAL;
        public HomeController(IArticlesDAL articlesDAL)
        {
            _articlesDAL = articlesDAL;
        }
        public IActionResult Index()
        {
            List<Article> articles = _articlesDAL.FindAllArticles();
            List<String> cat = new List<string>();
            var viewModel = new DDLCatViewModel();
            viewModel.ProductType = "Viande";
            ViewBag.Article = articles;
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
