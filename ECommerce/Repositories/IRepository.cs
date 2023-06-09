﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repositories
{
    //Generic Repository
    public interface IRepository<T>
    {
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(T entity);
        public List<T> GetAll();
    }
}
