using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class Stores
    {
        string Name;
        string Location;
        int TotalSales;

        public virtual string printLocation() {
            return Location;
        }
    }
}
