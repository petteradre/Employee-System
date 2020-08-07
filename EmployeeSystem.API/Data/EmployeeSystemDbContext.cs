using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeSystem.Data;
using EmployeeSystem.Data.Models;

namespace EmployeeSystem.API.Data
{
    public class EmployeeSystemDbContext:DbContext
    {
        public EmployeeSystemDbContext(DbContextOptions<EmployeeSystemDbContext> options) : base(options)
        {
        }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<City> Cities { get; set; }
    }
}
