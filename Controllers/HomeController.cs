using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChefsDishes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace ChefsDishes.Controllers
{
    public class HomeController : Controller
    {

        private MyContext db;
        public HomeController(MyContext database)
        {
            db = database;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            List<Chef> AllChefs = db.Chefs
            .Include(x => x.DishesList)
            .ToList();
            return View(AllChefs);
        }

        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            List<Dish> allDishes = db.Dishes
            .Include(x => x.Creator)
            .ToList();

            return View(allDishes);
        }
        [HttpGet("dishes/new")]
        public IActionResult NewDish()
        {
            List<Chef> AllChefs = db.Chefs.ToList();
            ViewBag.AllChefs = AllChefs;
            return View();
        }
        [HttpPost("AddNewDish")]
        public IActionResult AddNewDish(Dish data)
        {
            Chef checkChef = db.Chefs.FirstOrDefault(x => x.ChefId == data.ChefId);
            data.Creator = checkChef;
            db.Dishes.Add(data);
            db.SaveChanges();
            return RedirectToAction("Dishes");
        }


        [HttpGet("new")]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost("addChef")]
        public IActionResult AddChef(Chef data)
        {
            DateTime checkAge = data.DOB;
            DateTime todayDate = DateTime.Now;
            int years = todayDate.Year - checkAge.Year;
            if(todayDate.Month < checkAge.Month)
            {
                years = years - 1;
            }
            data.Age = years;
            db.Add(data);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
