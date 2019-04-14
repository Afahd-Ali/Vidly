using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Vidly.Models
{
    public class VidlyContext : DbContext
    {
        public VidlyContext (DbContextOptions<VidlyContext> options)
            : base(options)
        {
        }

        public DbSet<Vidly.Models.Movie> Movie { get; set; }
    }
}
