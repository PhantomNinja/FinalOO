using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_2
{
    abstract class Item
    {
        public abstract string PrintLocation();
        public abstract void UpdateStock(int amount);
        public abstract void NewYear();
    }
}
