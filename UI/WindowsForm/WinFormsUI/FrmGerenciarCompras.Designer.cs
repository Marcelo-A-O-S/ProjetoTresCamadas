namespace WinFormsUI
{
    partial class FrmGerenciarCompras
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
            this.panelGerenciarCompras = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxValorPago = new System.Windows.Forms.TextBox();
            this.labelValorTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLimparCompras = new System.Windows.Forms.Button();
            this.textBoxParcelas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxPagamento = new System.Windows.Forms.ComboBox();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.dataGridViewCompras = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdicionarCompra = new System.Windows.Forms.Button();
            this.btnRemoverCompra = new System.Windows.Forms.Button();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxProduto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxFornecedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelGerenciarCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompras)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGerenciarCompras
            // 
            this.panelGerenciarCompras.Controls.Add(this.label9);
            this.panelGerenciarCompras.Controls.Add(this.textBoxValorPago);
            this.panelGerenciarCompras.Controls.Add(this.labelValorTotal);
            this.panelGerenciarCompras.Controls.Add(this.label8);
            this.panelGerenciarCompras.Controls.Add(this.btnLimparCompras);
            this.panelGerenciarCompras.Controls.Add(this.textBoxParcelas);
            this.panelGerenciarCompras.Controls.Add(this.label7);
            this.panelGerenciarCompras.Controls.Add(this.label6);
            this.panelGerenciarCompras.Controls.Add(this.comboBoxPagamento);
            this.panelGerenciarCompras.Controls.Add(this.btnFinalizarCompra);
            this.panelGerenciarCompras.Controls.Add(this.dataGridViewCompras);
            this.panelGerenciarCompras.Controls.Add(this.groupBox1);
            this.panelGerenciarCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGerenciarCompras.Location = new System.Drawing.Point(0, 0);
            this.panelGerenciarCompras.Name = "panelGerenciarCompras";
            this.panelGerenciarCompras.Size = new System.Drawing.Size(1010, 745);
            this.panelGerenciarCompras.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(592, 676);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Valor Pago:";
            // 
            // textBoxValorPago
            // 
            this.textBoxValorPago.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxValorPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxValorPago.Location = new System.Drawing.Point(590, 700);
            this.textBoxValorPago.Name = "textBoxValorPago";
            this.textBoxValorPago.Size = new System.Drawing.Size(125, 20);
            this.textBoxValorPago.TabIndex = 35;
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelValorTotal.AutoSize = true;
            this.labelValorTotal.ForeColor = System.Drawing.Color.Red;
            this.labelValorTotal.Location = new System.Drawing.Point(193, 682);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(17, 20);
            this.labelValorTotal.TabIndex = 34;
            this.labelValorTotal.Text = "0";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 682);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Valor total da compra:";
            // 
            // btnLimparCompras
            // 
            this.btnLimparCompras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimparCompras.BackColor = System.Drawing.Color.Red;
            this.btnLimparCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparCompras.ForeColor = System.Drawing.Color.White;
            this.btnLimparCompras.Location = new System.Drawing.Point(752, 682);
            this.btnLimparCompras.Name = "btnLimparCompras";
            this.btnLimparCompras.Size = new System.Drawing.Size(105, 42);
            this.btnLimparCompras.TabIndex = 32;
            this.btnLimparCompras.Text = "Limpar";
            this.btnLimparCompras.UseVisualStyleBackColor = false;
            this.btnLimparCompras.Click += new System.EventHandler(this.btnLimparCompras_Click);
            // 
            // textBoxParcelas
            // 
            this.textBoxParcelas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxParcelas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxParcelas.Location = new System.Drawing.Point(418, 700);
            this.textBoxParcelas.Name = "textBoxParcelas";
            this.textBoxParcelas.ReadOnly = true;
            this.textBoxParcelas.Size = new System.Drawing.Size(150, 20);
            this.textBoxParcelas.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 674);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Parcelas";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 674);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Forma de Pagamento";
            // 
            // comboBoxPagamento
            // 
            this.comboBoxPagamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPagamento.FormattingEnabled = true;
            this.comboBoxPagamento.Items.AddRange(new object[] {
            "A vista",
            "Cartão de Credito",
            "Cartão de Debito",
            "Compra Parcelada",
            "Boleto"});
            this.comboBoxPagamento.Location = new System.Drawing.Point(245, 700);
            this.comboBoxPagamento.Name = "comboBoxPagamento";
            this.comboBoxPagamento.Size = new System.Drawing.Size(151, 28);
            this.comboBoxPagamento.TabIndex = 29;
            this.comboBoxPagamento.TextChanged += new System.EventHandler(this.comboBoxPagamento_TextChanged);
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFinalizarCompra.BackColor = System.Drawing.Color.Navy;
            this.btnFinalizarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarCompra.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarCompra.Location = new System.Drawing.Point(867, 677);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(105, 56);
            this.btnFinalizarCompra.TabIndex = 23;
            this.btnFinalizarCompra.Text = "Finalizar Compra";
            this.btnFinalizarCompra.UseVisualStyleBackColor = false;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.btnFinalizarCompra_Click);
            // 
            // dataGridViewCompras
            // 
            this.dataGridViewCompras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompras.Location = new System.Drawing.Point(35, 264);
            this.dataGridViewCompras.Name = "dataGridViewCompras";
            this.dataGridViewCompras.RowHeadersWidth = 51;
            this.dataGridViewCompras.RowTemplate.Height = 29;
            this.dataGridViewCompras.Size = new System.Drawing.Size(937, 407);
            this.dataGridViewCompras.TabIndex = 3;
            this.dataGridViewCompras.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCompras_CellMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnAdicionarCompra);
            this.groupBox1.Controls.Add(this.btnRemoverCompra);
            this.groupBox1.Controls.Add(this.textBoxQuantidade);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxProduto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxCategoria);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxFornecedor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(69, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(865, 176);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Realizar Compras";
            // 
            // btnAdicionarCompra
            // 
            this.btnAdicionarCompra.BackColor = System.Drawing.Color.Navy;
            this.btnAdicionarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarCompra.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarCompra.Location = new System.Drawing.Point(541, 110);
            this.btnAdicionarCompra.Name = "btnAdicionarCompra";
            this.btnAdicionarCompra.Size = new System.Drawing.Size(105, 42);
            this.btnAdicionarCompra.TabIndex = 22;
            this.btnAdicionarCompra.Text = "Adicionar";
            this.btnAdicionarCompra.UseVisualStyleBackColor = false;
            this.btnAdicionarCompra.Click += new System.EventHandler(this.btnAdicionarCompra_Click);
            // 
            // btnRemoverCompra
            // 
            this.btnRemoverCompra.BackColor = System.Drawing.Color.Red;
            this.btnRemoverCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverCompra.ForeColor = System.Drawing.Color.White;
            this.btnRemoverCompra.Location = new System.Drawing.Point(749, 110);
            this.btnRemoverCompra.Name = "btnRemoverCompra";
            this.btnRemoverCompra.Size = new System.Drawing.Size(105, 42);
            this.btnRemoverCompra.TabIndex = 20;
            this.btnRemoverCompra.Text = "Remover";
            this.btnRemoverCompra.UseVisualStyleBackColor = false;
            this.btnRemoverCompra.Click += new System.EventHandler(this.btnRemoverCompra_Click);
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQuantidade.Location = new System.Drawing.Point(534, 60);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(150, 20);
            this.textBoxQuantidade.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantidade";
            // 
            // comboBoxProduto
            // 
            this.comboBoxProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProduto.FormattingEnabled = true;
            this.comboBoxProduto.Location = new System.Drawing.Point(364, 57);
            this.comboBoxProduto.Name = "comboBoxProduto";
            this.comboBoxProduto.Size = new System.Drawing.Size(151, 28);
            this.comboBoxProduto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(364, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Produto";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(196, 57);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(151, 28);
            this.comboBoxCategoria.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(196, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categoria";
            // 
            // comboBoxFornecedor
            // 
            this.comboBoxFornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxFornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxFornecedor.FormattingEnabled = true;
            this.comboBoxFornecedor.Location = new System.Drawing.Point(28, 57);
            this.comboBoxFornecedor.Name = "comboBoxFornecedor";
            this.comboBoxFornecedor.Size = new System.Drawing.Size(151, 28);
            this.comboBoxFornecedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(28, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fornecedor";
            // 
            // FrmGerenciarCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 745);
            this.Controls.Add(this.panelGerenciarCompras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGerenciarCompras";
            this.Text = "FrmGerenciarCompras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelGerenciarCompras.ResumeLayout(false);
            this.panelGerenciarCompras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompras)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelGerenciarCompras;
        private DataGridView dataGridViewCompras;
        private GroupBox groupBox1;
        private Button btnAdicionarCompra;
        private Button btnRemoverCompra;
        private TextBox textBoxQuantidade;
        private Label label5;
        private ComboBox comboBoxProduto;
        private Label label4;
        private ComboBox comboBoxCategoria;
        private Label label3;
        private ComboBox comboBoxFornecedor;
        private Label label2;
        private Button btnFinalizarCompra;
        private Label labelValorTotal;
        private Label label8;
        private Button btnLimparCompras;
        private TextBox textBoxParcelas;
        private Label label7;
        private Label label6;
        private ComboBox comboBoxPagamento;
        private Label label9;
        private TextBox textBoxValorPago;
    }
}