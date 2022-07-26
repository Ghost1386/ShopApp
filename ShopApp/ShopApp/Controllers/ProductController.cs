using System.Security.AccessControl;
using Microsoft.AspNetCore.Mvc;
using ShopApp.BusinessLogic.Services;
using ShopApp.Common.Models;

namespace ShopApp.Controllers;

[ApiController]
[Route("api/[product-controller]")]
public class ProductController : ControllerBase
{
    private readonly ProductService _productService;

    public ProductController(ProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public IEnumerable<Product> GetAllProduct()
    {
        return _productService.GetProducts();
    }
    
    [HttpGet("{id}")]
    public Product GetProduct(int id)
    {
        return _productService.Get(id);
    }
    
    [HttpPost]
    public void CreateNewProduct(Product product)
    {
        _productService.Create(product);
    }
    
    [HttpDelete("{id}")]
    public void DeleteProduct(int id)
    {
        _productService.Delete(id);
    }
    
    [HttpPut]
    public void EditProduct(Product product)
    {
        _productService.Edit(product);
    }
}