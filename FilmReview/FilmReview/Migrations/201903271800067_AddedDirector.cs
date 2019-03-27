namespace FilmReview.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDirector : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Directors",
                c => new
                    {
                        DirectorId = c.Int(nullable: false, identity: true),
                        DirectorName = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DirectorId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Directors");
        }
    }
}
