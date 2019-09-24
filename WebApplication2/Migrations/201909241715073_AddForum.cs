namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForum : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Forum",
                c => new
                    {
                        ForumID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        Comment = c.String(),
                        Helpful = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ForumID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Forum");
        }
    }
}
