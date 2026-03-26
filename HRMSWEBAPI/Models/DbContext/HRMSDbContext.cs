using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace HRMSWEBAPI.Models
{
    public class HRMSDbContext : DbContext
    {
        //====constructure===============
        public HRMSDbContext(DbContextOptions<HRMSDbContext> options) : base(options) { }
        public DbSet<CompanyMaster> CompanyMasters { get; set; }
        public DbSet<BranchMaster> BranchMasters { get; set; }
        public DbSet<CityMaster> CityMasters { get; set; }
        public DbSet<CountryMaster> countryMasters{get;set;}
        public DbSet<DeginationMaster> DeginationMasters { get; set; }
        public DbSet<DepartmentMaster> DepartmentMasters { get; set; }
        public DbSet<DocumentMaster> DocumentMasters { get; set; }
        public DbSet<EmployeeMaster> EmployeeMasters { get; set; }
        public DbSet<PermissionMaster> permissionMasters { get; set; }
        public DbSet<RoleMaster> RoleMasters { get; set; }
        public DbSet<StateMaster> StateMasters { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ===========================
            // Company → Branch (1-M)
            modelBuilder.Entity<BranchMaster>()
                .HasOne(b => b.CompanyMaster)
                .WithMany(c => c.Branches)
                .HasForeignKey(b => b.CompanyId);

            // Branch → Country/State/City (Optional)
            modelBuilder.Entity<BranchMaster>()
                .HasOne(b => b.CountryMaster)
                .WithMany()
                .HasForeignKey(b => b.CountryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BranchMaster>()
                .HasOne(b => b.StateMaster)
                .WithMany()
                .HasForeignKey(b => b.StateId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BranchMaster>()
                .HasOne(b => b.CityMaster)
                .WithMany()
                .HasForeignKey(b => b.CityId)
                .OnDelete(DeleteBehavior.Restrict);

            // State → Country (1-M)
            modelBuilder.Entity<StateMaster>()
                .HasOne(s => s.CountryMaster)
                .WithMany(c => c.States)
                .HasForeignKey(s => s.CountryId);

            // City → State (1-M)
            modelBuilder.Entity<CityMaster>()
                .HasOne(c => c.StateMaster)
                .WithMany(s => s.Cities)
                .HasForeignKey(c => c.StateId);

            // Department → Branch (1-M)
            modelBuilder.Entity<DepartmentMaster>()
                .HasOne(d => d.BranchMaster)
                .WithMany(b => b.Departments)
                .HasForeignKey(d => d.BranchId);

            // Designation → Department (1-M)
            modelBuilder.Entity<DeginationMaster>()
                .HasOne(des => des.DepartmentMaster)
                .WithMany(dep => dep.Designations)
                .HasForeignKey(des => des.DeptId);

            // Employee → Designation (1-M)
            modelBuilder.Entity<EmployeeMaster>()
                .HasOne(e => e.DesignationMaster)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DeginationId);

            // Documents
            modelBuilder.Entity<DocumentMaster>()
                .HasOne(d => d.CompanyMaster)
                .WithMany(c => c.Documents)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DocumentMaster>()
                .HasOne(d => d.BranchMaster)
                .WithMany(b => b.Documents)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DocumentMaster>()
                .HasOne(d => d.EmployeeMaster)
                .WithMany(e => e.Documents)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
