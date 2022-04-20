#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudParcial.Models;

namespace CrudParcial.Data
{
    public class CrudParcialContext : DbContext
    {
        public CrudParcialContext (DbContextOptions<CrudParcialContext> options)
            : base(options)
        {
        }

        public DbSet<CrudParcial.Models.Movie> Movie { get; set; }
    }
}
