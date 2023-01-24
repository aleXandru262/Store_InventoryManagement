using ProductManagement.Classes.Subclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Classes
{
    public class Store
    {
        private XmlOperations _xmlOperations = new XmlOperations();
        private List<PackageProduct> _products = new List<PackageProduct>();
        public void AddProduct(PackageProduct product)
        {
            product.Id = TotalProducts+1;

            _products.Add(product);
            _xmlOperations.SaveProducts(_products);
        }

        public void RemoveProduct(int productId)
        {
            _products.RemoveAll(p => p.Id == productId);
            _xmlOperations.SaveProducts(_products);
        }

        public void UpdateProduct(int productId, string name, double price, int quantity, int nrInPackage, double packageWeight)
        {
            var product = _products.FirstOrDefault(p => p.Id == productId);
            if (product != null)
            {
                product.Name = name;
                product.Price = price;
                product.Quantity = quantity;
                product.NumberInPackage = nrInPackage; 
                product.PackWeight = packageWeight;
            }
        }

        public void LoadProducts()
        {
            _products = _xmlOperations.LoadProducts();
        }

        public PackageProduct GetProduct(int productId)
        {
            return _products.FirstOrDefault(p => p.Id == productId);
        }

        public List<PackageProduct> GetAllProducts()
        {
            return _products;
        }

        public int TotalProducts
        {
            get
            { 
                return _products.Count; 
            }
        }
    }
}
