using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_2
{
    internal class product
    {
		private int product_id;
		public int Product_id // property for product_id
		{
			get { return product_id; }
			set { product_id = value; }
		}

		private string product_name;
		public string Product_name // property for product_name
        {
			get { return product_name; }
			set { product_name = value; }
		}

		private int product_price;
		public int Product_price // property for product_price
        {
			get { return product_price; }
			set { product_price = value; }
		}
		private string unitOfMeasurment;

		public string UnitOfMeasurment // property for unitOfMeasurment
        {
			get { return unitOfMeasurment; }
			set { unitOfMeasurment = value; }
		}
		private decimal product_qty;

		public decimal Product_qty // property for product_qty
        {
			get { return product_qty; }
			set { product_qty = value; }
		}
    }
}
