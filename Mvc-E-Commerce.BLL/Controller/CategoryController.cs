using Mvc_E_Commerce.DAL.Managments;
using Mvc_E_Commerce.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_E_Commerce.BLL.Controller
{
    public class CategoryController
    {
        private CategoryManagment CategoryManagment;

        public CategoryController()
        {
            CategoryManagment = new CategoryManagment();
        }

        public Category AddCategory(Category Category)
        {
            Category addedCategory = null;

            if (Category == null)
                return null;

            if (Category.CategoryName.Length>5)
                return null;

            addedCategory = CategoryManagment.AddCategory(Category);
            CategoryManagment.CategoryChangeSave();
            return addedCategory;
        }
        public void UpdateCategory(Category Category, Category yeniCategory)
        {
            if (Category != null && yeniCategory != null)
            {
                CategoryManagment.UpdateCategory(Category);
                CategoryManagment.ChangeCategory(Category, yeniCategory);
                CategoryManagment.CategoryChangeSave();
            }
        }
        public void DeleteCategory(Category Category)
        {
            if (Category != null)
            {
                CategoryManagment.DeleteCategory(Category);
                CategoryManagment.CategoryChangeSave();
            }
        }
        public List<Category> GetCategorys()
        {
            return CategoryManagment.GetCategory();
        }
        public Category GetCategoryById(int CategoryId)
        {
            if (CategoryId == 0)
            {
                return null;
            }
            else
            {
                return CategoryManagment.GetCategoryById(CategoryId);
            }
        }
    }
}
