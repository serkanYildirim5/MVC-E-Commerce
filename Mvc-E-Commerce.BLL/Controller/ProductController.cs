using Mvc_E_Commerce.DAL.Managments;
using Mvc_E_Commerce.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_E_Commerce.BLL.Controller
{
    public class ProductController
    {
        private ProductManagment ProductManagment;

        public ProductController()
        {
            ProductManagment = new ProductManagment();
        }

        public Product AddProduct(Product Product)
        {
            Product addedProduct = null;

            if (Product == null)
                return null;

            if (Product.ProductName.Length>5)
                return null;

            addedProduct = ProductManagment.AddProduct(Product);
            ProductManagment.ProductChangeSave();
            return addedProduct;
        }
        public void UpdateProduct(Product Product, Product yeniProduct)
        {
            if (Product != null && yeniProduct != null)
            {
                ProductManagment.UpdateProduct(Product);
                ProductManagment.ChangeProduct(Product, yeniProduct);
                ProductManagment.ProductChangeSave();
            }
        }
        public void DeleteProduct(Product Product)
        {
            if (Product != null)
            {
                ProductManagment.DeleteProduct(Product);
                ProductManagment.ProductChangeSave();
            }
        }
        public List<Product> GetProducts()
        {
            return ProductManagment.GetProduct();
        }
        public Product GetProductById(int ProductId)
        {
            if (ProductId == 0)
            {
                return null;
            }
            else
            {
                return ProductManagment.GetProductById(ProductId);
            }
        }
    }
}
