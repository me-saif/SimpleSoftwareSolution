using Microsoft.AspNetCore.Mvc;
using SimpleSoftwareSolution.Models;

namespace SimpleSoftwareSolution.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            var model = new GalleryIndexModel {

            };
            return View(model);
        }
    }
}