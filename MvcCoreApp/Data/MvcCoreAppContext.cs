using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcCoreApp.Models;

namespace MvcCoreApp.Data
{
    public class MvcCoreAppContext : DbContext
    {
        public MvcCoreAppContext (DbContextOptions<MvcCoreAppContext> options)
            : base(options)
        {
        }

        public DbSet<MvcCoreApp.Models.Movie> Movie { get; set; }
    }
}
