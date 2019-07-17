namespace WatchCatalogue.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedidtype : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RentInfoes", "UserID", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RentInfoes", "UserID", c => c.Int(nullable: false));
        }
    }
}
