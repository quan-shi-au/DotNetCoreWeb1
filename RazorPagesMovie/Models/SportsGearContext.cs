using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class SportsGearContext : DbContext
    {
        public SportsGearContext(DbContextOptions<SportsGearContext> options) : base(options)
        {

        }


        public DbSet<Gadget> Gadget { get; set; }


    }
}
