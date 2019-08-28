using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BL.Controller
{
    public class ProductController:BaseController
    {
        private const string PRODUCTS_PACH_NAME = "Products.dat";

        public List<Model.Product> Products;
        public bool NewProduct = false;
        public ProductController(string name)
        {
            Products = Load<List<Model.Product>>(PRODUCTS_PACH_NAME);
        }

        public void AddNewProduct(Model.Product product)
        {
            Products.Add(product);
            Save(Products, PRODUCTS_PACH_NAME);
            NewProduct = false;
        }
        public void SelectProduct(string name, string password)
        {
            //CurrentProduct = Users.Find(u => u.Name == name).GetUser(password);
        }
    }
}
