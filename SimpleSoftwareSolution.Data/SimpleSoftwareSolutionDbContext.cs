using Microsoft.EntityFrameworkCore;
using SimpleSoftwareSolution.Data.Models;

namespace SimpleSoftwareSolution.Data
{
    public class SimpleSoftwareSolutionDbContext: DbContext
    {
        public SimpleSoftwareSolutionDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<GalleryImage> GalleryImages { get; set; }
        public DbSet<ImageTag> ImageTags { get; set; }
    }
}
