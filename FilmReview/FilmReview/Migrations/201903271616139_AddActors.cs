namespace FilmReview.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddActors : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        ActorId = c.Int(nullable: false, identity: true),
                        ActorName = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.String(),
                    })
                .PrimaryKey(t => t.ActorId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Actors");
        }
    }
}
