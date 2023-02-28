using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress.models
{
    public class Product
    {
        private String Property_TableName = "product";
        private String Property_Product = "product_id";
        private String Property_Name = "name";

        private string productCode;
        private string name;

        public string ProductCode
        {
            get { return productCode; }
            set { productCode = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
