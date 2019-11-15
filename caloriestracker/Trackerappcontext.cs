using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace caloriestracker
{
    class Trackerappcontext : DbContext

    {
        public DbSet<Tracker> Trackers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Tracker2019;Integrated Security=True;Connect Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tracker>(entity =>
            {
                entity.HasKey(t => t.Username).HasName("PK_Trackers");
                entity.Property(t => t.dayOfWeek).IsRequired();
                entity.Property(t => t.TypeofMeal).IsRequired().HasMaxLength(10);
                entity.ToTable("Trackers");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasKey(tr => tr.Username).HasName("PK_Transactions");
                entity.Property(tr => tr.TransactionDate).ValueGeneratedOnAdd();
                entity.Property(tr => tr.Amount).IsRequired();
                entity.HasOne(tr => tr.Tracker).WithMany().HasForeignKey(tr => tr.Username);


            });
        }
    }
 }
