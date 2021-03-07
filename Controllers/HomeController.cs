using System.Collections.Generic;
using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            List<string> results = new List<string>();

            foreach (Product product in Product.GetProduct())
            {
                string name = product?.Name ?? "<none>";
                decimal? price = product?.Price ?? 0;
                string relatedName = product?.Related?.Name ?? "<none>";
                results.Add(string.Format($"Product: {name}, Price: {price}, Related: {relatedName}"));
            }
            
            return View(results);
        }
    }
}