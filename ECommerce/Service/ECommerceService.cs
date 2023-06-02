using ECommerce.Data;
using ECommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Service
{
    public class ECommerceService
    {
        Database db = new Database();

        public void Run()
        {
            Database database = new Database();
            CategoryService categoryService = new CategoryService(database);
            ProductService productService = new ProductService(database);
            categoryService.AddSeedData();
            productService.AddSeedData();

            Menu();

            //productService.Delete();
            //productService.GetAll();
            ////productService.Create();
            ////productService.GetAll();
            //productService.Update();
            //productService.GetAll();

            //productService.GetAll();
            //productService.Create();
            //productService.GetAll();
            //productService.GetAll();

            //categoryService.Update();
            //categoryService.GetAll();

        }


        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine();
                Console.WriteLine("1- Kategori");
                Console.WriteLine("2- Ürün");
                Console.WriteLine("3- Müşteri");
                Console.WriteLine();
                Console.WriteLine("-------------------------------");
                Console.WriteLine();

                IService service = new BaseService();


                Console.Write("Lütfen işlem yapmak istediğiniz alanı seçin: ");
                string domain = Console.ReadLine();
                switch (domain)
                {
                    case "1":
                        service = new CategoryService(db);
                        break;

                    case "2":
                        service = new ProductService(db);
                        break;

                    case "3":
                        service = new CustomerService(db);
                        break;
                    default:
                        break;
                }

                Console.WriteLine("1 - Ekle");
                Console.WriteLine("2 - Sil");
                Console.WriteLine("3 - Güncelle");
                Console.WriteLine("4 - Listele");
                Console.Write("Lütfen yapmak istediğiniz işlemi seçin:");
                string operation = Console.ReadLine();


                switch (operation)
                {
                    case "1":
                        service.Create();
                        break;

                    case "2":
                        service.Delete();
                        break;

                    case "3":
                        service.Update();
                        break;

                    case "4":
                        service.GetAll();
                        break;
                    default:
                        break;
                }

            }
        }

        private static void CustomerDemo(Database database)
        {
            CustomerService customerService = new CustomerService(database);

            customerService.Create();
            customerService.GetAll();
            customerService.Create();
            customerService.GetAll();
            customerService.Update();
            customerService.GetAll();
        }

        private static void CategoryDemo()
        {
            Database database = new Database();
            CategoryService categoryService = new CategoryService(database);

            //categoryService.AddFakeData(database);
            categoryService.GetAll();
            Console.WriteLine("--------------------------------");
            categoryService.Create();
            Console.WriteLine("--------------------------------");
            categoryService.GetAll();
            Console.WriteLine("--------------------------------");
            categoryService.Delete();
            Console.WriteLine("--------------------------------");
            categoryService.GetAll();
        }
    }
}
