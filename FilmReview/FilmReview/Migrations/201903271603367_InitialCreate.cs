namespace FilmReview.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        FilmId = c.Int(nullable: false, identity: true),
                        GenreId = c.Int(nullable: false),
                        Title = c.String(),
                        Description = c.String(),
                        Length = c.Double(nullable: false),
                        Director = c.String(),
                        Actor = c.String(),
                        ReleaseDate = c.String(),
                    })
                .PrimaryKey(t => t.FilmId)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .Index(t => t.GenreId);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.GenreId);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewId = c.Int(nullable: false, identity: true),
                        FilmId = c.Int(nullable: false),
                        MainReview = c.String(),
                        Score = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ReviewId)
                .ForeignKey("dbo.Films", t => t.FilmId, cascadeDelete: true)
                .Index(t => t.FilmId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "FilmId", "dbo.Films");
            DropForeignKey("dbo.Films", "GenreId", "dbo.Genres");
            DropIndex("dbo.Reviews", new[] { "FilmId" });
            DropIndex("dbo.Films", new[] { "GenreId" });
            DropTable("dbo.Reviews");
            DropTable("dbo.Genres");
            DropTable("dbo.Films");
        }
    }
}
