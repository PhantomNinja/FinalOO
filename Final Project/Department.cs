using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Department : Stores
    {
        string Name;
        string Location;
        string[] Items;
        int Total_Sales;

        public override string printLocation()
        {
            return Location;
        }
    }
}
