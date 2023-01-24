using ProductManagement.Classes;
using ProductManagement.Classes.Subclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProductManagement.Classes
{
    public class XmlOperations
    {
        public void SaveProducts(List<PackageProduct> products)
        {
            var serializer = new XmlSerializer(typeof(List<PackageProduct>));
            using (var writer = new StreamWriter("products.xml"))
            {
                serializer.Serialize(writer, products);
            }
        }

        public List<PackageProduct>? LoadProducts()
        {
            var serializer = new XmlSerializer(typeof(List<PackageProduct>));
            using (var reader = new StreamReader("products.xml"))
            {
                return serializer.Deserialize(reader) as List<PackageProduct>;
            }
        }
    }
}
