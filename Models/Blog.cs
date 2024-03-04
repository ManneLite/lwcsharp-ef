namespace EF.Models;
class Blog
{
    public int BlogId { get; set; }
    public string? Name { get; set; }

    public int UserId { get; set; }
    public User? User { get; set; }

    public List<Post> Posts { get; } = new();

    public void AddPostsToBlog(Post a)
    {
        Posts.Add(a);
        a.Blog = this;
    }
}

