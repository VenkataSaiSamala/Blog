namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        BlogId = c.Int(nullable: false, identity: true),
                        BlogTitle = c.String(),
                        BlogDate = c.DateTime(),
                        BlogDescription = c.String(),
                    })
                .PrimaryKey(t => t.BlogId);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        CommentTime = c.DateTime(nullable: false),
                        CommentDescription = c.String(),
                        BlogId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("dbo.Blogs", t => t.BlogId, cascadeDelete: true)
                .Index(t => t.BlogId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "BlogId", "dbo.Blogs");
            DropIndex("dbo.Comments", new[] { "BlogId" });
            DropTable("dbo.Comments");
            DropTable("dbo.Blogs");
        }
    }
}
