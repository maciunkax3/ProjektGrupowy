using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using projektGrupowy.Models;

namespace projektGrupowy.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Piosenki Zespołu Michał Kołpuć";
            var model = new List<projektGrupowy.Models.MusicFile>();
            List<string> files = new List<string>();
            files.Add("MchalKolpucPiosenkaOMilosciNieDoKoncaHeteroSeksualnej.mp3");
            files.Add("MichalKolpucTygrysToJa.mp3");
            files.Add("MichalKolpucJebacPb.mp3");
            files.Add("BohdanSmoleńUBodziaDisco.mp3");
            foreach (var file in files)
            {
                model.Add(new projektGrupowy.Models.MusicFile() { path = "aaa", fileName = file });
            }
            return View(model);
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
