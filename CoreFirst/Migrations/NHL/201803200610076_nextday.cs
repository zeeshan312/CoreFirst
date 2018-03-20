namespace CoreFirst.Migrations.NHL
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nextday : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "countries_Id", c => c.Int());
            CreateIndex("dbo.Teams", "countries_Id");
            AddForeignKey("dbo.Teams", "countries_Id", "dbo.Countries", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teams", "countries_Id", "dbo.Countries");
            DropIndex("dbo.Teams", new[] { "countries_Id" });
            DropColumn("dbo.Teams", "countries_Id");
        }
    }
}
