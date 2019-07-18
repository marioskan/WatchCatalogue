namespace WatchCatalogue.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class movieTomovierent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieRents",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MovieID = c.Int(nullable: false),
                        UserID = c.String(),
                        DateRented = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Movies", t => t.MovieID, cascadeDelete: true)
                .Index(t => t.MovieID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieRents", "MovieID", "dbo.Movies");
            DropIndex("dbo.MovieRents", new[] { "MovieID" });
            DropTable("dbo.MovieRents");
        }
    }
}
