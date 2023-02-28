using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress.models
{
    public class DetailStock
    {

        public String Property_TableName = "detail_stock";
        public String Property_DetailStock = "detail_stock_id";
        public String Property_Product = "product_id";
        public String Property_ProductType = "producttype_id";
        public String Property_ProductType2 = "producttype2_id";
        public String Property_Quality = "quality_id";
        public String Property_Quantity = "qty";
        public String Property_PriceUnit="price_unit";


        private int stockDetailCode;
        private int productCode;
        private int productTypeCode;
        private int productTypeCode2;
        private int quality;
        private int existingQuantity;
        private decimal unitPrice;

        public int StockDetailCode
        {
            get { return stockDetailCode; }
            set { stockDetailCode = value; }
        }

        public int ProductCode
        {
            get { return productCode; }
            set { productCode = value; }
        }

        public int ProductTypeCode
        {
            get { return productTypeCode; }
            set { productTypeCode = value; }
        }
        public int ProductTypeCode2
        {
            get { return productTypeCode2; }
            set { productTypeCode2 = value; }
        }

        public int ExistingQuantity
        {
            get { return existingQuantity; }
            set { existingQuantity = value; }
        }

        public decimal UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        public int Quality { get => quality; set => quality = value; }
    }
}
