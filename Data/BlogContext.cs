using Microsoft.EntityFrameworkCore;


public class BlogContext : DbContext
{
    public BlogContext(DbContextOptions<BlogContext> options) : base(options) { }

    public DbSet<Post> Posts { get; set; }
    public DbSet<Comment> Comments { get; set; }
}