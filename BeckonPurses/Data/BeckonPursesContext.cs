using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BeckonPurses.Models;

namespace BeckonPurses.Data
{
    public class BeckonPursesContext : DbContext
    {
        public BeckonPursesContext (DbContextOptions<BeckonPursesContext> options)
            : base(options)
        {
        }

        public DbSet<BeckonPurses.Models.Purse> Purse { get; set; } = default!;
    }
}
