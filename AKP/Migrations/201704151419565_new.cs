namespace AKP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Message", "cos", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Message", "cos");
        }
    }
}
