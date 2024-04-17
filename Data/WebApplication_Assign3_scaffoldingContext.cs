using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication_Assign3_scaffolding.Models;

namespace WebApplication_Assign3_scaffolding.Data
{
    public class WebApplication_Assign3_scaffoldingContext : DbContext
    {
        public WebApplication_Assign3_scaffoldingContext (DbContextOptions<WebApplication_Assign3_scaffoldingContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication_Assign3_scaffolding.Models.Student> Student { get; set; } = default!;
    }
}
