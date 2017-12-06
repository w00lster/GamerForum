namespace GamerForum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialCreate : DbMigration
    {
        public override void Up()
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
            
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        GameId = c.Int(nullable: false, identity: true),
                        AdminID = c.Int(nullable: false),
                        Game_name = c.String(),
                        Game_url = c.String(),
                        Description = c.String(),
                        Game_time = c.String(),
                        Number_of_Players = c.String(),
                        Year_releashed = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GameId);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreId = c.Int(nullable: false, identity: true),
                        Genre_name = c.String(),
                    })
                .PrimaryKey(t => t.GenreId);
            
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        RatingId = c.Int(nullable: false, identity: true),
                        Rating_value = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.RatingId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        First_name = c.String(),
                        Last_name = c.String(),
                        Image = c.String(),
                        Age = c.Int(nullable: false),
                        Day_created = c.DateTime(nullable: false),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        StatusId = c.Int(nullable: false, identity: true),
                        Status_name = c.String(),
                    })
                .PrimaryKey(t => t.StatusId);
            
            CreateTable(
                "dbo.Rights",
                c => new
                    {
                        RightId = c.Int(nullable: false, identity: true),
                        Rights_name = c.String(),
                    })
                .PrimaryKey(t => t.RightId);
            
            CreateTable(
                "dbo.Wanted_games",
                c => new
                    {
                        Wanted_Game_Id = c.Int(nullable: false, identity: true),
                        Wanted_Game_Name = c.String(),
                        Wanted_Game_Url = c.String(),
                    })
                .PrimaryKey(t => t.Wanted_Game_Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.game_genre",
                c => new
                    {
                        Game_id = c.Int(nullable: false),
                        Genre_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Game_id, t.Genre_id })
                .ForeignKey("dbo.Games", t => t.Game_id, cascadeDelete: true)
                .ForeignKey("dbo.Genres", t => t.Genre_id, cascadeDelete: true)
                .Index(t => t.Game_id)
                .Index(t => t.Genre_id);
            
            CreateTable(
                "dbo.ratings_by_users",
                c => new
                    {
                        User_id = c.String(nullable: false, maxLength: 128),
                        Rating_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_id, t.Rating_id })
                .ForeignKey("dbo.AspNetUsers", t => t.User_id, cascadeDelete: true)
                .ForeignKey("dbo.Ratings", t => t.Rating_id, cascadeDelete: true)
                .Index(t => t.User_id)
                .Index(t => t.Rating_id);
            
            CreateTable(
                "dbo.status_rights",
                c => new
                    {
                        Status_id = c.Int(nullable: false),
                        Rights_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Status_id, t.Rights_id })
                .ForeignKey("dbo.Status", t => t.Status_id, cascadeDelete: true)
                .ForeignKey("dbo.Rights", t => t.Rights_id, cascadeDelete: true)
                .Index(t => t.Status_id)
                .Index(t => t.Rights_id);
            
            CreateTable(
                "dbo.user_status",
                c => new
                    {
                        Users_id = c.String(nullable: false, maxLength: 128),
                        Status_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Users_id, t.Status_id })
                .ForeignKey("dbo.AspNetUsers", t => t.Users_id, cascadeDelete: true)
                .ForeignKey("dbo.Status", t => t.Status_id, cascadeDelete: true)
                .Index(t => t.Users_id)
                .Index(t => t.Status_id);
            
            CreateTable(
                "dbo.user_wg",
                c => new
                    {
                        Users_id = c.String(nullable: false, maxLength: 128),
                        wanted_game_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Users_id, t.wanted_game_id })
                .ForeignKey("dbo.AspNetUsers", t => t.Users_id, cascadeDelete: true)
                .ForeignKey("dbo.Wanted_games", t => t.wanted_game_id, cascadeDelete: true)
                .Index(t => t.Users_id)
                .Index(t => t.wanted_game_id);
            
            CreateTable(
                "dbo.game_rating",
                c => new
                    {
                        Game_id = c.Int(nullable: false),
                        Rating_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Game_id, t.Rating_id })
                .ForeignKey("dbo.Games", t => t.Game_id, cascadeDelete: true)
                .ForeignKey("dbo.Ratings", t => t.Rating_id, cascadeDelete: true)
                .Index(t => t.Game_id)
                .Index(t => t.Rating_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.game_rating", "Rating_id", "dbo.Ratings");
            DropForeignKey("dbo.game_rating", "Game_id", "dbo.Games");
            DropForeignKey("dbo.user_wg", "wanted_game_id", "dbo.Wanted_games");
            DropForeignKey("dbo.user_wg", "Users_id", "dbo.AspNetUsers");
            DropForeignKey("dbo.user_status", "Status_id", "dbo.Status");
            DropForeignKey("dbo.user_status", "Users_id", "dbo.AspNetUsers");
            DropForeignKey("dbo.status_rights", "Rights_id", "dbo.Rights");
            DropForeignKey("dbo.status_rights", "Status_id", "dbo.Status");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.ratings_by_users", "Rating_id", "dbo.Ratings");
            DropForeignKey("dbo.ratings_by_users", "User_id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.game_genre", "Genre_id", "dbo.Genres");
            DropForeignKey("dbo.game_genre", "Game_id", "dbo.Games");
            DropIndex("dbo.game_rating", new[] { "Rating_id" });
            DropIndex("dbo.game_rating", new[] { "Game_id" });
            DropIndex("dbo.user_wg", new[] { "wanted_game_id" });
            DropIndex("dbo.user_wg", new[] { "Users_id" });
            DropIndex("dbo.user_status", new[] { "Status_id" });
            DropIndex("dbo.user_status", new[] { "Users_id" });
            DropIndex("dbo.status_rights", new[] { "Rights_id" });
            DropIndex("dbo.status_rights", new[] { "Status_id" });
            DropIndex("dbo.ratings_by_users", new[] { "Rating_id" });
            DropIndex("dbo.ratings_by_users", new[] { "User_id" });
            DropIndex("dbo.game_genre", new[] { "Genre_id" });
            DropIndex("dbo.game_genre", new[] { "Game_id" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropTable("dbo.game_rating");
            DropTable("dbo.user_wg");
            DropTable("dbo.user_status");
            DropTable("dbo.status_rights");
            DropTable("dbo.ratings_by_users");
            DropTable("dbo.game_genre");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Wanted_games");
            DropTable("dbo.Rights");
            DropTable("dbo.Status");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Ratings");
            DropTable("dbo.Genres");
            DropTable("dbo.Games");
            DropTable("dbo.Admins");
        }
    }
}
