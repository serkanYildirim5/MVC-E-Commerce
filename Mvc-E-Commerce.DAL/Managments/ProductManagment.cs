using Mvc_E_Commerce.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_E_Commerce.DAL.Managments
{
   public  class ProductManagment
    {
        private Mvc_E_CommerceContext database;

        public ProductManagment()
        {
            database = new Mvc_E_CommerceContext();
        }

        public Product AddProduct(Product Product)
        {
            return database.Set<Product>().Add(Product);
        }

        public void UpdateProduct(Product Product)
        {
            database.Entry(Product).State = EntityState.Modified;
        }

        public void DeleteProduct(Product Product)
        {
            database.Set<Product>().Remove(Product);
        }

        public void ChangeProduct(Product eskiProduct, Product yeniProduct)
        {
            database.Entry(eskiProduct).CurrentValues.SetValues(yeniProduct);
        }

        public List<Product> GetProduct()
        {
            return database.Set<Product>().ToList();
        }

        public Product GetProductById(int ProductId)
        {
            return database.Set<Product>().FirstOrDefault(u => u.ProductId == ProductId);
        }

        public int ProductChangeSave()
        {
            return database.SaveChanges();
        }
    }
}
