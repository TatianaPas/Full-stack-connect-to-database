using Microsoft.EntityFrameworkCore;
using Week5FS.Models;

namespace Week5FS.Data
{
    public class EmployeeDbContext : DbContext
    {
       
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }

        //Entities
        public  DbSet <Employee> Employees { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
