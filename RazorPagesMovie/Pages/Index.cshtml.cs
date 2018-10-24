using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages
{
    public class IndexModel : PageModel
    {
        MovieContext _movieContext;

        public IndexModel(MovieContext movieContext)
        {
            _movieContext = movieContext;

        }
        public async void OnGet()
        {
            var x = _movieContext.Movie.ToList();

            for (int i = 0; i < 500; i++)
            {
                _movieContext.Movie.Add(new Movie
                {
                    Genre = $"test {i}",
                    Price = 10m,
                    ReleaseDate = DateTime.Now,
                    Title = "test"
                });

                await _movieContext.SaveChangesAsync();

            }

        }
    }
}
