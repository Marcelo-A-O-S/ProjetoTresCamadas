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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDesfazerCompra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dGVProdutos = new System.Windows.Forms.DataGridView();
            this.dGVCompras = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelValor = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxValorPago = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxProduto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarCompras = new System.Windows.Forms.Button();
            this.comboBoxFornecedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDesfazerProduto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCompras)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDesfazerCompra);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dGVProdutos);
            this.panel1.Controls.Add(this.dGVCompras);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnDesfazerProduto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 745);
            this.panel1.TabIndex = 0;
            // 
            // btnDesfazerCompra
            // 
            this.btnDesfazerCompra.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDesfazerCompra.BackColor = System.Drawing.Color.Red;
            this.btnDesfazerCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesfazerCompra.ForeColor = System.Drawing.Color.White;
            this.btnDesfazerCompra.Location = new System.Drawing.Point(859, 398);
            this.btnDesfazerCompra.Name = "btnDesfazerCompra";
            this.btnDesfazerCompra.Size = new System.Drawing.Size(106, 54);
            this.btnDesfazerCompra.TabIndex = 42;
            this.btnDesfazerCompra.Text = "Desfazer compra";
            this.btnDesfazerCompra.UseVisualStyleBackColor = false;
            this.btnDesfazerCompra.Click += new System.EventHandler(this.btnDesfazerCompra_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Compras relacionadas ao fornecedor:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 40);
            this.label3.TabIndex = 29;
            this.label3.Text = "Produtos relacionados a compra:\r\n(Selecione para adicionar ou desfazer uma ompra)" +
    "";
            // 
            // dGVProdutos
            // 
            this.dGVProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dGVProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVProdutos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGVProdutos.EnableHeadersVisualStyles = false;
            this.dGVProdutos.Location = new System.Drawing.Point(47, 455);
            this.dGVProdutos.Name = "dGVProdutos";
            this.dGVProdutos.RowHeadersWidth = 51;
            this.dGVProdutos.RowTemplate.Height = 29;
            this.dGVProdutos.Size = new System.Drawing.Size(917, 229);
            this.dGVProdutos.TabIndex = 27;
            this.dGVProdutos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGVProdutos_CellMouseClick);
            // 
            // dGVCompras
            // 
            this.dGVCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVCompras.BackgroundColor = System.Drawing.Color.White;
            this.dGVCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGVCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVCompras.DefaultCellStyle = dataGridViewCellStyle4;
            this.dGVCompras.EnableHeadersVisualStyles = false;
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
            this.groupBox1.Controls.Add(this.LabelValor);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxValorPago);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnAdicionarProduto);
            this.groupBox1.Controls.Add(this.textBoxQuantidade);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxProduto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxCategoria);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnBuscarCompras);
            this.groupBox1.Controls.Add(this.comboBoxFornecedor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(72, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(865, 149);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar vendas por Fornecedor";
            // 
            // LabelValor
            // 
            this.LabelValor.AutoSize = true;
            this.LabelValor.Location = new System.Drawing.Point(579, 35);
            this.LabelValor.Name = "LabelValor";
            this.LabelValor.Size = new System.Drawing.Size(41, 20);
            this.LabelValor.TabIndex = 43;
            this.LabelValor.Text = "0000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "Valor Total do Produto: ";
            // 
            // textBoxValorPago
            // 
            this.textBoxValorPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxValorPago.Location = new System.Drawing.Point(539, 112);
            this.textBoxValorPago.Name = "textBoxValorPago";
            this.textBoxValorPago.Size = new System.Drawing.Size(150, 20);
            this.textBoxValorPago.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(538, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Valor pago";
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdicionarProduto.BackColor = System.Drawing.Color.Navy;
            this.btnAdicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarProduto.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarProduto.Location = new System.Drawing.Point(726, 81);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(121, 51);
            this.btnAdicionarProduto.TabIndex = 33;
            this.btnAdicionarProduto.Text = "Adicionar Produto";
            this.btnAdicionarProduto.UseVisualStyleBackColor = false;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQuantidade.Location = new System.Drawing.Point(365, 112);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(150, 20);
            this.textBoxQuantidade.TabIndex = 39;
            this.textBoxQuantidade.TextChanged += new System.EventHandler(this.textBoxQuantidade_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Quantidade";
            // 
            // comboBoxProduto
            // 
            this.comboBoxProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProduto.FormattingEnabled = true;
            this.comboBoxProduto.Location = new System.Drawing.Point(195, 109);
            this.comboBoxProduto.Name = "comboBoxProduto";
            this.comboBoxProduto.Size = new System.Drawing.Size(151, 28);
            this.comboBoxProduto.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(195, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Produto";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(27, 109);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(151, 28);
            this.comboBoxCategoria.TabIndex = 35;
            this.comboBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoria_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(27, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Categoria";
            // 
            // btnBuscarCompras
            // 
            this.btnBuscarCompras.BackColor = System.Drawing.Color.Navy;
            this.btnBuscarCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCompras.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCompras.Location = new System.Drawing.Point(221, 36);
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
            this.comboBoxFornecedor.Location = new System.Drawing.Point(27, 46);
            this.comboBoxFornecedor.Name = "comboBoxFornecedor";
            this.comboBoxFornecedor.Size = new System.Drawing.Size(151, 28);
            this.comboBoxFornecedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(27, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fornecedor";
            // 
            // btnDesfazerProduto
            // 
            this.btnDesfazerProduto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDesfazerProduto.BackColor = System.Drawing.Color.Red;
            this.btnDesfazerProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesfazerProduto.ForeColor = System.Drawing.Color.White;
            this.btnDesfazerProduto.Location = new System.Drawing.Point(859, 688);
            this.btnDesfazerProduto.Name = "btnDesfazerProduto";
            this.btnDesfazerProduto.Size = new System.Drawing.Size(105, 53);
            this.btnDesfazerProduto.TabIndex = 25;
            this.btnDesfazerProduto.Text = "Desfazer produto";
            this.btnDesfazerProduto.UseVisualStyleBackColor = false;
            this.btnDesfazerProduto.Click += new System.EventHandler(this.btnRemoverCompra_Click);
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
        private Button btnDesfazerProduto;
        private TextBox textBoxValorPago;
        private Label label7;
        private Button btnAdicionarProduto;
        private TextBox textBoxQuantidade;
        private Label label5;
        private ComboBox comboBoxProduto;
        private Label label4;
        private ComboBox comboBoxCategoria;
        private Label label6;
        private Button btnDesfazerCompra;
        private Label LabelValor;
        private Label label8;
    }
}