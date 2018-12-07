using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_2
{
    class Store
    {
        public readonly string Name;
        public readonly string Location;

        public Store()
        {
            this.Name = "Number 1";
            this.Location = "Sioux Falls";
        }

        private string PrintLocation()
        {
            return this.Location;
        }
    }
}
