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
    }
}
