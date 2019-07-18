namespace WatchCatalogue.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class final : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MovieRents", "Price", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MovieRents", "Price", c => c.Single(nullable: false));
        }
    }
}
