namespace eTicket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActorMIg : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProfilePictureURL = c.String(),
                        FullName = c.String(),
                        Bio = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Actors");
        }
    }
}
