using CotizadorExpress.models;
using CotizadorExpress.utils;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CotizadorExpress
{
    public partial class frm_quote : Form
    {
        private int intVendorID = 0;
        private int intproductID = 0;
        private int intproductTypeID = 0;
        private int intproductType2ID = 0;
        private int intqualityID = 0;
        private double qty = 0;
        private double priceUnit = 0;
        private double totalPrice = 0;

        private string strVendorName;
        private string strProductName;
        private string strProductType;
        private string strProductType2;
        private string strQA;
        private string strQty;
        private string strPrice;
        private string strTotalPrice;

        private Vendor vendorSession;
        private List<QuoteHistory> qHistory;

        public frm_quote()
        {
            InitializeComponent();
        }

        private void btn_quote_Click(object sender, EventArgs e)
        {
            updateStock();
            initializeValues();
            initializeAddQuote();
        }

        private void frm_quote_Load(object sender, EventArgs e)
        {

            loadDataComboBox();
            initializeGridHeadres();
            initializeAddQuote();
            initializeValues();
            enabledControls(false);
        }

        private void btn_add_quote_Click(object sender, EventArgs e)
        {
            int stockActual = int.Parse(lbl_stock.Text.ToString());
            int qtyQuote = int.Parse(txt_qty.Text.ToString());
            double priceQuote = double.Parse(txt_price_unit.Text.ToString());
            String MsgBoxText=null;

            int intProductName = 0;
            getValueComboBox();


            if (stockActual==0 && (intproductID != 0)) {
                MessageBox.Show("No se puede realizar la cotización debido a que no hay suficiente stock de la prenda " + strProductName);
            } else {

                if (intproductID == 0) {
                    MsgBoxText = "Seleccione una prenda para continuar con la cotización";
                }

                if (qtyQuote > stockActual && intproductID!=0) {
                    MsgBoxText = MsgBoxText + ("La cantidad ingresada debe ser menor o igual al stock disponible. ");
                }
                if (qtyQuote ==0 && intproductID != 0)
                {
                    MsgBoxText = MsgBoxText +("Ingrese la cantidad a cotizar. ");
                }

                if (priceUnit == 0 && intproductID != 0)
                {
                    MsgBoxText = MsgBoxText + ("Ingrese el precio para continuar con la cotización. ");
                }

                if (stockActual == 0 && intproductID != 0)
                {
                    MsgBoxText = MsgBoxText + ("Stock insuficiente para la prenda " + strProductName);
                }


                if (priceQuote > 0 && (qtyQuote > 0 && qtyQuote <= stockActual && stockActual > 0) && intproductID != 0)
                {
                    addQuote();
                    initializeValues();
                }
                else {
                    if (MsgBoxText != null) {
                        MessageBox.Show(MsgBoxText);
                    }
                }
                
            }
            
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número o el punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                // Cancelar el evento de teclado para evitar que se ingrese el carácter
                e.Handled = true;
            }

            // Permitir solo un punto decimal en el TextBox
            if (e.KeyChar == '.' && (sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1)
            {
                // Cancelar el evento de teclado para evitar que se ingrese el segundo punto decimal
                e.Handled = true;
            }
        }

        private void btn_search_vendor_Click(object sender, EventArgs e)
        {
            loginVendor();
        }

        private void cbo_product_SelectionChangeCommitted(object sender, EventArgs e)
        {

            actualStock();
            changeCalculateQuote();

        }
        private void cbo_product_type_SelectionChangeCommitted(object sender, EventArgs e)
        {
            actualStock();
            changeCalculateQuote();
        }

        private void cbo_product_type2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            actualStock();
            changeCalculateQuote();
        }

        private void cbo_qa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            actualStock();
            changeCalculateQuote();
        }

        private void grd_quote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (grd_quote.SelectedRows.Count > 0)
                {

                    if (grd_quote.CurrentRow.Index != grd_quote.Rows.Count - 1)
                    {
                        grd_quote.Rows.RemoveAt(grd_quote.SelectedRows[0].Index);

                        int idxRow = (grd_quote.SelectedRows[0].Index);
                        qHistory.RemoveAt(idxRow);
                    }

                }
            }
        }

        private void txt_price_unit_TextChanged(object sender, EventArgs e)
        {
            changeCalculateQuote();

        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            changeCalculateQuote();
        }



        public void initializeAddQuote() {
            qHistory = new List<QuoteHistory>();
            grd_quote.Rows.Clear();
            grd_quote.Rows[0].ReadOnly = true;
        }
        public void initializeGridHeadres() {


            DataGridViewTextBoxColumn columnaVendedor = new DataGridViewTextBoxColumn();
            columnaVendedor.HeaderText = "Vendedor";
            columnaVendedor.Name = "vendor";
            grd_quote.Columns.Add(columnaVendedor);

            DataGridViewTextBoxColumn columnaFecha = new DataGridViewTextBoxColumn();
            columnaFecha.HeaderText = "Fecha";
            columnaFecha.Name = "datequote";
            grd_quote.Columns.Add(columnaFecha);


            DataGridViewTextBoxColumn columnaPrenda = new DataGridViewTextBoxColumn();
            columnaPrenda.HeaderText = "Prenda";
            columnaPrenda.Name = "product";
            grd_quote.Columns.Add(columnaPrenda);

            DataGridViewTextBoxColumn columnaTipoPrenda = new DataGridViewTextBoxColumn();
            columnaTipoPrenda.HeaderText = "Tipo de prenda";
            columnaTipoPrenda.Name = "producttype";
            grd_quote.Columns.Add(columnaTipoPrenda);


            DataGridViewTextBoxColumn columnaTipoPrenda2 = new DataGridViewTextBoxColumn();
            columnaTipoPrenda2.HeaderText = "Tipo de prenda 2";
            columnaTipoPrenda2.Name = "producttype2";
            grd_quote.Columns.Add(columnaTipoPrenda2);

            DataGridViewTextBoxColumn columnaQA = new DataGridViewTextBoxColumn();
            columnaQA.HeaderText = "QA";
            columnaQA.Name = "qa";
            grd_quote.Columns.Add(columnaQA);

            DataGridViewTextBoxColumn columnaCantidad = new DataGridViewTextBoxColumn();
            columnaCantidad.HeaderText = "Cantidad";
            columnaCantidad.Name = "quantity";
            grd_quote.Columns.Add(columnaCantidad);

            DataGridViewTextBoxColumn columnaPrecio = new DataGridViewTextBoxColumn();
            columnaPrecio.HeaderText = "Precio";
            columnaPrecio.Name = "price";
            grd_quote.Columns.Add(columnaPrecio);


            DataGridViewTextBoxColumn columnaTotalCotizacion = new DataGridViewTextBoxColumn();
            columnaTotalCotizacion.HeaderText = "Total Cotización";
            columnaTotalCotizacion.Name = "total";
            grd_quote.Columns.Add(columnaTotalCotizacion);

        }
        public void initializeValues() {


            lbl_stock.ForeColor = Color.Blue;
            lbl_TotalQuote.ForeColor = Color.Green;
            lbl_sign_dolar.ForeColor = Color.Green;
            lbl_stock.Text = "0";
            lbl_TotalQuote.Text = "0.00";
            txt_price_unit.Text = "0";
            txt_qty.Text = "0";

            cbo_product.Text = "";
            cbo_product_type.Text = "";
            cbo_product_type2.Text = "";
            cbo_qa.Text = "";

            intVendorID = 0;
            intproductID = 0;
            intproductTypeID = 0;
            intproductType2ID = 0;
            intqualityID = 0;
            qty = 0;
            priceUnit = 0;
            totalPrice = 0;

            strVendorName="";
            strProductName = "";
            strProductType = "";
            strProductType2 = "";
            strQA = "";
            strQty = "";
            strPrice = "";
            strTotalPrice = "";

    }

        public void loadDataComboBox() {
            ConectionBDD connBDD = new ConectionBDD(null, null, null, null);

            //connBDD.AbrirConexion();
            SqlConnection connection = connBDD.ObtenerConexion();

            DataBDD dbConnection = new DataBDD(connection);

            Object[,] objtData = dbConnection.getDataEntity("Product");

            for (int i = 0; i < objtData.GetLength(0); i++)
            {
                cbo_product.Items.Add(new KeyValuePair<object, object>(objtData[i, 0], objtData[i, 1]));
            }
            cbo_product.DisplayMember = "Value";
            cbo_product.ValueMember = "Key";
            connBDD.CerrarConexion();
            //connBDD.AbrirConexion();
            connection = connBDD.ObtenerConexion();

            dbConnection = new DataBDD(connection);


            objtData = dbConnection.getDataEntity("ProductType");

            for (int i = 0; i < objtData.GetLength(0); i++)
            {
                cbo_product_type.Items.Add(new KeyValuePair<object, object>(objtData[i, 0], objtData[i, 1]));
            }
            cbo_product_type.DisplayMember = "Value";
            cbo_product_type.ValueMember = "Key";

            for (int i = 0; i < objtData.GetLength(0); i++)
            {
                cbo_product_type2.Items.Add(new KeyValuePair<object, object>(objtData[i, 0], objtData[i, 1]));
            }
            cbo_product_type2.DisplayMember = "Value";
            cbo_product_type2.ValueMember = "Key";


            connBDD.CerrarConexion();
            //connBDD.AbrirConexion();
            connection = connBDD.ObtenerConexion();

            dbConnection = new DataBDD(connection);


            objtData = dbConnection.getDataEntity("quality");

            for (int i = 0; i < objtData.GetLength(0); i++)
            {
                cbo_qa.Items.Add(new KeyValuePair<object, object>(objtData[i, 0], objtData[i, 1]));
            }
            cbo_qa.DisplayMember = "Value";
            cbo_qa.ValueMember = "Key";
            connBDD.CerrarConexion();
        }

        public void getValueComboBox()
        {
            KeyValuePair<object, object> seleccionado;

            if (cbo_product.SelectedItem != null)
            {

                seleccionado = (KeyValuePair<object, object>)cbo_product.SelectedItem;
                //MessageBox.Show(seleccionado.Key.ToString());
                intproductID = int.Parse(seleccionado.Key.ToString());
                strProductName = seleccionado.Value.ToString();

            }

            if (cbo_product_type.SelectedItem != null)
            {

                seleccionado = (KeyValuePair<object, object>)cbo_product_type.SelectedItem;
                //MessageBox.Show(seleccionado.Key.ToString());
                intproductTypeID = int.Parse(seleccionado.Key.ToString());
                strProductType = seleccionado.Value.ToString();
            }

            if (cbo_product_type2.SelectedItem != null)
            {

                seleccionado = (KeyValuePair<object, object>)cbo_product_type2.SelectedItem;
                //MessageBox.Show(seleccionado.Key.ToString());
                intproductType2ID = int.Parse(seleccionado.Key.ToString());
                strProductType2 = seleccionado.Value.ToString();
            }

            if (cbo_qa.SelectedItem != null)
            {

                seleccionado = (KeyValuePair<object, object>)cbo_qa.SelectedItem;
                //MessageBox.Show(seleccionado.Key.ToString());
                intqualityID = int.Parse(seleccionado.Key.ToString());
                strQA = seleccionado.Value.ToString();
            }

        }
        
        public void addQuote()
        {


            RulerBusinessApp dbConnection2 = new RulerBusinessApp();

            getValueComboBox();

            qty = double.Parse(txt_qty.Text.ToString());
            priceUnit = double.Parse(txt_price_unit.Text.ToString());
            totalPrice = dbConnection2.calculateQuote((priceUnit * qty), intproductTypeID, intproductType2ID, intqualityID, intproductID);

            if (totalPrice > 0)
            {
                int rowCount = grd_quote.RowCount;
                //MessageBox.Show(rowCount.ToString());
                DateTime fecha = DateTime.Now;
                string dateString = fecha.ToString("yyyy-MM-dd");
                if (rowCount == 1)
                {
                    rowCount = 0;
                }
                else
                {
                    rowCount--;

                }
                strQty = qty.ToString();
                strPrice = priceUnit.ToString();
                strTotalPrice = totalPrice.ToString();
                grd_quote.Rows.Add();
                grd_quote.Rows[rowCount].Cells["vendor"].Value = vendorSession.VendorCode.ToString();
                grd_quote.Rows[rowCount].Cells["datequote"].Value = dateString;
                grd_quote.Rows[rowCount].Cells["product"].Value = strProductName;
                grd_quote.Rows[rowCount].Cells["producttype"].Value = strProductType;
                grd_quote.Rows[rowCount].Cells["producttype2"].Value = strProductType2;
                grd_quote.Rows[rowCount].Cells["qa"].Value = strQA;
                grd_quote.Rows[rowCount].Cells["quantity"].Value = strQty;
                grd_quote.Rows[rowCount].Cells["price"].Value = strPrice;
                grd_quote.Rows[rowCount].Cells["total"].Value = strTotalPrice;

                lbl_TotalQuote.Text = "$ " + totalPrice.ToString();

                QuoteHistory qh = new QuoteHistory();
                qh.Product = intproductID;
                qh.ProductType = intproductTypeID;
                qh.ProductType2 = intproductType2ID;
                qh.Vendor = vendorSession.VendorID;
                qh.Quality = intqualityID;
                qh.QuantityQuoted = int.Parse(strQty);
                qh.UnitPrice = decimal.Parse(strPrice);
                qh.TotalPrice = decimal.Parse(strTotalPrice);

                DateTime dt = DateTime.Parse(dateString);
                qh.QuotationDate = dt;
                qHistory.Add(qh);


            }
            else
            {
                lbl_TotalQuote.Text = "$ 0.00";
            }


        }


        public void loginVendor() {
 
            // Crear el objeto MessageBoxInputDialog
            MessageBoxInputDialog inputDialog = new MessageBoxInputDialog("Ingrese el codigo de vendedor:");

            // Mostrar la ventana de diálogo
            DialogResult result = inputDialog.ShowDialog();

            // Comprobar el resultado del cuadro de diálogo
            if (result == DialogResult.OK)
            {
                string strVendorCode = inputDialog.InputValue;


                ConectionBDD connBDD = new ConectionBDD(null, null, null, null);

                //connBDD.AbrirConexion();
                SqlConnection connection = connBDD.ObtenerConexion();

                DataBDD dbConnection = new DataBDD(connection);
                //DataBDD dbConnection = new DataBDD(connBDD);


                vendorSession = dbConnection.getVendorByCode(strVendorCode);



                connBDD.CerrarConexion();

                if (vendorSession.VendorCode != null)
                {
                    MessageBox.Show("Bienvenido, " + vendorSession.Name + "!");

                    lbl_code_vendor.Text = strVendorCode;
                    lbl_name_vendor.Text = vendorSession.Name + " " + vendorSession.Surname;

                    enabledControls(true);
                }
                else { 

                    enabledControls(false);
                    MessageBox.Show("Usuario no encontrado.");
                }
            }
            else
            {
                enabledControls(false);
                MessageBox.Show("Ingreso cancelado.");
            }
        }

        public void enabledControls(Boolean blEnabled){

            cbo_product.Enabled = blEnabled;
            cbo_product_type.Enabled = blEnabled;
            cbo_product_type2.Enabled = blEnabled;
            cbo_qa.Enabled = blEnabled;
            btn_add_quote.Enabled = blEnabled;
            btn_quote.Enabled = blEnabled;
            txt_price_unit.Enabled = blEnabled;
            txt_qty.Enabled = blEnabled;
        }


        // en construcciòn
        public void addVendor() {

            ConectionBDD connBDD = new ConectionBDD(null, null, null, null);

            //connBDD.AbrirConexion();
            SqlConnection connection = connBDD.ObtenerConexion();

            DataBDD dbConnection = new DataBDD(connection);
            //DataBDD dbConnection = new DataBDD(connBDD);

            Vendor newVendor = new Vendor();
            int codigo = 1;
            //newVendor.VendorID = codigo;
            newVendor.Name = "Juan";
            newVendor.Surname = "Perez";
            newVendor.VendorCode = "001JP";
            dbConnection.insertVendor(newVendor);
            connBDD.CerrarConexion();
            //String strInsert= dbConnection.insertVendorString(newVendor);
            //txt_SQL.Text = strInsert;
            //MessageBox.Show(strInsert);

        }


        public void actualStock() {

            int actualStock = 0;
            getValueComboBox();
            /*MessageBox.Show(intproductID.ToString() +
                intproductTypeID.ToString()+
                intproductType2ID.ToString() +
                intqualityID.ToString() 
                );*/
            if (intproductID != 0 && intproductType2ID != 0 && intproductTypeID != 0 && intqualityID != 0)
            {
                ConectionBDD connBDD = new ConectionBDD(null, null, null, null);
                SqlConnection connection = connBDD.ObtenerConexion();

                DataBDD dbConnection = new DataBDD(connection);

                actualStock = dbConnection.getStock(intproductID, intproductTypeID, intproductType2ID, intqualityID);
                connBDD.CerrarConexion();
                if (actualStock == 0)
                {
                    lbl_stock.ForeColor = Color.Red;
                }
                else
                {
                    lbl_stock.ForeColor = Color.Blue;
                }

            }
            else {
                lbl_stock.ForeColor = Color.Red;
            }
           
            lbl_stock.Text = actualStock.ToString();

        }

        private void cbo_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        public void changeCalculateQuote() {


            if (vendorSession != null) { 
                RulerBusinessApp dbConnection2 = new RulerBusinessApp();
                qty = double.Parse(txt_qty.Text.ToString());
                priceUnit = double.Parse(txt_price_unit.Text.ToString());
                totalPrice = dbConnection2.calculateQuote((priceUnit * qty), intproductTypeID, intproductType2ID, intqualityID, intproductID);

                if (totalPrice > 0 && qty>0 && priceUnit>0) {
                    lbl_TotalQuote.Text = totalPrice.ToString();
                }
                else
                {
                    lbl_TotalQuote.Text = "0";
                }
            }

        }



        public void updateStock()
        {

            ConectionBDD connBDD = new ConectionBDD(null, null, null, null);

            //connBDD.AbrirConexion();
            SqlConnection connection = connBDD.ObtenerConexion();

            DataBDD dbConnection = new DataBDD(connection);
            //DataBDD dbConnection = new DataBDD(connBDD);
 
            foreach (QuoteHistory qh in qHistory) {
                dbConnection.insertQuote(qh);
            }
            
            connBDD.CerrarConexion();
            //String strInsert= dbConnection.insertVendorString(newVendor);
            //txt_SQL.Text = strInsert;
            //MessageBox.Show(strInsert);

        }

        private void btn_history_quote_Click(object sender, EventArgs e)
        {
            
            if (vendorSession != null && vendorSession.VendorCode!=null) { 
                DataGridViewDialog dgridHisotry = new DataGridViewDialog(vendorSession.VendorCode);
                dgridHisotry.ShowDialog();
            }
        }
    }
}
