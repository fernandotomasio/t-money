using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using t_money.Models;

namespace t_money.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Account>().HasKey(t => t.Id);
            modelBuilder.Entity<Account>().HasOne(t => t.User);

            modelBuilder.Entity<BudgetItem>().HasKey(t => t.Id);
            modelBuilder.Entity<BudgetItem>().HasOne(t => t.Category);
            modelBuilder.Entity<BudgetItem>().HasOne(t => t.User);

            modelBuilder.Entity<Category>().HasKey(t => t.Id);
            modelBuilder.Entity<Category>()
               .Property(e => e.TransactionType)
               .HasConversion(v => v.ToString(), v => (TransactionType)Enum.Parse(typeof(TransactionType), v));

            modelBuilder.Entity<Setting>().HasKey(t => t.Id);
            modelBuilder.Entity<Setting>().HasOne(t => t.User);

            modelBuilder.Entity<Transaction>().HasKey(t => t.Id);
            modelBuilder.Entity<Transaction>()
                .Property(e => e.TransactionType)
                .HasConversion(v => v.ToString(), v => (TransactionType)Enum.Parse(typeof(TransactionType), v));
            modelBuilder.Entity<Transaction>().HasOne(t => t.Account);
            modelBuilder.Entity<Transaction>().HasOne(t => t.Category);


            modelBuilder.Entity<User>().HasKey(t => t.Id);
        }
        public DbSet<Account> Account { get; set; }
        public DbSet<BudgetItem> BudgetItem { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Setting> Setting { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<User> Users { get; set; }

    }
    
}
