using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GlobalComputerSolutionsDb
{
    public class GcsDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder op)
        {
            if (!op.IsConfigured)
            {
                op.UseSqlServer(
                    @"Server=DESKTOP-AS9FM2S\MAIN; Initial Catalog = GlobalComputerSolutionsDb; Trusted_Connection = True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
