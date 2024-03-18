namespace RepairService.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Orders", "SerialNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "SerialNumber", c => c.String(nullable: false));
        }
    }
}
