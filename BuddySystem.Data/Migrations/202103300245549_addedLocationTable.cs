namespace BuddySystem.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedLocationTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Location",
                c => new
                    {
                        LocationId = c.Int(nullable: false, identity: true),
                        CampusId = c.Int(nullable: false),
                        LocationName = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        LocationNotes = c.String(),
                    })
                .PrimaryKey(t => t.LocationId)
                .ForeignKey("dbo.Campus", t => t.CampusId, cascadeDelete: true)
                .Index(t => t.CampusId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Location", "CampusId", "dbo.Campus");
            DropIndex("dbo.Location", new[] { "CampusId" });
            DropTable("dbo.Location");
        }
    }
}
