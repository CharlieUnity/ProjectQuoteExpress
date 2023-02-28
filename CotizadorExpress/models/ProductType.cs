using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress.models
{
    public class ProductType
    {
        private String Property_TableName= "producttype";
        private String Property_ProductType = "producttype_id";
        private String Property_Name = "name";


        private string productTypeCode;
        private string name;

        public string ProductTypeCode
        {
            get { return productTypeCode; }
            set { productTypeCode = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
