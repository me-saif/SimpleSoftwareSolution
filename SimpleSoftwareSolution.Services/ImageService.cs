using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SimpleSoftwareSolution.Data;
using SimpleSoftwareSolution.Data.Models;

namespace SimpleSoftwareSolution.Services
{
    public class ImageService : IImage
    {
        private readonly SimpleSoftwareSolutionDbContext _ctx;

        public ImageService(SimpleSoftwareSolutionDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<GalleryImage> GetAll()
        {
            return _ctx.GalleryImages.Include(img => img.Tags);
        }

        public GalleryImage GetById(int id)
        {
            return _ctx.GalleryImages.Find(id);
        }

        public IEnumerable<GalleryImage> GetWithTag(string tag)
        {
            return GetAll().
                Where(img => img.Tags.
                Any(t => t.Description == tag));
        }
    }
}
