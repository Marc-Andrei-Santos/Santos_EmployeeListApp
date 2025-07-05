using Microsoft.EntityFrameworkCore;
using Santos_EmployeeListApp.Models;
using System.Collections.Generic;

namespace Santos_EmployeeListApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
