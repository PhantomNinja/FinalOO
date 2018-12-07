using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_2
{
    class Sales
    {
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
		private int _soldThisYear;
		public int SoldThisYear
        {
            get
            {
                return _soldThisYear;
            }
			set
            {
                _soldThisYear = value;
            }
        }
        private int _soldLastYear;
		public int SoldLastYear
        {
			get
            {
                return _soldLastYear;
            }
			set
            {
                _soldLastYear = value;
            }
        }		
		void UpdateStock (int Change)
        {
            this._inStock = this._inStock + Change;
            this._soldThisYear = this._soldThisYear + Change;
        }

		void NewYear ()
        {
            this._soldLastYear = this._soldThisYear;
            this._soldThisYear = 0;
        }
    }
}
