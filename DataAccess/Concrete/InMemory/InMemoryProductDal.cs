using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product { ProductId = 1, CategoryId = 1, ProductName = "Bardak", UnitPrice = 15, UnitsInStock = 15 },
                new Product { ProductId = 2, CategoryId = 1, ProductName = "Kamera", UnitPrice = 105, UnitsInStock = 5 },
                new Product { ProductId = 3, CategoryId = 2, ProductName = "Gözlük", UnitPrice = 45, UnitsInStock = 115 },
                new Product { ProductId = 4, CategoryId = 2, ProductName = "TV", UnitPrice = 1500, UnitsInStock = 1 },
                new Product { ProductId = 5, CategoryId = 2, ProductName = "Sandalye", UnitPrice = 35, UnitsInStock = 25 },

            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }
 
        public void Delete(Product product)
        {
            //LINQ -Language Integrated Query
            Product productToDelete = productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId); //Burda foreach gibi arama yapıp eger esitse onu remove ettik
            _products.Remove(productToDelete);
        

        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
          return  _products.Where(p => p.CategoryId == categoryId).ToList(); //Where koşulu içindeki şarta uyan bütün elemanları yeni bi list haline getirir ve onu döndrür
        }

        public void Update(Product product)
        {   // Gönderdiğim ürün id'sine sahip olan listedeki ürünü bul.
            Product productToUpdate = productToUpdate= _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.UnitPrice = product.UnitPrice;
        }

    }
}
