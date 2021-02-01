using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BDAT1007_Group7_A1.Models
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("name=AppDbContext")
        {
        }

        public virtual DbSet<JobPosting> JobPostings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JobPosting>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<JobPosting>()
                .Property(e => e.Company)
                .IsUnicode(false);

            modelBuilder.Entity<JobPosting>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<JobPosting>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<JobPosting>()
                .Property(e => e.URL)
                .IsUnicode(false);
        }
    }
}
