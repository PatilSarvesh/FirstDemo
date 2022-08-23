using EFDemo1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo1.Data
{
    public class ContactsDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;" +
                "Initial Catalog=ContactDBEF;Integrated Security=True;Pooling=False");

            //optionsBuilder.LogTo(Console.WriteLine,LogLevel.Information);
        }

        public DbSet<Contact> contacts { get; set; }
      
    }
}
