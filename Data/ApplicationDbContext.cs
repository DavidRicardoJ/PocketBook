using Microsoft.EntityFrameworkCore;
using PocketBook.Models;

namespace PocketBook.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<SuaEntidade>(s =>
            //{

            //});
        }

    }
}
