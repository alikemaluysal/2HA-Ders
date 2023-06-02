using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Service
{
    //Interface
    public interface IService
    {
        void Create();
        void Update();
        void Delete();
        void GetAll();
    }
}
