using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace coredb
{
    public partial class db20200831Context : DbContext
    {
        public db20200831Context()
        {
        }

        public db20200831Context(DbContextOptions<db20200831Context> options)
            : base(options)
        {
        }

        public virtual DbSet<TCustomer> TCustomer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:dbtestchiron780318.database.windows.net,1433;Initial Catalog=db20200831;Persist Security Info=False;User ID=chiron780318;Password=P@ssword780318;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TCustomer>(entity =>
            {
                entity.ToTable("tCustomer");

                entity.Property(e => e.FAddress)
                    .HasColumnName("fAddress")
                    .HasMaxLength(50);

                entity.Property(e => e.FName)
                    .HasColumnName("fName")
                    .HasMaxLength(50);

                entity.Property(e => e.FPhone)
                    .HasColumnName("fPhone")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
