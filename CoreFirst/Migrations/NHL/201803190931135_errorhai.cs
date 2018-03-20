namespace CoreFirst.Migrations.NHL
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class errorhai : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "PlayerId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "PlayerId");
        }
    }
}
