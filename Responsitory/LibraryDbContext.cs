using Microsoft.EntityFrameworkCore;

namespace BackEnd.Models {
    public class LibraryDbContext : DbContext {
        public LibraryDbContext() { }
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base (options) { }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Initial Catalog=DBName;Integrated Security=True");
        // }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasKey(s=>s.BookId);
            modelBuilder.Entity<Category>().HasKey(s=>s.CategoryId);
            modelBuilder.Entity<Book>()
            .HasOne<Category>()
            .WithMany()
            .HasForeignKey(c => c.CategoryId);
            modelBuilder.Entity<User>().HasKey(s=>s.UserId);
            // modelBuilder.Entity<User>()
            // .HasData(
            //     new User{
                    
            //         UserName = "Admin",
            //         Password="12345678",
            //         Role="Admin"
            //     },
            //     new User{
                    
            //         UserName = "username1",
            //         Password="12345678",
            //         Role="User"
            //     },
            //     new User{
                    
            //         UserName = "username2",
            //         Password="12345678",
            //         Role= "User"
            //     }
            // );
            
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}