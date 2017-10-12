using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dragonstartrek.Models;
using dragonstartrek.Constants;
using dragonstartrek.Generators;
using Tools;

namespace dragonstartrek.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            var dice = new Tools.Dice();
            ViewData["Dice"] = dice.Roll("d3+1");

            NPCGenerator generator = new NPCGenerator("Ein");
            NPC temp1 = generator.Generate("random", "human");
            NPC temp2 = generator.Generate("random", "human");
            NPC temp3 = generator.Generate("random", "human");
            NPC temp4 = generator.Generate("random", "human");

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
