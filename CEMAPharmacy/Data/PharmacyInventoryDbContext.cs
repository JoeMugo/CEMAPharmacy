using System;
using CEMAPharmacy.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CEMAPharmacy.Data
{
    public class PharmacyInventoryDbContext : DbContext
    {
        public PharmacyInventoryDbContext(DbContextOptions<PharmacyInventoryDbContext> options)
            : base(options)
        {
        }

        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=PharmacyInventory.db");
        }
    }
}
