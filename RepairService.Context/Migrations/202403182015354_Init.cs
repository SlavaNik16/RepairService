namespace RepairService.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BrokenTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7),
                        ClientId = c.Int(nullable: false),
                        SerialNumber = c.String(nullable: false),
                        EquipmentId = c.Int(nullable: false),
                        BrokenTypeId = c.Int(nullable: false),
                        Description = c.String(),
                        Priority = c.String(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BrokenTypes", t => t.BrokenTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.ClientId)
                .ForeignKey("dbo.Equipments", t => t.EquipmentId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.EquipmentId)
                .Index(t => t.BrokenTypeId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Surname = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        Patronymic = c.String(),
                        Login = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        RoleType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Equipments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        SerialNumber = c.String(nullable: false),
                        EquipmentType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EquipmentTypes", t => t.EquipmentType_Id)
                .Index(t => t.EquipmentType_Id);
            
            CreateTable(
                "dbo.EquipmentTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.SparesCounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Count = c.Int(nullable: false),
                        SparesTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SparesTypes", t => t.SparesTypeId, cascadeDelete: true)
                .Index(t => t.SparesTypeId);
            
            CreateTable(
                "dbo.SparesTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserOrders",
                c => new
                    {
                        User_Id = c.Int(nullable: false),
                        Order_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.Order_Id })
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.Order_Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.Order_Id);
            
            CreateTable(
                "dbo.SparesCountReports",
                c => new
                    {
                        SparesCount_Id = c.Int(nullable: false),
                        Report_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SparesCount_Id, t.Report_Id })
                .ForeignKey("dbo.SparesCounts", t => t.SparesCount_Id, cascadeDelete: true)
                .ForeignKey("dbo.Reports", t => t.Report_Id, cascadeDelete: true)
                .Index(t => t.SparesCount_Id)
                .Index(t => t.Report_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SparesCounts", "SparesTypeId", "dbo.SparesTypes");
            DropForeignKey("dbo.SparesCountReports", "Report_Id", "dbo.Reports");
            DropForeignKey("dbo.SparesCountReports", "SparesCount_Id", "dbo.SparesCounts");
            DropForeignKey("dbo.Reports", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "EquipmentId", "dbo.Equipments");
            DropForeignKey("dbo.Equipments", "EquipmentType_Id", "dbo.EquipmentTypes");
            DropForeignKey("dbo.UserOrders", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.UserOrders", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Orders", "ClientId", "dbo.Users");
            DropForeignKey("dbo.Orders", "BrokenTypeId", "dbo.BrokenTypes");
            DropIndex("dbo.SparesCountReports", new[] { "Report_Id" });
            DropIndex("dbo.SparesCountReports", new[] { "SparesCount_Id" });
            DropIndex("dbo.UserOrders", new[] { "Order_Id" });
            DropIndex("dbo.UserOrders", new[] { "User_Id" });
            DropIndex("dbo.SparesCounts", new[] { "SparesTypeId" });
            DropIndex("dbo.Reports", new[] { "OrderId" });
            DropIndex("dbo.Equipments", new[] { "EquipmentType_Id" });
            DropIndex("dbo.Orders", new[] { "BrokenTypeId" });
            DropIndex("dbo.Orders", new[] { "EquipmentId" });
            DropIndex("dbo.Orders", new[] { "ClientId" });
            DropTable("dbo.SparesCountReports");
            DropTable("dbo.UserOrders");
            DropTable("dbo.SparesTypes");
            DropTable("dbo.SparesCounts");
            DropTable("dbo.Reports");
            DropTable("dbo.EquipmentTypes");
            DropTable("dbo.Equipments");
            DropTable("dbo.Users");
            DropTable("dbo.Orders");
            DropTable("dbo.BrokenTypes");
        }
    }
}
