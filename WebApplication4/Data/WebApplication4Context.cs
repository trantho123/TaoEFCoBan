using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNetRazorsPageEFCore.Models;

namespace WebApplication4.Data
{
    public class WebApplication4Context : DbContext
    {
        public WebApplication4Context (DbContextOptions<WebApplication4Context> options)
            : base(options)
        {
        }

        public DbSet<AspNetRazorsPageEFCore.Models.Student> Student { get; set; }
    }
}
