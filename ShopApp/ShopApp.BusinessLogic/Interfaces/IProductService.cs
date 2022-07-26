using ShopApp.Common.Models;

namespace ShopApp.BusinessLogic.Interfaces;

public interface IProductService
{
    IEnumerable<Product> GetProducts();

    Product Get(int id);

    void Delete(int id);

    void Create(Product product);

    void Edit(Product product);
}