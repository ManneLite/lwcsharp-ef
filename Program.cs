//DB db = new();

//db.Users.Add(new User { Name = "Yummy" });
//db.SaveChanges();
//db.Users.First().Posts.Add(new Post { Title = "Taiyaki" });
//db.Users.First().Posts.Add(new Post { Title = "Takoyaki" });
//db.SaveChanges();

//db.Blogs.Add(new Blog { Name = "FoodBlog" });
//db.SaveChanges();

//db.Categories.Add(new Category { Name = "Food" });
//db.SaveChanges();

//Post Post = db.Users.Where(u => u.Name ==
//"A").First().Posts.Where(a => a.Title == "Taiyaki").First();

using EF;

//using var db = new DB();

DB db = new();

//// Note: This sample requires the database to be created before running.
//Console.WriteLine($"Database path: {db.DbPath}.");
