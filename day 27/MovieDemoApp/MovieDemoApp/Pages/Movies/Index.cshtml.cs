using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieDemoApp.Data;
using MovieDemoApp.Models;

namespace MovieDemoApp.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MovieDemoApp.Data.MovieDemoAppContext _context;

        public IndexModel(MovieDemoApp.Data.MovieDemoAppContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
