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
    
    [HttpGet]
    public Product GetProduct(int id)
    {
        return _productService.Get(id);
    }
    
    [HttpPost]
    public void CreateNewProduct(Product product)
    {
        _productService.Create(product);
    }
    
    [HttpDelete]
    public void DeleteProduct(int id)
    {
        _productService.Delete(id);
    }
    
    [HttpPut]
    public void EditUser(Product product)
    {
        if (ModelState.IsValid)
        {
            _productService.Edit(product);
        }
    }
}