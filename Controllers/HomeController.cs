using CountriesRevisited.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CountriesRevisited.Controllers
{
    public class HomeController : Controller
    {
        public List<Country> Countries { get; set; }


        public HomeController()
        {
            Countries = new List<Country>();

            List<string> lang1 = new List<string>();
            lang1.Add("French");
            List<string> colors1 = new List<string>();
            colors1.Add("Blue");
            colors1.Add("White");
            colors1.Add("Red");
            Country c1 = new Country("France", lang1, "quoi de neuf dans le monde", colors1, "Rocky history with foreign policy. Loves to revolt.");

            List<string> lang2 = new List<string>();
            lang2.Add("Haitian Creole");
            lang2.Add("French");
            List<string> colors2 = new List<string>();
            colors2.Add("Blue");
            colors2.Add("Red");
            colors2.Add("White");
            Country c2 = new Country("Haiti", lang2, "Ou se pwochen, Prezidan Jefferson", colors2, "Best food. Really good at Land Back.");

            List<string> lang3 = new List<string>();
            lang3.Add("Ukrainian");
            List<string> colors3 = new List<string>();
            colors3.Add("Yellow");
            colors3.Add("Blue");
            Country c3 = new Country("Ukraine", lang3, "будь ласка, залиште нас у спокої", colors3, "Other countries love their fertile farmland. Tired of being pushed over.");

            Countries.Add(c1);
            Countries.Add(c2);
            Countries.Add(c3);


            //List<string> lang4 = new List<string>();
            //lang1.Add("French");
            //List<string> colors4 = new List<string>();
            //colors4.Add("Red");
            //colors4.Add("Black");
            //Country c4 = new Country("Stankonia", lang1, "Valvete amici!", colors4, "Dopest country on Earth");

            //List<string> lang5 = new List<string>();
            //lang5.Add("French");
            //List<string> colors5 = new List<string>();
            //colors5.Add("Red");
            //colors5.Add("Black");
            //Country c5 = new Country("Stankonia", lang1, "Valvete amici!", colors5, "Dopest country on Earth");

        }

        public IActionResult Index()
        {
            return View(Countries);
        }
        [HttpPost]
        public IActionResult Index(string choice)
        {
            foreach(Country c in Countries)
            {
                if(c.Name== choice)
                {
                    TempData["Name"] = c.Name;
                    TempData["Language"] = c.Language;
                    TempData["Greeting"] = c.Greeting;
                    TempData["Colors"] = c.Colors;
                    TempData["Description"] = c.Description;
                }
            }
            return View(Countries);
        }

        public IActionResult Details()
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
