namespace EF;
//using EF.Models;
using Microsoft.EntityFrameworkCore;

class DB : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Blog> Blogs { get; set; }

    //string _path = "blogging.db";

    //protected override void OnConfiguring(DbContextOptionsBuilder options) =>
    //    options.UseSqlite($"Data Source={_path}");

    public string DbPath { get; }
    public DB()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "blogging.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    //        options.UseSqlite($"{DbPath}",
    //        optionsSqlite => { optionsSqlite.MigrationsAssembly("$(MSBuildEF)"); });

    //public DataAccess(IConfiguration configuration) => Configuration = configuration;

    //public DB(DbContextOptions<DB> options) : base(options) { }

    //public IConfiguration Configuration { get; }
    //public void ConfiguringServices(IServiceCollection services)
    //{
    //    services.AddDbContext<DB>(options =>
    //    {
    //        options.UseSqlite(Configuration.GetConnectionString($"{DbPath}"));
    //    });

    //}
}
public class User
{
    public int UserId { get; set; }
    public string? Name { get; set; }

    public List<Post> Posts { get; } = new();
}

public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }

    public List<Post> Posts { get; } = new();
}

public class Post
{
    public int PostId { get; set; }
    public string Title { get; set; }

    public int BlogId { get; set; }
    public Blog Blog { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }

    public List<Category> Categories { get; } = new();
}

public class Category
{
    public int CategoryId { get; set; }
    public string? Name { get; set; }

    public List<Post> Posts { get; } = new();
}