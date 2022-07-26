using Microsoft.EntityFrameworkCore;
using ShopApp.Common.Models;

namespace ShopApp.BusinessLogic;

public sealed class ShopAppContext : DbContext
{
    public ShopAppContext()
    {
        Database.EnsureCreated();
    }
    
    public DbSet<User> Users { get; set; }
    
    public DbSet<Product> Products { get; set; }
}