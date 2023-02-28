using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress.models
{
    public class ProductQA
    {
        private String Property_TableName = "quality";
        private String Property_Quality = "quality_id";
        private String Property_Name = "name";

        private string qualityCode;
        private string name;

        public string QualityCode
        {
            get { return qualityCode; }
            set { qualityCode = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
