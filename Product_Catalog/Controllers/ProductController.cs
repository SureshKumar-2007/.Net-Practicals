
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Product_Catalog.Models;

namespace Product_Catalog.Controllers
{
    public class ProductController : Controller
    {
        private List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Description = "HP Laptop",
                    Category = "Electronics",
                    Price = 50000,
                    ImageUrl = "https://images.unsplash.com/photo-1496181133206-80ce9b88a853?w=400"
                },
                new Product
                {
                    Id = 2,
                    Name = "Mobile",
                    Description = "Samsung Mobile",
                    Category = "Electronics",
                    Price = 20000,
                    ImageUrl = "https://images.unsplash.com/photo-1511707171634-5f897ff02aa9?w=400"
                },
                new Product
                {
                    Id = 3,
                    Name = "Headphones",
                    Description = "Wireless Headphones",
                    Category = "Accessories",
                    Price = 2000,
                    ImageUrl = "https://images.unsplash.com/photo-1505740420928-5e560c06d30e?w=400"
                },
                new Product
                {
                    Id = 4,
                    Name = "Keyboard",
                    Description = "Mechanical Keyboard",
                    Category = "Accessories",
                    Price = 3000,
                    ImageUrl = "https://images.unsplash.com/photo-1587829741301-dc798b83add3?w=400"
                }
            };
        }
        public ActionResult Index()
        {
            List<Product> products = GetProducts();
            return View(products);
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            Product product = GetProducts()
                .FirstOrDefault(p => p.Id == id.Value);

            if (product == null)
            {
                return HttpNotFound();
            }

            return View(product);
        }
    }
}
