using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using be;
using System.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DAL
{
    public class DB : IdentityDbContext<user>
    {
        public DB(DbContextOptions<DB> option) :base (option) {}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MMD;Initial Catalog=Store.core;Integrated Security=true;multipleactiveresultsets=True;User ID=mmd;Password=1382");
            base.OnConfiguring(optionsBuilder);

        }
        public DbSet<Items> items { get; set; }
        public DbSet<Sold> solds { get; set; }
    }
}
