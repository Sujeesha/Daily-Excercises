using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieDemoApp.Models;

namespace MovieDemoApp.Data
{
    public class MovieDemoAppContext : DbContext
    {
        public MovieDemoAppContext (DbContextOptions<MovieDemoAppContext> options)
            : base(options)
        {
        }

        public DbSet<MovieDemoApp.Models.Movie> Movie { get; set; } = default!;
    }
}
