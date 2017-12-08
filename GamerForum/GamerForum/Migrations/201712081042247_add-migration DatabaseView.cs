namespace GamerForum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmigrationDatabaseView : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        ImageId = c.Int(nullable: false, identity: true),
                        GameId = c.Int(nullable: false),
                        Image_path = c.String(),
                    })
                .PrimaryKey(t => t.ImageId)
                .ForeignKey("dbo.Games", t => t.GameId, cascadeDelete: true)
                .Index(t => t.GameId);
            
            DropColumn("dbo.Games", "AdminID");
            DropTable("dbo.Admins");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        Admin_name = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.AdminId);
            
            AddColumn("dbo.Games", "AdminID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Images", "GameId", "dbo.Games");
            DropIndex("dbo.Images", new[] { "GameId" });
            DropTable("dbo.Images");
        }
    }
}
