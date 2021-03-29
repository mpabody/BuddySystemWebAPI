namespace BuddySystem.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedCampusUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CampusUser",
                c => new
                    {
                        CampusId = c.Int(nullable: false),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.CampusId, t.UserId })
                .ForeignKey("dbo.Campus", t => t.CampusId, cascadeDelete: true)
                .ForeignKey("dbo.ApplicationUser", t => t.UserId, cascadeDelete: true)
                .Index(t => t.CampusId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CampusUser", "UserId", "dbo.ApplicationUser");
            DropForeignKey("dbo.CampusUser", "CampusId", "dbo.Campus");
            DropIndex("dbo.CampusUser", new[] { "UserId" });
            DropIndex("dbo.CampusUser", new[] { "CampusId" });
            DropTable("dbo.CampusUser");
        }
    }
}
