// See https://aka.ms/new-console-template for more information

using EnityFrameworkTests;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");
//
// using (var db = new BloggingContext())
// {
//     var blog = new Blog { Url = "ello" };
//     db.Blogs.Add(blog);
//     db.SaveChanges();
// }

using (var db = new BloggingContext())
{
    var blogs = db.Blogs;

    foreach (var blog in blogs)
    {
        Console.WriteLine($"Found: {blog.Url}");
    }
}