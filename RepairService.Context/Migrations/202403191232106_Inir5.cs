namespace RepairService.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inir5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reports", "Reason", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reports", "Reason");
        }
    }
}
