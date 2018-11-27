using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class WempContext : DbContext
    {
        public WempContext(DbContextOptions<WempContext> options) : base(options)
        {

        }


        public DbSet<User> User { get; set; }


    }
}
