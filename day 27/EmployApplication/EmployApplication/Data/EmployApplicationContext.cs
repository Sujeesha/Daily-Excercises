using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployApplication.Model;

namespace EmployApplication.Data
{
    public class EmployApplicationContext : DbContext
    {
        public EmployApplicationContext (DbContextOptions<EmployApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<EmployApplication.Model.Emp> Emp { get; set; } = default!;
    }
}
