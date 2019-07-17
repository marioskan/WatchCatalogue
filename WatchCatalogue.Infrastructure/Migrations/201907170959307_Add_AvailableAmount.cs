namespace WatchCatalogue.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_AvailableAmount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "AvailableAmount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "AvailableAmount");
        }
    }
}
