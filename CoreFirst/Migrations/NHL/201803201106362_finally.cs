namespace CoreFirst.Migrations.NHL
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _finally : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Players", "TeamId", "dbo.Teams");
            DropIndex("dbo.Players", new[] { "TeamId" });
            AddColumn("dbo.Players", "Team_TeamId", c => c.Int());
            AddColumn("dbo.Players", "Team_TeamId1", c => c.Int());
            AddColumn("dbo.Teams", "player_PlayerId", c => c.Int());
            CreateIndex("dbo.Players", "Team_TeamId");
            CreateIndex("dbo.Players", "Team_TeamId1");
            CreateIndex("dbo.Teams", "player_PlayerId");
            AddForeignKey("dbo.Teams", "player_PlayerId", "dbo.Players", "PlayerId");
            AddForeignKey("dbo.Players", "Team_TeamId1", "dbo.Teams", "TeamId");
            AddForeignKey("dbo.Players", "Team_TeamId", "dbo.Teams", "TeamId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "Team_TeamId", "dbo.Teams");
            DropForeignKey("dbo.Players", "Team_TeamId1", "dbo.Teams");
            DropForeignKey("dbo.Teams", "player_PlayerId", "dbo.Players");
            DropIndex("dbo.Teams", new[] { "player_PlayerId" });
            DropIndex("dbo.Players", new[] { "Team_TeamId1" });
            DropIndex("dbo.Players", new[] { "Team_TeamId" });
            DropColumn("dbo.Teams", "player_PlayerId");
            DropColumn("dbo.Players", "Team_TeamId1");
            DropColumn("dbo.Players", "Team_TeamId");
            CreateIndex("dbo.Players", "TeamId");
            AddForeignKey("dbo.Players", "TeamId", "dbo.Teams", "TeamId", cascadeDelete: true);
        }
    }
}
