namespace BlogSiteTest.Migrations
{
    using BlogSiteTest.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BlogSiteTest.Models.BlogDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BlogSiteTest.Models.BlogDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.BlogPosts.AddOrUpdate(i => i.Title,
                new BlogPost
                {
                    Title = "Etsy street art Brooklyn",
                    Post = "Distillery ethnic mumblecore, Kickstarter DIY authentic pug 8-bit plaid Schlitz. Wayfarers paleo actually wolf fap butcher. Fanny pack blog hashtag artisan organic. Locavore chillwave food truck Brooklyn biodiesel fanny pack organic skateboard, YOLO Pinterest shabby chic Neutra gluten-free chambray. Helvetica selfies brunch, banjo 90's Godard scenester plaid keytar put a bird on it sartorial. Odd Future next level Helvetica lo-fi vinyl occupy, before they sold out post-ironic Vice mumblecore PBR&B XOXO Williamsburg. Roof party letterpress chillwave seitan organic PBR, Pitchfork meh semiotics messenger bag farm-to-table blog next level."
                },

                new BlogPost
                {
                    Title = "Banksy PBR&B, Pitchfork",
                    Post = "Vegan master cleanse selvage, sustainable next level High Life beard bicycle rights. Fixie whatever Wes Anderson, literally Helvetica dreamcatcher twee pour-over Brooklyn VHS. Neutra wayfarers VHS keytar Odd Future cred. Godard lomo Bushwick, jean shorts tousled Neutra irony Etsy. Pickled lomo mustache, YOLO fanny pack XOXO master cleanse cornhole brunch Bushwick. +1 Helvetica fanny pack, selfies flannel art party vegan. Banksy Helvetica Carles selfies kogi drinking vinegar fixie."
                },

                new BlogPost
                {
                    Title = "Williamsburg actually hoodie master",
                    Post = "Wolf Helvetica whatever distillery, bitters Bushwick quinoa salvia hoodie photo booth tousled. Etsy PBR&B Shoreditch XOXO Neutra biodiesel, beard pour-over ugh chia scenester craft beer Odd Future. Asymmetrical photo booth scenester lo-fi stumptown Banksy. Paleo sustainable narwhal asymmetrical umami, Intelligentsia bicycle rights PBR chia tattooed Helvetica gluten-free cardigan. Vinyl meh twee, banjo Austin hashtag Pitchfork hoodie literally tote bag art party crucifix before they sold out. Raw denim Etsy McSweeney's, locavore shabby chic put a bird on it 90's Helvetica jean shorts mumblecore. Brunch raw denim chillwave, wolf 8-bit Helvetica iPhone biodiesel authentic shabby chic banh mi Carles."
                },
            
                new BlogPost
                {
                    Title = "Vegan meggings food truck Shoreditch.",
                    Post = "Crucifix artisan roof party semiotics, try-hard slow-carb 8-bit hoodie Banksy pour-over Odd Future. Beard ugh leggings, cornhole shabby chic chillwave letterpress artisan 3 wolf moon master cleanse mlkshk American Apparel. Church-key Thundercats slow-carb Odd Future +1 3 wolf moon sriracha, pork belly Pitchfork wolf gastropub. Before they sold out quinoa High Life tattooed. DIY post-ironic wolf kale chips gastropub, hoodie Austin blog chillwave selfies. Pug Shoreditch meggings readymade. Gentrify polaroid retro, +1 organic mumblecore four loko photo booth crucifix Marfa chia Helvetica deep v art party flexitarian."
                }
            );
        }
    }
}
