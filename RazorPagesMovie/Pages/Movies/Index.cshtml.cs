using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie.Models.MovieContext _context;
        readonly WempContext _wempContext;
        readonly SportsGearContext _sportsGearContext;

        public IndexModel(RazorPagesMovie.Models.MovieContext context, WempContext wempContext, SportsGearContext sportsGearContext)
        {
            _context = context;
            _wempContext = wempContext;
            _sportsGearContext = sportsGearContext;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            var gadgets = await _sportsGearContext.Gadget.ToListAsync();

            var users = await _wempContext.User.ToListAsync();

            Movie = await _context.Movie.ToListAsync();
        }
    }
}
