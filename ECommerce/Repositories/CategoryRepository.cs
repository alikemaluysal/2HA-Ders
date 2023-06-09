using ECommerce.Data;
using ECommerce.Entities;

namespace ECommerce.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        Database _database;
        public CategoryRepository(Database database)
        {
            _database = database;
        }

        public void Add(Category category)
        {
            _database.Categories.Add(category);
            _database.SaveChanges();
        }

        public void Update(Category category)
        {
            _database.Categories.Update(category);
            _database.SaveChanges();
        }

        public void Delete(Category category)
        {
            _database.Categories.Remove(category);
            _database.SaveChanges();
        }


        public List<Category> GetAll()
        {
            return _database.Categories.ToList();
        }
    }
}
