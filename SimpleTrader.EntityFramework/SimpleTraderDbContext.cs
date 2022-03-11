using Microsoft.EntityFrameworkCore;
using SimpleTrader.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.EntityFramework
{
    public class SimpleTraderDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AssetTransaction> AssetTransactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssetTransaction>().OwnsOne(a => a.Stock);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=DESKTOP-S68ME9Q\\MSSQLSERVER_2019;Initial Catalog=SimpleTraderDB;User Id=bv; Password=123456;MultipleActiveResultSets=true");
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-S68ME9Q;Initial Catalog=SimpleTraderDB;persist security info=True;user id=sa;password=123456");

            base.OnConfiguring(optionsBuilder);
        }
    }
}

