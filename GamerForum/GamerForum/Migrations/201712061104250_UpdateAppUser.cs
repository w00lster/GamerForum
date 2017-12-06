namespace GamerForum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAppUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "DayCreated", c => c.DateTime(nullable: false));
            DropColumn("dbo.AspNetUsers", "First_name");
            DropColumn("dbo.AspNetUsers", "Last_name");
            DropColumn("dbo.AspNetUsers", "Day_created");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Day_created", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "Last_name", c => c.String());
            AddColumn("dbo.AspNetUsers", "First_name", c => c.String());
            DropColumn("dbo.AspNetUsers", "DayCreated");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}
