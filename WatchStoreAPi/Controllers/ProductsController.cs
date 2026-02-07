using Microsoft.AspNetCore.Mvc;
using WatchStoreAPi.Models;

namespace WatchStoreAPi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    public static List<Product> Products =
    [
        new Product { Id = 1, Name = "Classic Watch", Description = "A timeless classic watch with a leather strap.", Price = 199.99m },
        new Product { Id = 2, Name = "Sport Watch", Description = "A durable sport watch with a rubber strap and water resistance.", Price = 149.99m },
        new Product
        {
            Id = 3, Name = "Luxury Watch", Description = "An elegant luxury watch with a stainless steel band and intricate design.", Price = 499.99m
        },
        new Product { Id = 4, Name = "Smart Watch", Description = "A modern smart watch with fitness tracking and smartphone connectivity.", Price = 299.99m },
  
    ];

    [HttpGet]
    public IEnumerable<Product> Get()
    {
        return Products;
    }

    [HttpPost]
    public void Post([FromBody]Product product)
    {
        Products.Add(product);
    }
    
    [HttpPut("{id}")]
    public void Put(int id ,[FromBody]Product product)
    {
        var pd = Products.FirstOrDefault(x => x.Id == id);
        if (pd !=null)
        {
            pd.Name = pd.Name;
            pd.Description = pd.Description;
            pd.Price = pd.Price;
        }
    }
    [HttpDelete("{id}")]
    public void Put(int id )
    {
        var product = Products.FirstOrDefault(x => x.Id == id);
        if (product !=null)
        {
            Products.Remove(product);
        }

    }
    
}
