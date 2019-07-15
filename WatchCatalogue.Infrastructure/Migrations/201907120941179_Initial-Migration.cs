namespace WatchCatalogue.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Channels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SubscriptionServiceID = c.Int(nullable: false),
                        Name = c.String(),
                        ImgGuid = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SubscriptionServices", t => t.SubscriptionServiceID, cascadeDelete: true)
                .Index(t => t.SubscriptionServiceID);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ChannelID = c.Int(nullable: false),
                        Rating = c.Int(nullable: false),
                        Name = c.String(),
                        ImgGuid = c.String(),
                        Genre = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Channels", t => t.ChannelID, cascadeDelete: true)
                .Index(t => t.ChannelID);
            
            CreateTable(
                "dbo.SubscriptionServices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Channels", "SubscriptionServiceID", "dbo.SubscriptionServices");
            DropForeignKey("dbo.Movies", "ChannelID", "dbo.Channels");
            DropIndex("dbo.Movies", new[] { "ChannelID" });
            DropIndex("dbo.Channels", new[] { "SubscriptionServiceID" });
            DropTable("dbo.SubscriptionServices");
            DropTable("dbo.Movies");
            DropTable("dbo.Channels");
        }
    }
}
