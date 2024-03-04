namespace EF.Models;
class User
{
    public int UserId { get; set; }
    public string? Name { get; set; }

    public List<Post> Posts { get; } = new();

    public void AddPostToUser(Post a)
    {
        Posts.Add(a);
        a.User = this;
    }
}
