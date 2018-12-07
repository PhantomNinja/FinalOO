using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_2
{
    class Clothes_Item : Item
    {
        private string _location;
        public string Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
            }
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private double _price;
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        private int _inStock;
        public int InStock
        {
            get
            {
                return _inStock;
            }
            set
            {
                _inStock = value;
            }
        }

        private int _upc;
        public int Upc
        {
            get
            {
                return _upc;
            }
            set
            {
                _upc = value;
            }
        }

        public override string PrintLocation()
        {
            return 'C' + _location;
        }
    }
}
