using LeaveRequest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequest
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyContext") { }
        public DbSet<TB_M_Province> TB_M_Provinces { get; set; }
        public DbSet<TB_M_Region> TB_M_Regions { get; set; }
        public DbSet<TB_M_District> TB_M_Districts { get; set; }
        public DbSet<TB_M_Village> TB_M_Villages { get; set; }
        public DbSet<TB_M_Religion> TB_M_Religions { get; set; }
        public DbSet<TB_M_Job> TB_M_Jobs { get; set; }
        public DbSet<TB_M_Department> TB_M_Departments { get; set; }
        public DbSet<TB_M_Role> TB_M_Roles { get; set; }
        public DbSet<TB_M_Account> TB_M_Accounts { get; set; }
        public DbSet<TB_M_LeaveCategory> TB_M_LeaveCategories { get; set; }
        public DbSet<TB_M_Employee> TB_M_Employees { get; set; }
        public DbSet<TB_T_LeaveRequest> TB_T_LeaveRequests { get; set; }
        public DbSet<TB_T_File> TB_T_Files { get; set; }
    }
}
