using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress.utils
{
    class RulerBusinessApp
    {


        //Reglas de Negocio
        /*
         * 
            1	Manga Corta
            2	Cuello Mao
            3	Chupin
            4	Cuello común
            5	Manga Larga
            6	común
         
         */

        public double calculateQuote(double priceUnit, int producttype, int producttype2, int quality, int product)
        {
            double totalQuote = 0;
            double priceDiscount = 0;
            double priceDiscount2 = 0;
            double priceStd = 0;
            Boolean calculate = false;
            Boolean calculate2 = false;


            if (product == 1)
            {
                if (producttype == 1)
                {
                    priceDiscount = (priceUnit * 0.10) * -1;
               

                    if (producttype2 == 2)
                    {
                        priceDiscount2 = (priceUnit * 0.03);
                    }
                    priceStd = priceUnit + priceDiscount + priceDiscount2;

                    if (quality == 2)
                    {
                        priceStd = priceStd + (priceStd * 0.30);

                    }
                    calculate = true;
                }

            }

            if (product == 2)
            {
                if (producttype == 3)
                {
                    priceDiscount = (priceUnit * 0.12) * -1;
                }
                priceStd = priceUnit + priceDiscount;

                if (quality == 2)
                {
                    priceStd = priceStd + (priceStd * 0.30);

                }
                calculate2 = true;
            }

            if (calculate || calculate2) {
                totalQuote = priceStd;
            }
            else
            {
                totalQuote = priceUnit;
            }
            

            return totalQuote;

        }

    }
}
