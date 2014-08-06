namespace BlogSiteTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BlogPostDateCreated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BlogPosts", "DateCreated", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BlogPosts", "DateCreated");
        }
    }
}
