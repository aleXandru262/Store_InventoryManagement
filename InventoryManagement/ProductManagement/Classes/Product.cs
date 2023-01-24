using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Classes
{
    public class Product
    {
        private int _id;
        private double _price;
        private int _quantity;
        public string? Store { get; set; }
        public string? Name { get; set; }
        public int Id
        {
            get
            { return _id; }
            set
            { _id = value; }
        }
        public double Price
        {
            get
            { return _price; }
            set
            { _price = value; }
        }
        public int Quantity
        {
            get
            { return _quantity; }
            set
            { _quantity = value; }
        }
    }
}
