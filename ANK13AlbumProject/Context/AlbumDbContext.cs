using ANK13AlbumProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace ANK13AlbumProject.Context
{
    public class AlbumDbContext : DbContext
    {
        public AlbumDbContext(DbContextOptions<AlbumDbContext> options) : base(options)
        {
            
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<ANK13AlbumProject.Entities.Album>? Album { get; set; }
    }
}
