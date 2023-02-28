namespace CotizadorExpress
{
    partial class frm_quote
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_title_shop = new System.Windows.Forms.Label();
            this.lbl_shop_address = new System.Windows.Forms.Label();
            this.lbl_code_vendor = new System.Windows.Forms.Label();
            this.lbl_name_vendor = new System.Windows.Forms.Label();
            this.lbl_description_shirt = new System.Windows.Forms.Label();
            this.lbl_title_stock = new System.Windows.Forms.Label();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.txt_price_unit = new System.Windows.Forms.TextBox();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.btn_quote = new System.Windows.Forms.Button();
            this.lbl_TotalQuote = new System.Windows.Forms.Label();
            this.txt_SQL = new System.Windows.Forms.TextBox();
            this.cbo_product = new System.Windows.Forms.ComboBox();
            this.cbo_product_type = new System.Windows.Forms.ComboBox();
            this.cbo_product_type2 = new System.Windows.Forms.ComboBox();
            this.cbo_qa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grd_quote = new System.Windows.Forms.DataGridView();
            this.btn_add_quote = new System.Windows.Forms.Button();
            this.lbl_title_price = new System.Windows.Forms.Label();
            this.lbl_title_qty = new System.Windows.Forms.Label();
            this.btn_search_vendor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_history_quote = new System.Windows.Forms.Button();
            this.lbl_sign_dolar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd_quote)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Cursor = System.Windows.Forms.Cursors.No;
            this.lbl_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lbl_title.Location = new System.Drawing.Point(96, -2);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(578, 76);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Cotizador Express";
            // 
            // lbl_title_shop
            // 
            this.lbl_title_shop.AutoSize = true;
            this.lbl_title_shop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_title_shop.Location = new System.Drawing.Point(33, 74);
            this.lbl_title_shop.Name = "lbl_title_shop";
            this.lbl_title_shop.Size = new System.Drawing.Size(224, 31);
            this.lbl_title_shop.TabIndex = 1;
            this.lbl_title_shop.Text = "ShopMiniExpress";
            // 
            // lbl_shop_address
            // 
            this.lbl_shop_address.AutoSize = true;
            this.lbl_shop_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_shop_address.Location = new System.Drawing.Point(575, 74);
            this.lbl_shop_address.Name = "lbl_shop_address";
            this.lbl_shop_address.Size = new System.Drawing.Size(203, 31);
            this.lbl_shop_address.TabIndex = 2;
            this.lbl_shop_address.Text = "Quito - Ecuador";
            // 
            // lbl_code_vendor
            // 
            this.lbl_code_vendor.AutoSize = true;
            this.lbl_code_vendor.Location = new System.Drawing.Point(210, 113);
            this.lbl_code_vendor.Name = "lbl_code_vendor";
            this.lbl_code_vendor.Size = new System.Drawing.Size(25, 13);
            this.lbl_code_vendor.TabIndex = 3;
            this.lbl_code_vendor.Text = "      ";
            // 
            // lbl_name_vendor
            // 
            this.lbl_name_vendor.AutoSize = true;
            this.lbl_name_vendor.Location = new System.Drawing.Point(329, 114);
            this.lbl_name_vendor.Name = "lbl_name_vendor";
            this.lbl_name_vendor.Size = new System.Drawing.Size(19, 13);
            this.lbl_name_vendor.TabIndex = 4;
            this.lbl_name_vendor.Text = "    ";
            // 
            // lbl_description_shirt
            // 
            this.lbl_description_shirt.AutoSize = true;
            this.lbl_description_shirt.Location = new System.Drawing.Point(379, 173);
            this.lbl_description_shirt.Name = "lbl_description_shirt";
            this.lbl_description_shirt.Size = new System.Drawing.Size(236, 13);
            this.lbl_description_shirt.TabIndex = 10;
            this.lbl_description_shirt.Text = "Esta camisa incluye: manga larga y cuelo común";
            // 
            // lbl_title_stock
            // 
            this.lbl_title_stock.AutoSize = true;
            this.lbl_title_stock.Location = new System.Drawing.Point(31, 311);
            this.lbl_title_stock.Name = "lbl_title_stock";
            this.lbl_title_stock.Size = new System.Drawing.Size(154, 13);
            this.lbl_title_stock.TabIndex = 11;
            this.lbl_title_stock.Text = "Unidades de stock disponibles:";
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_stock.Location = new System.Drawing.Point(200, 306);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(20, 22);
            this.lbl_stock.TabIndex = 12;
            this.lbl_stock.Text = "0";
            // 
            // txt_price_unit
            // 
            this.txt_price_unit.Location = new System.Drawing.Point(314, 311);
            this.txt_price_unit.Name = "txt_price_unit";
            this.txt_price_unit.Size = new System.Drawing.Size(100, 20);
            this.txt_price_unit.TabIndex = 15;
            this.txt_price_unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_price_unit.TextChanged += new System.EventHandler(this.txt_price_unit_TextChanged);
            this.txt_price_unit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(439, 311);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(100, 20);
            this.txt_qty.TabIndex = 16;
            this.txt_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_qty.TextChanged += new System.EventHandler(this.txt_qty_TextChanged);
            this.txt_qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // btn_quote
            // 
            this.btn_quote.Location = new System.Drawing.Point(27, 525);
            this.btn_quote.Name = "btn_quote";
            this.btn_quote.Size = new System.Drawing.Size(156, 42);
            this.btn_quote.TabIndex = 19;
            this.btn_quote.Text = "Ejecutar Cotización";
            this.btn_quote.UseVisualStyleBackColor = true;
            this.btn_quote.Click += new System.EventHandler(this.btn_quote_Click);
            // 
            // lbl_TotalQuote
            // 
            this.lbl_TotalQuote.AutoSize = true;
            this.lbl_TotalQuote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_TotalQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lbl_TotalQuote.Location = new System.Drawing.Point(453, 343);
            this.lbl_TotalQuote.Name = "lbl_TotalQuote";
            this.lbl_TotalQuote.Size = new System.Drawing.Size(34, 38);
            this.lbl_TotalQuote.TabIndex = 20;
            this.lbl_TotalQuote.Text = "0";
            // 
            // txt_SQL
            // 
            this.txt_SQL.Location = new System.Drawing.Point(27, 573);
            this.txt_SQL.Name = "txt_SQL";
            this.txt_SQL.Size = new System.Drawing.Size(623, 20);
            this.txt_SQL.TabIndex = 21;
            this.txt_SQL.Visible = false;
            // 
            // cbo_product
            // 
            this.cbo_product.FormattingEnabled = true;
            this.cbo_product.Location = new System.Drawing.Point(34, 182);
            this.cbo_product.Name = "cbo_product";
            this.cbo_product.Size = new System.Drawing.Size(237, 21);
            this.cbo_product.TabIndex = 22;
            this.cbo_product.SelectedIndexChanged += new System.EventHandler(this.cbo_product_SelectedIndexChanged);
            this.cbo_product.SelectionChangeCommitted += new System.EventHandler(this.cbo_product_SelectionChangeCommitted);
            // 
            // cbo_product_type
            // 
            this.cbo_product_type.FormattingEnabled = true;
            this.cbo_product_type.Location = new System.Drawing.Point(34, 227);
            this.cbo_product_type.Name = "cbo_product_type";
            this.cbo_product_type.Size = new System.Drawing.Size(237, 21);
            this.cbo_product_type.TabIndex = 23;
            this.cbo_product_type.SelectionChangeCommitted += new System.EventHandler(this.cbo_product_type_SelectionChangeCommitted);
            // 
            // cbo_product_type2
            // 
            this.cbo_product_type2.FormattingEnabled = true;
            this.cbo_product_type2.Location = new System.Drawing.Point(292, 227);
            this.cbo_product_type2.Name = "cbo_product_type2";
            this.cbo_product_type2.Size = new System.Drawing.Size(237, 21);
            this.cbo_product_type2.TabIndex = 24;
            this.cbo_product_type2.SelectionChangeCommitted += new System.EventHandler(this.cbo_product_type2_SelectionChangeCommitted);
            // 
            // cbo_qa
            // 
            this.cbo_qa.FormattingEnabled = true;
            this.cbo_qa.Location = new System.Drawing.Point(34, 270);
            this.cbo_qa.Name = "cbo_qa";
            this.cbo_qa.Size = new System.Drawing.Size(237, 21);
            this.cbo_qa.TabIndex = 25;
            this.cbo_qa.SelectionChangeCommitted += new System.EventHandler(this.cbo_qa_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tipo de prenda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Tipo de prenda 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Calidad";
            // 
            // grd_quote
            // 
            this.grd_quote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_quote.Location = new System.Drawing.Point(27, 391);
            this.grd_quote.Name = "grd_quote";
            this.grd_quote.Size = new System.Drawing.Size(761, 128);
            this.grd_quote.TabIndex = 30;
            this.grd_quote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grd_quote_KeyDown);
            // 
            // btn_add_quote
            // 
            this.btn_add_quote.Location = new System.Drawing.Point(314, 343);
            this.btn_add_quote.Name = "btn_add_quote";
            this.btn_add_quote.Size = new System.Drawing.Size(100, 42);
            this.btn_add_quote.TabIndex = 31;
            this.btn_add_quote.Text = "Añadir Cotización";
            this.btn_add_quote.UseVisualStyleBackColor = true;
            this.btn_add_quote.Click += new System.EventHandler(this.btn_add_quote_Click);
            // 
            // lbl_title_price
            // 
            this.lbl_title_price.AutoSize = true;
            this.lbl_title_price.Location = new System.Drawing.Point(311, 292);
            this.lbl_title_price.Name = "lbl_title_price";
            this.lbl_title_price.Size = new System.Drawing.Size(37, 13);
            this.lbl_title_price.TabIndex = 32;
            this.lbl_title_price.Text = "Precio";
            // 
            // lbl_title_qty
            // 
            this.lbl_title_qty.AutoSize = true;
            this.lbl_title_qty.Location = new System.Drawing.Point(437, 292);
            this.lbl_title_qty.Name = "lbl_title_qty";
            this.lbl_title_qty.Size = new System.Drawing.Size(49, 13);
            this.lbl_title_qty.TabIndex = 33;
            this.lbl_title_qty.Text = "Cantidad";
            // 
            // btn_search_vendor
            // 
            this.btn_search_vendor.Location = new System.Drawing.Point(39, 108);
            this.btn_search_vendor.Name = "btn_search_vendor";
            this.btn_search_vendor.Size = new System.Drawing.Size(116, 23);
            this.btn_search_vendor.TabIndex = 34;
            this.btn_search_vendor.Text = "Loggin";
            this.btn_search_vendor.UseVisualStyleBackColor = true;
            this.btn_search_vendor.Click += new System.EventHandler(this.btn_search_vendor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Codigo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Vendedor";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btn_history_quote
            // 
            this.btn_history_quote.Location = new System.Drawing.Point(581, 108);
            this.btn_history_quote.Name = "btn_history_quote";
            this.btn_history_quote.Size = new System.Drawing.Size(197, 23);
            this.btn_history_quote.TabIndex = 37;
            this.btn_history_quote.Text = "Historial Cotizaciones";
            this.btn_history_quote.UseVisualStyleBackColor = true;
            this.btn_history_quote.Click += new System.EventHandler(this.btn_history_quote_Click);
            // 
            // lbl_sign_dolar
            // 
            this.lbl_sign_dolar.AutoSize = true;
            this.lbl_sign_dolar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_sign_dolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lbl_sign_dolar.Location = new System.Drawing.Point(420, 343);
            this.lbl_sign_dolar.Name = "lbl_sign_dolar";
            this.lbl_sign_dolar.Size = new System.Drawing.Size(34, 38);
            this.lbl_sign_dolar.TabIndex = 38;
            this.lbl_sign_dolar.Text = "$";
            // 
            // frm_quote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 603);
            this.Controls.Add(this.lbl_sign_dolar);
            this.Controls.Add(this.btn_history_quote);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_search_vendor);
            this.Controls.Add(this.lbl_title_qty);
            this.Controls.Add(this.lbl_title_price);
            this.Controls.Add(this.btn_add_quote);
            this.Controls.Add(this.grd_quote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo_qa);
            this.Controls.Add(this.cbo_product_type2);
            this.Controls.Add(this.cbo_product_type);
            this.Controls.Add(this.cbo_product);
            this.Controls.Add(this.txt_SQL);
            this.Controls.Add(this.lbl_TotalQuote);
            this.Controls.Add(this.btn_quote);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.txt_price_unit);
            this.Controls.Add(this.lbl_stock);
            this.Controls.Add(this.lbl_title_stock);
            this.Controls.Add(this.lbl_description_shirt);
            this.Controls.Add(this.lbl_name_vendor);
            this.Controls.Add(this.lbl_code_vendor);
            this.Controls.Add(this.lbl_shop_address);
            this.Controls.Add(this.lbl_title_shop);
            this.Controls.Add(this.lbl_title);
            this.MaximizeBox = false;
            this.Name = "frm_quote";
            this.Text = "Bienvenido";
            this.Load += new System.EventHandler(this.frm_quote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_quote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_title_shop;
        private System.Windows.Forms.Label lbl_shop_address;
        private System.Windows.Forms.Label lbl_code_vendor;
        private System.Windows.Forms.Label lbl_name_vendor;
        private System.Windows.Forms.Label lbl_description_shirt;
        private System.Windows.Forms.Label lbl_title_stock;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.TextBox txt_price_unit;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.Button btn_quote;
        private System.Windows.Forms.Label lbl_TotalQuote;
        private System.Windows.Forms.TextBox txt_SQL;
        private System.Windows.Forms.ComboBox cbo_product;
        private System.Windows.Forms.ComboBox cbo_product_type;
        private System.Windows.Forms.ComboBox cbo_product_type2;
        private System.Windows.Forms.ComboBox cbo_qa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grd_quote;
        private System.Windows.Forms.Button btn_add_quote;
        private System.Windows.Forms.Label lbl_title_price;
        private System.Windows.Forms.Label lbl_title_qty;
        private System.Windows.Forms.Button btn_search_vendor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_history_quote;
        private System.Windows.Forms.Label lbl_sign_dolar;
    }
}

