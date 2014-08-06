namespace BlogSiteTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BlogPostAuthor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BlogPosts", "Author", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BlogPosts", "Author");
        }
    }
}
