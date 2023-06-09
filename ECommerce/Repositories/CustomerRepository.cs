using ECommerce.Data;
using ECommerce.Entities;

namespace ECommerce.Repositories
{
    public class CustomerRepository : IRepository<Customer>
    {
        Database _database;

        public CustomerRepository(Database database)
        {
            _database = database;
        }

        public void Add(Customer customer)
        {
            _database.Customers.Add(customer);
            _database.SaveChanges();
        }

        public void Update(Customer customer)
        {
            _database.Customers.Update(customer);
            _database.SaveChanges();
        }

        public void Delete(Customer customer)
        {
            _database.Customers.Remove(customer);
            _database.SaveChanges();
        }


        public List<Customer> GetAll()
        {
            return _database.Customers.ToList();
        }


    }
}
