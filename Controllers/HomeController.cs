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
            NPCGenerator generator = new NPCGenerator();
            List<NPC> npcs = new List<NPC>();
            for (var i = 0; i < 20; i++) {
                NPC tempNPC = generator.Generate();
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
