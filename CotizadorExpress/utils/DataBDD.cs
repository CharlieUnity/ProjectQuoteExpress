using CotizadorExpress.models;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System;
using System.Collections.Generic;

namespace CotizadorExpress.utils
{
    public class DataBDD 
    {
        private SqlConnection connection;
        private string strSQLInsert="";
        private SqlCommand commandSQL;

        ConectionBDD conn_BDD;


        public DataBDD(SqlConnection connection) {
            this.connection = connection;
        }
        
        public DataBDD(ConectionBDD connBDD)
        {
            this.conn_BDD = connBDD;

        }

        public void insertVendor(Vendor insertVendor) {

            //conn_BDD.AbrirConexion();
            //connection = conn_BDD.ObtenerConexion();


            strSQLInsert = "insert into "+ insertVendor.Property_TableName + "(" +
                //insertVendor.Property_Vendor + "," +
                insertVendor.Property_Name + "," +
                insertVendor.Property_Surname + "," +
                insertVendor.Property_VendorCode + "" +
                ")"+
                "values(" //+  insertVendor.VendorID
                + "'" +
                insertVendor.Name + "','" +
                insertVendor.Surname + "','" +
                insertVendor.VendorCode + "'" +
                ")"
                ;
            //MessageBox.Show("Se inserto:" + strSQLInsert + " fila(s).");

            System.Console.WriteLine(strSQLInsert);

            // Crear el comando con el insert
            commandSQL = new SqlCommand(strSQLInsert, connection);
            // Ejecutar el insert
            int rowsAffected = commandSQL.ExecuteNonQuery();

            connection.Close();
        }

        public Vendor getVendorByCode(string vendorCode)
        {

            Object resultOBJ = null;
            Vendor vendor = new Vendor();
            //connection.Open();
            String strSQL = "select " +

                vendor.Property_Vendor + "," +
                vendor.Property_Name + "," +
                vendor.Property_Surname + "," +
                vendor.Property_VendorCode + 
                " from vendor where " +  vendor.Property_VendorCode + "='" + vendorCode + "'";

            SqlCommand command = new SqlCommand(strSQL, connection);

            SqlDataReader reader = command.ExecuteReader();

 
 
            // Leer los resultados y almacenarlos en la matriz
            int i = 0;
            while (reader.Read())
            {
                vendor.VendorID = int.Parse(reader.GetValue(0).ToString());
                vendor.Name = (reader.GetValue(1).ToString());
                vendor.Surname = (reader.GetValue(2).ToString());
                vendor.VendorCode = (reader.GetValue(3).ToString());

            }

            return vendor;

        }



        public Object[,] getDataEntity(string strTableName) {

            Object resultOBJ = null;
            int TotalRows = getTotalLines(strTableName);

            //connection.Open();
            String strSQL = "select * from " + strTableName;
            SqlCommand command = new SqlCommand(strSQL, connection);

            SqlDataReader reader = command.ExecuteReader();

            // Obtener la cantidad de columnas en el resultado
            int numColumns = reader.FieldCount;



            //int numColumns = reader.HasRows;
            // Crear una matriz para almacenar los resultados
            object[,] results = new object[TotalRows, numColumns];

            // Leer los resultados y almacenarlos en la matriz
            int i = 0;
            while (reader.Read())
            {
                for (int j = 0; j < numColumns; j++)
                {
                    results[i, j] = reader.GetValue(j);
                }
                i++;
            }

   
            return results;

        }

        public int getTotalLines(string strTableName) {
            int totalRows = 0;

            //connection.Open();
            String strSQL = "select count(*) as total_rows from " + strTableName;
            SqlCommand command = new SqlCommand(strSQL, connection);

            SqlDataReader reader = command.ExecuteReader();

            Boolean blRows = reader.HasRows;

            int intTotalRows = 0;
            // Leer los resultados y almacenarlos en la matriz
            int i = 0;
            while (reader.Read())
            {
                totalRows = int.Parse(reader.GetValue(i).ToString());
            }
            reader.Close();

            //connection.Close();

           // MessageBox.Show(totalRows.ToString());
            return totalRows;
        }



        public int getStock(int productID, int productType, int productType2, int qaID)
        {
            int stockProduct = 0;

            Object resultOBJ = null;
            DetailStock dStock = new DetailStock();
            //connection.Open();
            String strSQL = "select " +

                dStock.Property_Quantity +
                " from "+ dStock.Property_TableName +
                " where " + dStock.Property_Product + "=" + productID.ToString() +  
                " and " + dStock.Property_ProductType + "=" + productType.ToString() +
                " and " + dStock.Property_Quality + "=" + qaID.ToString() 
                ;

            if (productID==1) {
                strSQL= strSQL+ " and " + dStock.Property_ProductType2 + "=" + productType2.ToString();
            }

            SqlCommand command = new SqlCommand(strSQL, connection);

            SqlDataReader reader = command.ExecuteReader();



            // Leer los resultados y almacenarlos en la matriz
            int i = 0;
            while (reader.Read())
            {
                stockProduct = int.Parse(reader.GetValue(0).ToString());
 
            }


            return stockProduct;
        }


        public void insertQuote(QuoteHistory quotehistory)
        {

            //conn_BDD.AbrirConexion();
            //connection = conn_BDD.ObtenerConexion();


            strSQLInsert = "insert into " + quotehistory.Property_TableName + "(" +
                //insertVendor.Property_Vendor + "," +
                quotehistory.Property_Vendor + "," +
                quotehistory.Property_Product + "," +
                quotehistory.Property_ProductType + "," +
                quotehistory.Property_ProductType2 + "," +
                quotehistory.Property_Quality + "," +
                quotehistory.Property_QtyQuote + "," +
                quotehistory.Property_PriceUnit + "," +
                quotehistory.Property_TotalPrice + "," +
                quotehistory.Property_DateQuote  +
                ")" +
                "values(" + //+  insertVendor.VendorID
                quotehistory.Vendor + "," +
                quotehistory.Product + "," +
                quotehistory.ProductType + "," +
                quotehistory.ProductType2 + "," +
                quotehistory.Quality + "," +
                quotehistory.QuantityQuoted + "," +
                quotehistory.UnitPrice + "," +
                quotehistory.TotalPrice.ToString().Replace(",",".") + ",'" +
                quotehistory.QuotationDate.ToString("yyyy-MM-dd") + "'" +
                ")"
                ;

            Console.WriteLine(strSQLInsert);

            

            // Crear el comando con el insert
            commandSQL = new SqlCommand(strSQLInsert, connection);
            // Ejecutar el insert
            int rowsAffected = commandSQL.ExecuteNonQuery();

           // MessageBox.Show("Se inserto:" + rowsAffected + " fila(s).");


            if (rowsAffected > 0) {
                DetailStock dStock = new DetailStock();
                strSQLInsert = "update " + dStock.Property_TableName +
                    " set qty=qty-" + quotehistory.QuantityQuoted +
                    " where " + dStock.Property_Product + " = " + quotehistory.Product +
                    " and " + dStock.Property_ProductType + " = " + quotehistory.ProductType +
                    " and " + dStock.Property_Quality + " = " + quotehistory.Quality 
                    ;

                if (quotehistory.Product==1) {
                    strSQLInsert = strSQLInsert + " and " + dStock.Property_ProductType2 + " = " + quotehistory.ProductType2;
                }

                commandSQL = new SqlCommand(strSQLInsert, connection);
                // Ejecutar el insert
                rowsAffected = commandSQL.ExecuteNonQuery();

            }
            connection.Close();
        }

    }
}
