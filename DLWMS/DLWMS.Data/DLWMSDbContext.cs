using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data
{
    public class DLWMSDbContext : DbContext
    {
        //‪C:\Users\Sara\Desktop\DLWMS.db
        public DLWMSDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = C:\\Users\\Sara\\Desktop\\DLWMS.db");
        }
        public DbSet<Predmet> Predmeti { get; set; }
    }
}
