using FlyweightWebApp.Services;
using FlyweightWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FlyweightWebApp.Controllers
{
    public class MapController : Controller
    {

        private readonly ITreeService _treeService;

        public MapController(ITreeService treeService)
        {
            _treeService = treeService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            
            var viewModel = new TreeViewModel
            {
                AvailableSpecies = _treeService.GetAvailableSpecies()
            };

            ViewBag.Trees = _treeService.GetAllTrees();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Index(TreeViewModel model)
        {
            if (ModelState.IsValid)
            {
                _treeService.AddTree(model.Species, model.Latitude.Value, model.Longitude.Value);
                return RedirectToAction("Index");
            }

            model.AvailableSpecies = _treeService.GetAvailableSpecies();
            ViewBag.Trees = _treeService.GetAllTrees();
            return View(model);
        }
    }
}
