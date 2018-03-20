namespace CoreFirst.Migrations.NHL
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialagain : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Countries", "TeamId", c => c.Int(nullable: false));
            AddColumn("dbo.Countries", "PlayerId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Countries", "PlayerId");
            DropColumn("dbo.Countries", "TeamId");
        }
    }
}
