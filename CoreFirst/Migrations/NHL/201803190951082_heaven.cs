namespace CoreFirst.Migrations.NHL
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class heaven : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Teams", "countries_Id", "dbo.Countries");
            DropIndex("dbo.Teams", new[] { "countries_Id" });
            DropColumn("dbo.Teams", "countries_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teams", "countries_Id", c => c.Int());
            CreateIndex("dbo.Teams", "countries_Id");
            AddForeignKey("dbo.Teams", "countries_Id", "dbo.Countries", "Id");
        }
    }
}
