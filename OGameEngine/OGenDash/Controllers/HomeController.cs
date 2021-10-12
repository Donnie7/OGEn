using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OGameEngine.Core.Interfaces;
using OGameEngine.Webdriver;
using OGenDash.Models;

namespace OGenDash.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly IDriver driver;
        private readonly IOgame ogame;

        public HomeController(ILogger<HomeController> logger, IDriver driver, IOgame ogame)
        {
            this.ogame = ogame;
            this.driver = driver;
            this.logger = logger;
        }

        public IActionResult Index()
        {
            var model = ogame.ToModel();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ConnectToOgame()
        {
            ogame.Connected = driver.ConnectToOgame();
            var model = ogame.ToModel();
            return RedirectToAction("Index", model);
        }
        
        [HttpPost]
        public IActionResult GoHome()
        {
            driver.GoTo("https://s134-pt.ogame.gameforge.com/game/index.php?page=ingame&component=overview");
            var model = ogame.ToModel();
            return RedirectToAction("Index", model);
        }
        
        [HttpPost]
        public IActionResult UpdateResearches()
        {
            driver.GoTo("https://s134-pt.ogame.gameforge.com/game/index.php?page=ingame&component=research");
            ogame.Researches.EnergyLevel = driver.Researches.GetEnergyLevel();
            ogame.Researches.LaserLevel = driver.Researches.GetLaserLevel();
            ogame.Researches.IonLevel = driver.Researches.GetIonLevel();
            ogame.Researches.HyperspaceLevel = driver.Researches.GetHyperspaceLevel();
            ogame.Researches.PlasmaLevel = driver.Researches.GetPlasmaLevel();
            ogame.Researches.CombustionLevel = driver.Researches.GetCombustionLevel();
            ogame.Researches.ImpulsionLevel = driver.Researches.GetImpulsionLevel();
            ogame.Researches.HyperspacePropulsionLevel = driver.Researches.GetHyperspacePropulsionLevel();
            ogame.Researches.SpyLevel = driver.Researches.GetSpyLevel();
            ogame.Researches.ComputersLevel = driver.Researches.GetComputersLevel();
            ogame.Researches.AstrophysicsLevel = driver.Researches.GetAstrophysicsLevel();
            ogame.Researches.IntergalacticLevel = driver.Researches.GetIntergalacticLevel();
            ogame.Researches.GravitationLevel = driver.Researches.GetGravitationLevel();
            ogame.Researches.WeaponsLevel = driver.Researches.GetWeaponsLevel();
            ogame.Researches.ShieldingLevel = driver.Researches.GetShieldingLevel();
            ogame.Researches.ArmorLevel = driver.Researches.GetArmorLevel();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
        
    }
}