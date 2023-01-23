namespace WinFormsUI
{
    partial class FrmGerenciarVendas
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
            this.panelGerenciarVendas = new System.Windows.Forms.Panel();
            this.textBoxValorPago = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelValorTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLimparVendas = new System.Windows.Forms.Button();
            this.textBoxParcelas = new System.Windows.Forms.TextBox();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.dataGridViewVendas = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdicionarVenda = new System.Windows.Forms.Button();
            this.btnRemoverVenda = new System.Windows.Forms.Button();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxProduto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxPagamento = new System.Windows.Forms.ComboBox();
            this.panelGerenciarVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGerenciarVendas
            // 
            this.panelGerenciarVendas.AutoSize = true;
            this.panelGerenciarVendas.Controls.Add(this.textBoxValorPago);
            this.panelGerenciarVendas.Controls.Add(this.label9);
            this.panelGerenciarVendas.Controls.Add(this.labelValorTotal);
            this.panelGerenciarVendas.Controls.Add(this.label8);
            this.panelGerenciarVendas.Controls.Add(this.btnLimparVendas);
            this.panelGerenciarVendas.Controls.Add(this.textBoxParcelas);
            this.panelGerenciarVendas.Controls.Add(this.btnFinalizarVenda);
            this.panelGerenciarVendas.Controls.Add(this.dataGridViewVendas);
            this.panelGerenciarVendas.Controls.Add(this.label7);
            this.panelGerenciarVendas.Controls.Add(this.groupBox1);
            this.panelGerenciarVendas.Controls.Add(this.label6);
            this.panelGerenciarVendas.Controls.Add(this.comboBoxPagamento);
            this.panelGerenciarVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGerenciarVendas.Location = new System.Drawing.Point(0, 0);
            this.panelGerenciarVendas.Name = "panelGerenciarVendas";
            this.panelGerenciarVendas.Size = new System.Drawing.Size(1010, 745);
            this.panelGerenciarVendas.TabIndex = 0;
            // 
            // textBoxValorPago
            // 
            this.textBoxValorPago.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxValorPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxValorPago.Location = new System.Drawing.Point(608, 709);
            this.textBoxValorPago.Name = "textBoxValorPago";
            this.textBoxValorPago.Size = new System.Drawing.Size(125, 20);
            this.textBoxValorPago.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(608, 689);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Valor Pago:";
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelValorTotal.AutoSize = true;
            this.labelValorTotal.ForeColor = System.Drawing.Color.Red;
            this.labelValorTotal.Location = new System.Drawing.Point(187, 694);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(17, 20);
            this.labelValorTotal.TabIndex = 27;
            this.labelValorTotal.Text = "0";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 694);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Valor total da venda:";
            // 
            // btnLimparVendas
            // 
            this.btnLimparVendas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLimparVendas.BackColor = System.Drawing.Color.Red;
            this.btnLimparVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparVendas.ForeColor = System.Drawing.Color.White;
            this.btnLimparVendas.Location = new System.Drawing.Point(756, 694);
            this.btnLimparVendas.Name = "btnLimparVendas";
            this.btnLimparVendas.Size = new System.Drawing.Size(105, 42);
            this.btnLimparVendas.TabIndex = 25;
            this.btnLimparVendas.Text = "Limpar";
            this.btnLimparVendas.UseVisualStyleBackColor = false;
            this.btnLimparVendas.Click += new System.EventHandler(this.btnLimparVendas_Click);
            // 
            // textBoxParcelas
            // 
            this.textBoxParcelas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxParcelas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxParcelas.Location = new System.Drawing.Point(436, 715);
            this.textBoxParcelas.Name = "textBoxParcelas";
            this.textBoxParcelas.ReadOnly = true;
            this.textBoxParcelas.Size = new System.Drawing.Size(150, 20);
            this.textBoxParcelas.TabIndex = 24;
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnFinalizarVenda.BackColor = System.Drawing.Color.Navy;
            this.btnFinalizarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarVenda.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarVenda.Location = new System.Drawing.Point(867, 689);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(105, 53);
            this.btnFinalizarVenda.TabIndex = 21;
            this.btnFinalizarVenda.Text = "Finalizar Venda";
            this.btnFinalizarVenda.UseVisualStyleBackColor = false;
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
            // 
            // dataGridViewVendas
            // 
            this.dataGridViewVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewVendas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewVendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewVendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewVendas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewVendas.EnableHeadersVisualStyles = false;
            this.dataGridViewVendas.GridColor = System.Drawing.Color.Blue;
            this.dataGridViewVendas.Location = new System.Drawing.Point(35, 305);
            this.dataGridViewVendas.Name = "dataGridViewVendas";
            this.dataGridViewVendas.RowHeadersWidth = 51;
            this.dataGridViewVendas.RowTemplate.Height = 29;
            this.dataGridViewVendas.Size = new System.Drawing.Size(937, 378);
            this.dataGridViewVendas.TabIndex = 1;
            this.dataGridViewVendas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewVendas_CellMouseClick);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 689);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Parcelas";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnAdicionarVenda);
            this.groupBox1.Controls.Add(this.btnRemoverVenda);
            this.groupBox1.Controls.Add(this.textBoxQuantidade);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxProduto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxCategoria);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(67, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(865, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Realizar Vendas";
            // 
            // btnAdicionarVenda
            // 
            this.btnAdicionarVenda.BackColor = System.Drawing.Color.Navy;
            this.btnAdicionarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarVenda.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarVenda.Location = new System.Drawing.Point(541, 131);
            this.btnAdicionarVenda.Name = "btnAdicionarVenda";
            this.btnAdicionarVenda.Size = new System.Drawing.Size(105, 42);
            this.btnAdicionarVenda.TabIndex = 22;
            this.btnAdicionarVenda.Text = "Adicionar";
            this.btnAdicionarVenda.UseVisualStyleBackColor = false;
            this.btnAdicionarVenda.Click += new System.EventHandler(this.btnAdicionarVenda_Click);
            // 
            // btnRemoverVenda
            // 
            this.btnRemoverVenda.BackColor = System.Drawing.Color.Red;
            this.btnRemoverVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverVenda.ForeColor = System.Drawing.Color.White;
            this.btnRemoverVenda.Location = new System.Drawing.Point(749, 131);
            this.btnRemoverVenda.Name = "btnRemoverVenda";
            this.btnRemoverVenda.Size = new System.Drawing.Size(105, 42);
            this.btnRemoverVenda.TabIndex = 20;
            this.btnRemoverVenda.Text = "Remover";
            this.btnRemoverVenda.UseVisualStyleBackColor = false;
            this.btnRemoverVenda.Click += new System.EventHandler(this.btnRemoverVenda_Click);
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQuantidade.Location = new System.Drawing.Point(541, 63);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(150, 20);
            this.textBoxQuantidade.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(540, 37);
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
            this.comboBoxProduto.Location = new System.Drawing.Point(371, 60);
            this.comboBoxProduto.Name = "comboBoxProduto";
            this.comboBoxProduto.Size = new System.Drawing.Size(151, 28);
            this.comboBoxProduto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(371, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Produto";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(203, 60);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(151, 28);
            this.comboBoxCategoria.TabIndex = 5;
            this.comboBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoria_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(203, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categoria";
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(35, 60);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(151, 28);
            this.comboBoxCliente.TabIndex = 3;
            this.comboBoxCliente.TextUpdate += new System.EventHandler(this.comboBoxCliente_TextUpdate);
            this.comboBoxCliente.TextChanged += new System.EventHandler(this.comboBoxCliente_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(35, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 689);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Forma de Pagamento";
            // 
            // comboBoxPagamento
            // 
            this.comboBoxPagamento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBoxPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPagamento.FormattingEnabled = true;
            this.comboBoxPagamento.Items.AddRange(new object[] {
            "A vista",
            "Cartão de Credito",
            "Cartão de Debito",
            "Venda Parcelada",
            "Boleto"});
            this.comboBoxPagamento.Location = new System.Drawing.Point(263, 712);
            this.comboBoxPagamento.Name = "comboBoxPagamento";
            this.comboBoxPagamento.Size = new System.Drawing.Size(151, 28);
            this.comboBoxPagamento.TabIndex = 11;
            this.comboBoxPagamento.TextChanged += new System.EventHandler(this.comboBoxPagamento_TextChanged);
            // 
            // FrmGerenciarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 745);
            this.Controls.Add(this.panelGerenciarVendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGerenciarVendas";
            this.Text = "FrmGerenciarVendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmGerenciarVendas_Load);
            this.panelGerenciarVendas.ResumeLayout(false);
            this.panelGerenciarVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelGerenciarVendas;
        private GroupBox groupBox1;
        private ComboBox comboBoxCategoria;
        private Label label3;
        private ComboBox comboBoxCliente;
        private Label label2;
        private ComboBox comboBoxProduto;
        private Label label4;
        private TextBox textBoxQuantidade;
        private Label label5;
        private ComboBox comboBoxPagamento;
        private Label label6;
        private DataGridView dataGridViewVendas;
        private Button btnAdicionarVenda;
        private Button btnFinalizarVenda;
        private Button btnRemoverVenda;
        private TextBox textBoxParcelas;
        private Label label7;
        private Button btnLimparVendas;
        private Label labelValorTotal;
        private Label label8;
        private TextBox textBoxValorPago;
        private Label label9;
    }
}