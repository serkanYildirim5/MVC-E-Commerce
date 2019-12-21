using Mvc_E_Commerce.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_E_Commerce.DAL.Managments
{
    public class CategoryManagment
    {
        private Mvc_E_CommerceContext database;

        public CategoryManagment()
        {
            database = new Mvc_E_CommerceContext();
        }

        public Category AddCategory(Category Category)
        {
            return database.Set<Category>().Add(Category);
        }

        public void UpdateCategory(Category Category)
        {
            database.Entry(Category).State = EntityState.Modified;
        }

        public void DeleteCategory(Category Category)
        {
            database.Set<Category>().Remove(Category);
        }

        public void ChangeCategory(Category eskiCategory, Category yeniCategory)
        {
            database.Entry(eskiCategory).CurrentValues.SetValues(yeniCategory);
        }

        public List<Category> GetCategory()
        {
            return database.Set<Category>().ToList();
        }

        public Category GetCategoryById(int CategoryId)
        {
            return database.Set<Category>().FirstOrDefault(u => u.CategoryId == CategoryId);
        }

        public int CategoryChangeSave()
        {
            return database.SaveChanges();
        }

    }
}
