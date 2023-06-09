using ECommerce.Data;
using ECommerce.Entities;
using ECommerce.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Service
{
    public class CategoryService : ICategoryService
    {

        IRepository<Category> _repository;

        public CategoryService(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public void Create()
        {
            Category category = new Category();
            Console.Write("Kategori Adı: ");
            category.Name = Console.ReadLine();

            Console.Write("Kategori Açıklaması: ");
            category.Description = Console.ReadLine();

            _repository.Add(category);

        }

        public void GetAll()
        {
            foreach (var category in _repository.GetAll())
            {
                Console.WriteLine($"{category.Id} - {category.Name} - {category.Description}");
            }
        }

        public void Delete()
        {
            GetAll();
            Console.Write("Silinecek kategorinin Id'sini girin: ");
            int id = int.Parse(Console.ReadLine());
            Category categoryToDelete = _repository.GetAll().FirstOrDefault(c => c.Id == id);
            _repository.Delete(categoryToDelete);
        }

        public void Update()
        {
            Console.WriteLine("Kategoriler");
            Console.WriteLine("--------------");
            GetAll();

            Console.Write("Güncellenecek kategorinin Id'si: ");
            int id = int.Parse(Console.ReadLine());

            Category categoryToUpdate = _repository.GetAll().FirstOrDefault(x => x.Id == id);

            Console.Write("Kategorinin yeni adını girin: ");
            string name = Console.ReadLine();

            if (!String.IsNullOrEmpty(name))
                categoryToUpdate.Name = name;

            //Ternary operator
            //categoryToUpdate.Name = String.IsNullOrEmpty(name) ? categoryToUpdate.Name : name;


            Console.Write("Kategorinin yeni açıklamasını girin: ");
            string description = Console.ReadLine();

            if(!String.IsNullOrEmpty(description))
                categoryToUpdate.Description = description;



            _repository.Update(categoryToUpdate);
        }


        public void AddSeedData()
        {
            Category category1 = new Category() { Id = 1, Name = "Elektronik", Description = "Elektronik Kategorisi" };
            Category category2 = new Category() { Id = 2, Name = "Telefon", Description = "Telefon Kategorisi" };
            Category category3 = new Category() { Id = 3, Name = "Bilgisayar", Description = "Bilgisayar Kategorisi" };

            _repository.Add(category1);
            _repository.Add(category2);
            _repository.Add(category3);
        }

    }
}
