using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Data.SqlClient;
namespace CotizadorExpress.utils
{
    public class DataGridViewDialog : Form
    {
        private DataGridView dataGridView1;
       // private DataGridView dataGridView;

        public DataGridViewDialog(string vendorCode)
        {
            InitializeComponent();
            LoadData(vendorCode);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(711, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DataGridViewDialog
            // 
            this.ClientSize = new System.Drawing.Size(767, 353);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataGridViewDialog";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

           

        }

        private void LoadData(string vendorCode)
        {

            ConectionBDD connBDD = new ConectionBDD(null, null, null, null);

            //connBDD.AbrirConexion();
            SqlConnection connection = connBDD.ObtenerConexion();

            DataBDD dbConnection = new DataBDD(connection);
            // Conexión a la base de datos
            // Consulta SQL
            string query = "SELECT vendor as Vendedor, datequote as Fecha, product as Prenda, type1 as TipoPrenda1, type2 as TipoPrenda2, quality as Calidad, qtyquote as Cantidad, priceunit as Precio_Unitario, totalquote as Total_Cotizado " +
                           "FROM quotehistory_v " +
                           "WHERE vendor_code = @vendorCode"
                           ;

            // Creación del comando
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@vendorCode", vendorCode);

            // Adaptador de datos y DataSet
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();

            // Llenado del DataSet
            adapter.Fill(dataSet);

            // Asignación del DataSet al DataGridView
            dataGridView1.DataSource = dataSet.Tables[0];
            dataGridView1.AllowUserToDeleteRows = false;
            connBDD.CerrarConexion();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
