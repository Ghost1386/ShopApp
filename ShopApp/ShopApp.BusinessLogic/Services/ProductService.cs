using Microsoft.EntityFrameworkCore;
using ShopApp.BusinessLogic.Interfaces;
using ShopApp.Common.Models;

namespace ShopApp.BusinessLogic.Services;

public class ProductService : IProductService
{
    private readonly ShopAppContext _db;

    public ProductService(ShopAppContext db)
    {
        _db = db;
    }
    
    public IEnumerable<Product> GetProducts()
    {
        return _db.Products.ToList();
    }

    public Product Get(int id)
    {
        Product product = _db.Products.FirstOrDefault(
            x => x.Id == id);
        
        return product;
    }

    public void Delete(int id)
    {
        Product product = _db.Products.FirstOrDefault(x => x.Id == id);
        
        _db.Products.Remove(product);
        _db.SaveChanges();
    }

    public void Create(Product product)
    {
        _db.Products.Add(product);
        _db.SaveChanges();
    }

    public void Edit(Product product)
    {
        if (!_db.Products.Any(x => x.Id == product.Id))
        {
            return;
        }
 
        _db.Update(product);
        _db.SaveChanges();
    }
}