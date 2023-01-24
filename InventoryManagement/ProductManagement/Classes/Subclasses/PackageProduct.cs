using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Classes.Subclasses
{
    public class PackageProduct : Product
    {
        private int _nrInPackage;
        private double _packWeight;
        public int NumberInPackage { 
            get
            { return _nrInPackage; }
            set
            { _nrInPackage = value; }
        }
        public double PackWeight { 
            get
            { return _packWeight; }
            set
            { _packWeight = value; }
        }
    }
}
