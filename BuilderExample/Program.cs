﻿using BuilderExample.Builders;
using BuilderExample.Models;

internal class Program
{
    private static void Main(string[] args)
    {
       //regular usage ---ughhhhhh ugly
       BlogPost blogPost = new BlogPost("My First Blog Post", "This is my first blog post", "Kuku Kaka", DateTime.Now, new List<string>(), new List<string>(),"C#","Programing");
        Console.WriteLine("First Blog:" + blogPost);
    
        
        
        #region using builder
        BlogPostBuilder builder = new BlogPostBuilder();
        builder.AddTitle("My First Blog Post");
        builder.AddContent("This is my first blog post");
        builder.AddAuthor("Kuku Kaka");
        builder.AddDate(DateTime.Now);
        builder.AddCategory("C#");
        builder.AddMetadataDescription("Programing");
        builder.AddMetadataTitle("C#");
        BlogPost blog = builder.Build();
        Console.WriteLine("Second Blog:" + blog);
        #endregion

        #region Using Fluent Builder
        BlogPost blogPost1 = new FluentBlogPostBuilder().WithAuthor("My First Blog Post")
            .WithContent("This is my first blog post")
            .WithAuthor("Kuku Kaka").WithDate(DateTime.Now).WithCategory("C#").Build();
        Console.WriteLine("Third blog:" + blogPost1);

        #endregion






    }
}