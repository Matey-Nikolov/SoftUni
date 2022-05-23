using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ASP_NET_MVC_Task2.Models
{
    public partial class VendingMachineContext : DbContext
    {
        public VendingMachineContext()
        {
        }

        public VendingMachineContext(DbContextOptions<VendingMachineContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Vending> Vendings { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Vending Machine;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vending>(entity =>
            {
                entity.ToTable("Vending");

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .HasColumnName("date");

                entity.Property(e => e.Lat)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("LAT");

                entity.Property(e => e.Lot)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("LOT");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
