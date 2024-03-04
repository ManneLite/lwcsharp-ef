namespace EF.Models;
class Category
{
    public int PostId { get; set; }
    public string? Name { get; set; }

    public Post? Post { get; set; }
    public List<Post> Posts { get; } = new();

    public void AddPostsToCategory(Post a)
    {
        Posts.Add(a);
        a.Category = this;
    }
}

