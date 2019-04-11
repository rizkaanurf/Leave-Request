namespace LeaveRequest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingModelLeaveRequest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_M_Account",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                        TB_M_Roles_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Role", t => t.TB_M_Roles_Id)
                .Index(t => t.TB_M_Roles_Id);
            
            CreateTable(
                "dbo.TB_M_Role",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_M_Department",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_M_District",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                        TB_M_Regions_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Region", t => t.TB_M_Regions_Id)
                .Index(t => t.TB_M_Regions_Id);
            
            CreateTable(
                "dbo.TB_M_Region",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                        TB_M_Provinces_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Province", t => t.TB_M_Provinces_Id)
                .Index(t => t.TB_M_Provinces_Id);
            
            CreateTable(
                "dbo.TB_M_Province",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_M_Employee",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Gender = c.Boolean(nullable: false),
                        PhoneNumber = c.String(),
                        IsMarried = c.Boolean(nullable: false),
                        JoinDate = c.DateTime(nullable: false),
                        Street = c.String(),
                        WorkStatus = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                        TB_M_Departments_Id = c.Int(),
                        TB_M_Employees_Id = c.Int(),
                        TB_M_Jobs_Id = c.Int(),
                        TB_M_Religions_Id = c.Int(),
                        TB_M_Villages_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Department", t => t.TB_M_Departments_Id)
                .ForeignKey("dbo.TB_M_Employee", t => t.TB_M_Employees_Id)
                .ForeignKey("dbo.TB_M_Job", t => t.TB_M_Jobs_Id)
                .ForeignKey("dbo.TB_M_Religion", t => t.TB_M_Religions_Id)
                .ForeignKey("dbo.TB_M_Village", t => t.TB_M_Villages_Id)
                .Index(t => t.TB_M_Departments_Id)
                .Index(t => t.TB_M_Employees_Id)
                .Index(t => t.TB_M_Jobs_Id)
                .Index(t => t.TB_M_Religions_Id)
                .Index(t => t.TB_M_Villages_Id);
            
            CreateTable(
                "dbo.TB_M_Job",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_M_Religion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_M_Village",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                        TB_M_Districts_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_District", t => t.TB_M_Districts_Id)
                .Index(t => t.TB_M_Districts_Id);
            
            CreateTable(
                "dbo.TB_M_LeaveCategory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LeaveFor = c.String(),
                        LeaveDays = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_T_File",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                        TB_T_LeaveRequests_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_T_LeaveRequest", t => t.TB_T_LeaveRequests_Id)
                .Index(t => t.TB_T_LeaveRequests_Id);
            
            CreateTable(
                "dbo.TB_T_LeaveRequest",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Note = c.String(),
                        TotalLeave = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        FinishDate = c.DateTime(nullable: false),
                        CurrentYearBefore = c.Int(nullable: false),
                        LastYearBefore = c.Int(nullable: false),
                        RequestStatus = c.Boolean(nullable: false),
                        ApprovalDate = c.DateTime(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                        TB_M_Employees_Id = c.Int(),
                        TB_M_LeaveCategories_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Employee", t => t.TB_M_Employees_Id)
                .ForeignKey("dbo.TB_M_LeaveCategory", t => t.TB_M_LeaveCategories_Id)
                .Index(t => t.TB_M_Employees_Id)
                .Index(t => t.TB_M_LeaveCategories_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_T_File", "TB_T_LeaveRequests_Id", "dbo.TB_T_LeaveRequest");
            DropForeignKey("dbo.TB_T_LeaveRequest", "TB_M_LeaveCategories_Id", "dbo.TB_M_LeaveCategory");
            DropForeignKey("dbo.TB_T_LeaveRequest", "TB_M_Employees_Id", "dbo.TB_M_Employee");
            DropForeignKey("dbo.TB_M_Employee", "TB_M_Villages_Id", "dbo.TB_M_Village");
            DropForeignKey("dbo.TB_M_Village", "TB_M_Districts_Id", "dbo.TB_M_District");
            DropForeignKey("dbo.TB_M_Employee", "TB_M_Religions_Id", "dbo.TB_M_Religion");
            DropForeignKey("dbo.TB_M_Employee", "TB_M_Jobs_Id", "dbo.TB_M_Job");
            DropForeignKey("dbo.TB_M_Employee", "TB_M_Employees_Id", "dbo.TB_M_Employee");
            DropForeignKey("dbo.TB_M_Employee", "TB_M_Departments_Id", "dbo.TB_M_Department");
            DropForeignKey("dbo.TB_M_District", "TB_M_Regions_Id", "dbo.TB_M_Region");
            DropForeignKey("dbo.TB_M_Region", "TB_M_Provinces_Id", "dbo.TB_M_Province");
            DropForeignKey("dbo.TB_M_Account", "TB_M_Roles_Id", "dbo.TB_M_Role");
            DropIndex("dbo.TB_T_LeaveRequest", new[] { "TB_M_LeaveCategories_Id" });
            DropIndex("dbo.TB_T_LeaveRequest", new[] { "TB_M_Employees_Id" });
            DropIndex("dbo.TB_T_File", new[] { "TB_T_LeaveRequests_Id" });
            DropIndex("dbo.TB_M_Village", new[] { "TB_M_Districts_Id" });
            DropIndex("dbo.TB_M_Employee", new[] { "TB_M_Villages_Id" });
            DropIndex("dbo.TB_M_Employee", new[] { "TB_M_Religions_Id" });
            DropIndex("dbo.TB_M_Employee", new[] { "TB_M_Jobs_Id" });
            DropIndex("dbo.TB_M_Employee", new[] { "TB_M_Employees_Id" });
            DropIndex("dbo.TB_M_Employee", new[] { "TB_M_Departments_Id" });
            DropIndex("dbo.TB_M_Region", new[] { "TB_M_Provinces_Id" });
            DropIndex("dbo.TB_M_District", new[] { "TB_M_Regions_Id" });
            DropIndex("dbo.TB_M_Account", new[] { "TB_M_Roles_Id" });
            DropTable("dbo.TB_T_LeaveRequest");
            DropTable("dbo.TB_T_File");
            DropTable("dbo.TB_M_LeaveCategory");
            DropTable("dbo.TB_M_Village");
            DropTable("dbo.TB_M_Religion");
            DropTable("dbo.TB_M_Job");
            DropTable("dbo.TB_M_Employee");
            DropTable("dbo.TB_M_Province");
            DropTable("dbo.TB_M_Region");
            DropTable("dbo.TB_M_District");
            DropTable("dbo.TB_M_Department");
            DropTable("dbo.TB_M_Role");
            DropTable("dbo.TB_M_Account");
        }
    }
}
