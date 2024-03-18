namespace RepairService.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "Priority", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "Priority", c => c.String(nullable: false));
        }
    }
}
