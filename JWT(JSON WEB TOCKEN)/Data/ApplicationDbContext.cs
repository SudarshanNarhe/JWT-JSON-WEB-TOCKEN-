using Microsoft.EntityFrameworkCore;
using JWT_JSON_WEB_TOCKEN_.Models;
using System.Collections.Generic;

namespace JWT_JSON_WEB_TOCKEN_.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
