using Microsoft.EntityFrameworkCore;

namespace Blazor_CRUD.Data
{
    public class AppDbContext: DbContext
    {
        public DbSet<Post> Posts { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            Post[] postToSeed = new Post[10];

            for (int i = 1;  i < 11; i++)
            {
                postToSeed[i - 1] = new Post
                {
                    Id = i,
                    Title = $"Post {i}",
                    Content = $"This is some exemple for post {i}. The content is very interstring and I just wanded it to be two sentences to long."
                };
            }

            modelBuilder.Entity<Post>().HasData(postToSeed);
        }
    }
}
