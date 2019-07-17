namespace WatchCatalogue.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRentInfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RentInfoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        MovieID = c.Int(nullable: false),
                        RentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RentInfoes");
        }
    }
}
