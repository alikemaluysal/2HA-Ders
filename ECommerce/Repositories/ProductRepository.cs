using ECommerce.Data;
using ECommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        Database _database;

        public ProductRepository(Database database)
        {
            _database = database;
        }

        public void Add(Product product)
        {
            _database.Products.Add(product);
            _database.SaveChanges();
        }

        public void Update(Product product)
        {
            _database.Products.Update(product);
            _database.SaveChanges();
        }

        public void Delete(Product product)
        {
            _database.Products.Remove(product);
            _database.SaveChanges();
        }


        public List<Product> GetAll()
        {
            return _database.Products.ToList();
        }
    }
}
