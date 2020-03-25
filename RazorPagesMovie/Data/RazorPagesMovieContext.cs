using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Data
{
    public class RazorPagesMovieContext : DbContext
    {
        private readonly DbContextOptions<RazorPagesMovieContext> _options;

        public RazorPagesMovieContext (DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
            _options = options;
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
