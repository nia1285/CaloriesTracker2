using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace caloriestracker
{
    class Trackerappcontext : DbContext

    {
        public DbSet<Tracker> Trackers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = modelBuilder.Entity<Tracker>((Action<Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Tracker>>)(entity =>
             {
                 entity.HasKey(a => a.Username).HasName("PK_Trackers");

                 entity.Property(a => a.DayOfWeek).IsRequired();

                 entity.Property(a => a.TypeofMeal).IsRequired();

                 entity.Property((System.Linq.Expressions.Expression<Func<Tracker, decimal>>)(a => (decimal)a.CaloriesAmount)).IsRequired().HasMaxLength(10);
    
                 entity.ToTable("Trackers");

             }));
        }
    }
}
