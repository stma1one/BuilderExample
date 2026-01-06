using BuilderExample.Builders;
using BuilderExample.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        //regular usage ---ughhhhhh ugly
        // BlogPost blogPost = new BlogPost(title:"This is my first blog post", content: "My First Blog Post", "Kuku Kaka", DateTime.Now, new List<string>(), new List<string>(),"C#","Programing");
        // Console.WriteLine("First Blog:" + blogPost);

        BlogPostBuilder builder = new BlogPostBuilder();
        builder.AddTitle("My First Blog Post");
        builder.AddContent("This is my first blog post");
        builder.AddDate(DateTime.Now);
        BlogPost blogPost = builder.Build();


		#region using builder
		BlogPostBuilder builder2 = new BlogPostBuilder();
        builder2.AddTitle("My First Blog Post");
        builder2.AddContent("This is my first blog post");
        builder.AddAuthor("Kuku Kaka");
        builder.AddDate(DateTime.Now);
        builder.AddCategory("C#");
        builder.AddMetadataDescription("Programing");
        builder.AddMetadataTitle("C#");
        BlogPost blog = builder.Build();
        Console.WriteLine("Second Blog:" + blog);
        #endregion

        #region Using Fluent Builder
        BlogPost blogPost1 = new FluentBlogPostBuilder().WithTitle("My First Blog Post")
            .WithContent("This is my first blog post")
            .WithAuthor("Kuku Kaka").WithDate(DateTime.Now).WithCategory("C#").Build();
        Console.WriteLine("Third blog:" + blogPost1);

        #endregion
        FluentBlogPostBuilder fl = new FluentBlogPostBuilder();
        fl.WithTitle("My First Blog Post");
        fl.WithContent("This is my first blog post");
        BlogPost p = fl.Build();





	}
}