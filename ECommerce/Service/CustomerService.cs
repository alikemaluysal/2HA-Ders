using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Data;
using ECommerce.Entities;

namespace ECommerce.Service
{

    public class CustomerService : IService
    {
        Database _database;

        public CustomerService(Database database)
        {
            _database = database;
        }

        public void Create()
        {
            Customer customer = new Customer();
            Console.Write("Adınızı girin: ");
            customer.FirstName = Console.ReadLine();

            Console.Write("Soyadınızı girin: ");
            customer.LastName = Console.ReadLine();

            Console.Write("Email adresinizi girin: ");
            customer.Email = Console.ReadLine();

            _database.Customers.Add(customer);
            _database.SaveChanges();
        }

        public void GetAll()
        {
            foreach (var customer in _database.Customers)
            {
                Console.WriteLine($"{customer.Id} - {customer.FirstName} - {customer.LastName} - {customer.Email}");

            }
        }

        public void Update()
        {
            GetAll();
            Console.Write("Güncellenecek müşterinin Id'sini girin: ");
            int id = int.Parse(Console.ReadLine());
            Customer customerToUpdate = _database.Customers.FirstOrDefault(c => c.Id == id);
            Customer newCustomer = new Customer();
            Console.Write("Yeni adı girin: ");
            string firstName = Console.ReadLine();
            if (!String.IsNullOrEmpty(firstName))
                newCustomer.FirstName = firstName;

            Console.Write("Yeni soyadı girin: ");
            string lastName = Console.ReadLine();
            if (!String.IsNullOrEmpty(firstName))
                newCustomer.LastName = firstName;
            Console.Write("Yeni email adresini girin: ");

            string email = Console.ReadLine();
            if (!String.IsNullOrEmpty(email))
                newCustomer.Email = email;

            newCustomer.Email = Console.ReadLine();
            customerToUpdate.FirstName = newCustomer.FirstName;
            customerToUpdate.LastName = newCustomer.LastName;
            customerToUpdate.Email = newCustomer.Email;


            _database.Customers.Update(customerToUpdate);
            _database.SaveChanges();
        }

        public void Delete()
        {
            GetAll();
            Console.Write("Silinecek müşterinin Id'sini girin: ");
            int id = int.Parse(Console.ReadLine());
            Customer customerToDelete = _database.Customers.FirstOrDefault(c => c.Id == id);
            _database.Customers.Remove(customerToDelete);
            _database.SaveChanges();
        }

    }
}
