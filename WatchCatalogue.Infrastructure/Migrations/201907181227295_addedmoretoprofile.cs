namespace WatchCatalogue.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedmoretoprofile : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MovieRents", "Price", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MovieRents", "Price");
        }
    }
}
