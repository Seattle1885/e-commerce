using Microsoft.EntityFrameworkCore;

namespace e_commerce.Models
{
    public class MyContext : DbContext
    {

        public MyContext (DbContextOptions options) : base(options) {}

        public DbSet<User> Users {get; set;}

        public DbSet<Product> Products {get; set;}

        public DbSet<Buyer> Buyers {get; set;}
    }
}