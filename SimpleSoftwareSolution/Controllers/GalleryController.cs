using System;
using Microsoft.AspNetCore.Mvc;
using SimpleSoftwareSolution.Data.Models;
using SimpleSoftwareSolution.Models;
using System.Collections.Generic;

namespace SimpleSoftwareSolution.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            var hikingImageTags = new List<ImageTag>();
            var cityImageTags = new List<ImageTag>();

            var tag1 = new ImageTag() {
                Description = "Adventure",
                Id = 0
            };
            var tag2 = new ImageTag()
            {
                Description = "Urban",
                Id = 1
            };
            var tag3 = new ImageTag()
            {
                Description = "New York",
                Id = 2
            };

            hikingImageTags.Add(tag1);
            cityImageTags.AddRange(new List<ImageTag>{ tag2, tag3});

            var imageList = new List<GalleryImage>()
            {
                new GalleryImage(){
                    Title = "Hiking trip",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSFVIxZuWTvyKkQHiSN03rPS_brNTzXhkwOiA&usqp=CAU",
                    Created = DateTime.Now,
                    Tags = hikingImageTags
                },
                 new GalleryImage(){
                    Title = "On the Trial",
                    Url = "https://www.google.com/images/branding/googlelogo/1x/googlelogo_color_272x92dp.png",
                    Created = DateTime.Now,
                    Tags = hikingImageTags
                },
                  new GalleryImage(){
                    Title = "DownTown",
                    Url = "https://www.google.com/images/branding/googlelogo/1x/googlelogo_color_272x92dp.png",
                    Created = DateTime.Now,
                    Tags = cityImageTags
                }
            };

            var model = new GalleryIndexModel {
                Images = imageList
            };
            return View(model);
        }
    }
}