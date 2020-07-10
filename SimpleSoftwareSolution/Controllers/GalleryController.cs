using System;
using Microsoft.AspNetCore.Mvc;
using SimpleSoftwareSolution.Data.Models;
using SimpleSoftwareSolution.Models;
using System.Collections.Generic;
using SimpleSoftwareSolution.Services;

namespace SimpleSoftwareSolution.Controllers
{
    public class GalleryController : Controller
    {
        private readonly IImage _imageService;

        public GalleryController(IImage imageService)
        {
            _imageService = imageService; 
        }
        public IActionResult Index()
        {
            var imageList = _imageService.GetAll();

            var model = new GalleryIndexModel {
                Images = imageList,
                SearchQuery = ""
            };
            return View(model);
        }
    }
}