namespace WatchCatalogue.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class amount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Amount", c => c.Int(nullable: false));
            DropColumn("dbo.Movies", "Rating");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Rating", c => c.Int(nullable: false));
            DropColumn("dbo.Movies", "Amount");
        }
    }
}
