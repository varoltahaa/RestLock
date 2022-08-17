using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //Bu classla amacımız Database tabloları ile proje classlarını ilişkilendirebilmek.
    public class RestLockContext:DbContext
    {
        //Bu metod ile projenin hangi veri tabanı ile ilişkilendirileceğini yazarız
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=RestLock;Trusted_Connection=True;");
        }
        // Classların Datebasede hangi tabloya karşılık geldiklerini yazıyoruz
        public DbSet<Place> Places { get; set; }
        public DbSet<PlaceCategory> PlaceCategories { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuCategory> MenuCategories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<PlaceImage> PlaceImages { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
