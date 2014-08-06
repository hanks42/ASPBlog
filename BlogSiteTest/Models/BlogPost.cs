using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BlogSiteTest.Models
{
    public class BlogPost
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Post { get; set; }
    }

    public class BlogDBContext : DbContext
    {
        public DbSet<BlogPost> BlogPosts { get; set; }
    }
}