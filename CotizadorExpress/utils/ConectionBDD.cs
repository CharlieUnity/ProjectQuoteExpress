using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotizadorExpress.utils
{
    public class ConectionBDD
    {

        private readonly string connectionString;
        private SqlConnection connection;

        public ConectionBDD(String serverHost, String bddName, String userBdd, String passBdd)
        {
            String connectionString;
            if (serverHost == "" || serverHost == null)
            {
                connectionString = "server=DESKTOP-BIE877C ; database=quote_express ; integrated security = true";
            }
            else {
                connectionString = "Data Source=" + serverHost +";Initial Catalog="  +  bddName +";User ID=" + userBdd+ ";Password="+ passBdd+";";
            }
            this.connectionString = connectionString;
        }

        public void AbrirConexion()
        {
            if (connection == null)
            {
                connection = new SqlConnection(connectionString);
                
               // MessageBox.Show("Abriendo conexión");
            }
            if (connection.State != System.Data.ConnectionState.Open)
            {
                //MessageBox.Show("Conexiòn abierta!!");
                connection.Open();
 

            }
        }

        public void CerrarConexion()
        {
            if (connection != null && connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
                //MessageBox.Show("Conexiòn abierta!!");
            }
        }

        public SqlConnection ObtenerConexion()
        {
            if (connection == null)
            {
                connection = new SqlConnection(connectionString);
                //MessageBox.Show("Conexiòn abierta 2.1 !!");
            }
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
                //MessageBox.Show("Conexiòn abierta 2.2!!");
            }
            return connection;
        }
    }
}
