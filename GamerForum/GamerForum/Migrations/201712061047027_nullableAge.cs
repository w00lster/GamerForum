namespace GamerForum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nullableAge : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "Age", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "Age", c => c.Int(nullable: false));
        }
    }
}
