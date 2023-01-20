namespace WinFormsUI
{
    partial class FrmBuscarCompraFornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dGVProdutos = new System.Windows.Forms.DataGridView();
            this.dGVCompras = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarCompras = new System.Windows.Forms.Button();
            this.comboBoxFornecedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemoverCompra = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCompras)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dGVProdutos);
            this.panel1.Controls.Add(this.dGVCompras);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnRemoverCompra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 745);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Compras relacionadas ao fornecedor:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 40);
            this.label3.TabIndex = 29;
            this.label3.Text = "Produtos relacionados a compra:\r\n(Selecione para remover ou editar)";
            // 
            // dGVProdutos
            // 
            this.dGVProdutos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dGVProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVProdutos.Location = new System.Drawing.Point(47, 444);
            this.dGVProdutos.Name = "dGVProdutos";
            this.dGVProdutos.RowHeadersWidth = 51;
            this.dGVProdutos.RowTemplate.Height = 29;
            this.dGVProdutos.Size = new System.Drawing.Size(917, 229);
            this.dGVProdutos.TabIndex = 27;
            this.dGVProdutos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGVProdutos_CellMouseClick);
            // 
            // dGVCompras
            // 
            this.dGVCompras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dGVCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCompras.Location = new System.Drawing.Point(47, 199);
            this.dGVCompras.Name = "dGVCompras";
            this.dGVCompras.RowHeadersWidth = 51;
            this.dGVCompras.RowTemplate.Height = 29;
            this.dGVCompras.Size = new System.Drawing.Size(917, 194);
            this.dGVCompras.TabIndex = 26;
            this.dGVCompras.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGVCompras_CellMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnBuscarCompras);
            this.groupBox1.Controls.Add(this.comboBoxFornecedor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(72, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(865, 159);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar vendas por Fornecedor";
            // 
            // btnBuscarCompras
            // 
            this.btnBuscarCompras.BackColor = System.Drawing.Color.Navy;
            this.btnBuscarCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCompras.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCompras.Location = new System.Drawing.Point(220, 54);
            this.btnBuscarCompras.Name = "btnBuscarCompras";
            this.btnBuscarCompras.Size = new System.Drawing.Size(105, 42);
            this.btnBuscarCompras.TabIndex = 22;
            this.btnBuscarCompras.Text = "Buscar";
            this.btnBuscarCompras.UseVisualStyleBackColor = false;
            this.btnBuscarCompras.Click += new System.EventHandler(this.btnBuscarCompras_Click);
            // 
            // comboBoxFornecedor
            // 
            this.comboBoxFornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxFornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxFornecedor.FormattingEnabled = true;
            this.comboBoxFornecedor.Location = new System.Drawing.Point(26, 64);
            this.comboBoxFornecedor.Name = "comboBoxFornecedor";
            this.comboBoxFornecedor.Size = new System.Drawing.Size(151, 28);
            this.comboBoxFornecedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(26, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fornecedor";
            // 
            // btnRemoverCompra
            // 
            this.btnRemoverCompra.BackColor = System.Drawing.Color.Red;
            this.btnRemoverCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverCompra.ForeColor = System.Drawing.Color.White;
            this.btnRemoverCompra.Location = new System.Drawing.Point(859, 684);
            this.btnRemoverCompra.Name = "btnRemoverCompra";
            this.btnRemoverCompra.Size = new System.Drawing.Size(105, 53);
            this.btnRemoverCompra.TabIndex = 25;
            this.btnRemoverCompra.Text = "Remover produto";
            this.btnRemoverCompra.UseVisualStyleBackColor = false;
            this.btnRemoverCompra.Click += new System.EventHandler(this.btnRemoverCompra_Click);
            // 
            // FrmBuscarCompraFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 745);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBuscarCompraFornecedor";
            this.Text = "FrmBuscarCompraFornecedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCompras)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private DataGridView dGVProdutos;
        private DataGridView dGVCompras;
        private GroupBox groupBox1;
        private Button btnBuscarCompras;
        private ComboBox comboBoxFornecedor;
        private Label label2;
        private Button btnRemoverCompra;
    }
}