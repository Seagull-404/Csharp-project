using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore1
{
    internal class MyDbContext: DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Book> Books { get; set; }

        public DbSet<Dog> Dogs { get; set; }
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
            var connectionString = "server=localhost;user=root;password=123456;database=Efdemo";

            // Replace with your server version and type.
            // Use 'MariaDbServerVersion' for MariaDB.
            // Alternatively, use 'ServerVersion.AutoDetect(connectionString)'.
            // For common usages, see pull request #1233.
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 43));
           
           // optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EFDemo;Integrated Security=True;TrustServerCertificate=True");
           optionsBuilder.UseMySql(connectionString, serverVersion);
        }
        
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyDbContext).Assembly);
        }
    }
}
