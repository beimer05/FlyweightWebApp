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
        public IActionResult Index()
        {
            var treeEntities = _treeService.GetAllTrees();
            var viewModel = treeEntities.Select(tree => new TreeViewModel
            {
                Latitude= tree.Latitude,
                Longitude= tree.Longitude,
                TreeName= tree.Type.Color,
                Color= tree.Type.Color,
                IconPath = tree.Type.IconPath,
               
            }).ToList();
            return View(viewModel);
        }
    }
}
