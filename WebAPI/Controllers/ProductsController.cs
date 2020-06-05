using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;


namespace WebAPI.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product {Id = 1, Name = "Tomato Soup", Catagory = "Groceries", Price = 1},
            new Product {Id = 2, Name = "Yo-yo", Catagory = "Toys", Price = 1},
            new Product {Id = 3, Name = "Hammer", Catagory = "Hardware", Price = 16.99M}

        };
        [Route ]
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
