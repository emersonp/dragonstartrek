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
            List<NPC> npcs = new List<NPC>();
            for (var i = 0; i < 10; i++) {
                NPC tempNPC = generator.Generate("Random", "Human");
                npcs.Add(tempNPC);
            }

            return View(npcs);
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
