namespace InspirationStation1.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Applications",
                c => new
                    {
                        ApplicationId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Publisher = c.String(),
                        ImageUrl = c.String(),
                        AppLink = c.String(),
                        Price = c.String(),
                    })
                .PrimaryKey(t => t.ApplicationId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Applications");
        }
    }
}
