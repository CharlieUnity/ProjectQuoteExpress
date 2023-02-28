using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress.models
{

    public class Vendor
    {
        public string Property_TableName = "vendor";
        public string Property_Vendor = "vendor_id";
        public string Property_Name = "name";
        public string Property_Surname = "surname";
        public string Property_VendorCode = "vendor_code";

        private int vendor_id;
        private string name;
        private string surname;
        private string vendorCode;

        public string VendorCode
        {
            get { return vendorCode; }
            set { vendorCode = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public int VendorID { get => vendor_id; set => vendor_id = value; }
    }
}
