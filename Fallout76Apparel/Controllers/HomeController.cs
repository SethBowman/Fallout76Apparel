using Fallout76Apparel.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Fallout76Apparel.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOutfitRepo _repo;

        public HomeController(IOutfitRepo repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var outfits = _repo.GetAllOutfits();
            return View(outfits);
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

        public IActionResult ViewOutfit(int id)
        {
            var outfit = _repo.GetSingleOutfit(id);
            return View(outfit);
        }

        public IActionResult Search(string search)
        {
            var searchResult = _repo.SearchOutfit(search);
            return View(searchResult);
        }

        public IActionResult MysteriousStranger(int id)
        {
            var outfit = _repo.GetSingleOutfit(id);
            return View(outfit);            
        }

        public IActionResult Chance(int id)
        {
            var r = new Random();
            var chance = r.Next(0, 350);

            if(id == chance)
            {
                return RedirectToAction("MysteriousStranger", new {id});                
            }
            else
            {
                return RedirectToAction("ViewOutfit", new {id});               
            }
        }
    }
}
