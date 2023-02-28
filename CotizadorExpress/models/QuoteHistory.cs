using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress.models
{
    //QuoteHistory

    public class QuoteHistory
    {
        public String Property_TableName = "quote_history";
        public String Property_QuoteHistory = "quote_history_id";
        public String Property_Vendor = "vendor_id";
        public String Property_Product = "product_id";
        public String Property_ProductType = "producttype_id";
        public String Property_ProductType2 = "producttype2_id";
        public String Property_Quality = "quality_id";
        public String Property_QtyQuote = "qty";
        public String Property_PriceUnit = "priceunit";
        public String Property_TotalPrice = "totalprice";
        public String Property_DateQuote = "datequote";


        private int quotationHistoryCode;
        private int vendor;
        private int product;
        private int productType;
        private int productType2;
        private int quality;
        private int quantityQuoted;
        private decimal unitPrice;
        private decimal totalPrice;
        private DateTime quotationDate;

        public int QuotationHistoryCode
        {
            get { return quotationHistoryCode; }
            set { quotationHistoryCode = value; }
        }

        public int Vendor
        {
            get { return vendor; }
            set { vendor = value; }
        }

        public int Product
        {
            get { return product; }
            set { product = value; }
        }

        public int ProductType
        {
            get { return productType; }
            set { productType = value; }
        }

        public int QuantityQuoted
        {
            get { return quantityQuoted; }
            set { quantityQuoted = value; }
        }

        public decimal UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        public decimal TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        public DateTime QuotationDate
        {
            get { return quotationDate; }
            set { quotationDate = value; }
        }

        public int ProductType2 { get => productType2; set => productType2 = value; }
        public int Quality { get => quality; set => quality = value; }
    }

}
