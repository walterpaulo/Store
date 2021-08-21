using Microsoft.EntityFrameworkCore;
using Store.Models;

namespace Store.Services
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options){}
            public DbSet<Products> Usuarios { get; set;}
            public DbSet<Category> Categories { get; set;}
        
    }
}