using EF.Models;
using Microsoft.EntityFrameworkCore;

namespace EF;

class DB : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Blog> Blogs { get; set; }

    string _path = "blogging.db";

    protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        options.UseSqlite($"Data Source={_path}");

    //public string DbPath { get; }
    //public DB()
    //{
    //    var folder = Environment.SpecialFolder.LocalApplicationData;
    //    var path = Environment.GetFolderPath(folder);
    //    DbPath = Path.Join(path, "blogging.db");
    //}

    //protected override void OnConfiguring(DbContextOptionsBuilder options)
    //        => options.UseSqlite($"Data Source={DbPath}");
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
