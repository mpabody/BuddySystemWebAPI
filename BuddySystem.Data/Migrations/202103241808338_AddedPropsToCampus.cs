namespace BuddySystem.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPropsToCampus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Campus", "Address", c => c.String(nullable: false));
            AddColumn("dbo.Campus", "PhoneNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Campus", "PhoneNumber");
            DropColumn("dbo.Campus", "Address");
        }
    }
}
