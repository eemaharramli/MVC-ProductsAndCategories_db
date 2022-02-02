using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MVC_ProductsAndCategories_db.Models;
using MVC_ProductsAndCategories_db.ViewModels;

namespace MVC_ProductsAndCategories_db.Controllers
{
    public class Home : Controller
    {
        // GET
        public IActionResult Index()
        {

            var laptop = new Categorie{Id = 1, Name = "Laptop"};
            var imac = new Categorie {Id = 2, Name = "IMac"};
            var iphone = new Categorie {Id = 3, Name = "IPhone"};
            
            var products = new List<Product>
            {
                new Product{Id = 1, Name = "Macbook", Category = laptop},
                new Product{Id = 2, Name = "IMac", Category = imac},
                new Product{Id = 3, Name = "IPhone", Category = iphone},
            };

            var categories = new List<Categorie>
            {
                new Categorie{Id = 1, Name = "Laptop"},
                new Categorie{Id = 2, Name = "IMac"},
                new Categorie{Id = 3, Name = "IPhone"}
            };

            return View(new HomeViewModel
            {
                Products = products,
                Categories = categories
            });
        }
    }
}