using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Service
{
    public class BaseService : IService
    {
        public void Create()
        {
            Console.WriteLine("Geçersiz işlem");
        }

        public void Delete()
        {
            Console.WriteLine("Geçersiz işlem");

        }

        public void GetAll()
        {
            Console.WriteLine("Geçersiz işlem");

        }

        public void Update()
        {
            Console.WriteLine("Geçersiz işlem");
        }
    }
}
