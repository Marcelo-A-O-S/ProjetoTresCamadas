namespace WinFormsUI
{
    partial class FrmBuscarVendaCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBuscarVendaCliente = new System.Windows.Forms.Panel();
            this.btnDesfazerProduto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDesfazerVenda = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dGVProdutosVendas = new System.Windows.Forms.DataGridView();
            this.dGVVendas = new System.Windows.Forms.DataGridView();
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
            this.btnBuscarVendas = new System.Windows.Forms.Button();
            this.comboBoxClienteVenda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelBuscarVendaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProdutosVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVVendas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBuscarVendaCliente
            // 
            this.panelBuscarVendaCliente.Controls.Add(this.btnDesfazerProduto);
            this.panelBuscarVendaCliente.Controls.Add(this.label1);
            this.panelBuscarVendaCliente.Controls.Add(this.btnDesfazerVenda);
            this.panelBuscarVendaCliente.Controls.Add(this.label3);
            this.panelBuscarVendaCliente.Controls.Add(this.dGVProdutosVendas);
            this.panelBuscarVendaCliente.Controls.Add(this.dGVVendas);
            this.panelBuscarVendaCliente.Controls.Add(this.groupBox1);
            this.panelBuscarVendaCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBuscarVendaCliente.Location = new System.Drawing.Point(0, 0);
            this.panelBuscarVendaCliente.Name = "panelBuscarVendaCliente";
            this.panelBuscarVendaCliente.Size = new System.Drawing.Size(1010, 745);
            this.panelBuscarVendaCliente.TabIndex = 0;
            // 
            // btnDesfazerProduto
            // 
            this.btnDesfazerProduto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDesfazerProduto.BackColor = System.Drawing.Color.Red;
            this.btnDesfazerProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesfazerProduto.ForeColor = System.Drawing.Color.White;
            this.btnDesfazerProduto.Location = new System.Drawing.Point(862, 692);
            this.btnDesfazerProduto.Name = "btnDesfazerProduto";
            this.btnDesfazerProduto.Size = new System.Drawing.Size(98, 54);
            this.btnDesfazerProduto.TabIndex = 24;
            this.btnDesfazerProduto.Text = "Desfazer Produto";
            this.btnDesfazerProduto.UseVisualStyleBackColor = false;
            this.btnDesfazerProduto.Click += new System.EventHandler(this.btnDesfazerProduto_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Vendas relacionadas ao cliente:";
            // 
            // btnDesfazerVenda
            // 
            this.btnDesfazerVenda.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDesfazerVenda.BackColor = System.Drawing.Color.Red;
            this.btnDesfazerVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesfazerVenda.ForeColor = System.Drawing.Color.White;
            this.btnDesfazerVenda.Location = new System.Drawing.Point(862, 399);
            this.btnDesfazerVenda.Name = "btnDesfazerVenda";
            this.btnDesfazerVenda.Size = new System.Drawing.Size(98, 54);
            this.btnDesfazerVenda.TabIndex = 6;
            this.btnDesfazerVenda.Text = "Desfazer Venda";
            this.btnDesfazerVenda.UseVisualStyleBackColor = false;
            this.btnDesfazerVenda.Click += new System.EventHandler(this.btnDesfazerVenda_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(403, 40);
            this.label3.TabIndex = 23;
            this.label3.Text = "Produtos relacionados a venda:\r\n(Selecione para desfazer ou adicionar um produto " +
    "a venda)";
            // 
            // dGVProdutosVendas
            // 
            this.dGVProdutosVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVProdutosVendas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dGVProdutosVendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVProdutosVendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVProdutosVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVProdutosVendas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGVProdutosVendas.EnableHeadersVisualStyles = false;
            this.dGVProdutosVendas.GridColor = System.Drawing.Color.Blue;
            this.dGVProdutosVendas.Location = new System.Drawing.Point(43, 457);
            this.dGVProdutosVendas.Name = "dGVProdutosVendas";
            this.dGVProdutosVendas.RowHeadersWidth = 51;
            this.dGVProdutosVendas.RowTemplate.Height = 29;
            this.dGVProdutosVendas.Size = new System.Drawing.Size(917, 229);
            this.dGVProdutosVendas.TabIndex = 22;
            this.dGVProdutosVendas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGVProdutosVendas_CellMouseClick);
            // 
            // dGVVendas
            // 
            this.dGVVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVVendas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dGVVendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVVendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGVVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVVendas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dGVVendas.EnableHeadersVisualStyles = false;
            this.dGVVendas.GridColor = System.Drawing.Color.RoyalBlue;
            this.dGVVendas.Location = new System.Drawing.Point(43, 200);
            this.dGVVendas.Name = "dGVVendas";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVVendas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dGVVendas.RowHeadersWidth = 51;
            this.dGVVendas.RowTemplate.Height = 29;
            this.dGVVendas.Size = new System.Drawing.Size(917, 194);
            this.dGVVendas.TabIndex = 21;
            this.dGVVendas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGVVendas_CellMouseClick);
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
            this.groupBox1.Controls.Add(this.btnBuscarVendas);
            this.groupBox1.Controls.Add(this.comboBoxClienteVenda);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(68, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(865, 159);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar vendas por Cliente";
            // 
            // LabelValor
            // 
            this.LabelValor.AutoSize = true;
            this.LabelValor.Location = new System.Drawing.Point(579, 40);
            this.LabelValor.Name = "LabelValor";
            this.LabelValor.Size = new System.Drawing.Size(41, 20);
            this.LabelValor.TabIndex = 34;
            this.LabelValor.Text = "0000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Valor Total do Produto: ";
            // 
            // textBoxValorPago
            // 
            this.textBoxValorPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxValorPago.Location = new System.Drawing.Point(538, 117);
            this.textBoxValorPago.Name = "textBoxValorPago";
            this.textBoxValorPago.Size = new System.Drawing.Size(150, 20);
            this.textBoxValorPago.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(537, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Valor pago";
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdicionarProduto.BackColor = System.Drawing.Color.Navy;
            this.btnAdicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarProduto.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarProduto.Location = new System.Drawing.Point(725, 91);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(121, 51);
            this.btnAdicionarProduto.TabIndex = 25;
            this.btnAdicionarProduto.Text = "Adicionar Produto";
            this.btnAdicionarProduto.UseVisualStyleBackColor = false;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQuantidade.Location = new System.Drawing.Point(364, 117);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(150, 20);
            this.textBoxQuantidade.TabIndex = 30;
            this.textBoxQuantidade.TextChanged += new System.EventHandler(this.textBoxQuantidade_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Quantidade";
            // 
            // comboBoxProduto
            // 
            this.comboBoxProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProduto.FormattingEnabled = true;
            this.comboBoxProduto.Location = new System.Drawing.Point(194, 114);
            this.comboBoxProduto.Name = "comboBoxProduto";
            this.comboBoxProduto.Size = new System.Drawing.Size(151, 28);
            this.comboBoxProduto.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(194, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Produto";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(26, 114);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(151, 28);
            this.comboBoxCategoria.TabIndex = 26;
            this.comboBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoria_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(26, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Categoria";
            // 
            // btnBuscarVendas
            // 
            this.btnBuscarVendas.BackColor = System.Drawing.Color.Navy;
            this.btnBuscarVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarVendas.ForeColor = System.Drawing.Color.White;
            this.btnBuscarVendas.Location = new System.Drawing.Point(220, 37);
            this.btnBuscarVendas.Name = "btnBuscarVendas";
            this.btnBuscarVendas.Size = new System.Drawing.Size(105, 42);
            this.btnBuscarVendas.TabIndex = 22;
            this.btnBuscarVendas.Text = "Buscar";
            this.btnBuscarVendas.UseVisualStyleBackColor = false;
            this.btnBuscarVendas.Click += new System.EventHandler(this.btnBuscarVendas_Click);
            // 
            // comboBoxClienteVenda
            // 
            this.comboBoxClienteVenda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxClienteVenda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxClienteVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxClienteVenda.FormattingEnabled = true;
            this.comboBoxClienteVenda.Location = new System.Drawing.Point(26, 47);
            this.comboBoxClienteVenda.Name = "comboBoxClienteVenda";
            this.comboBoxClienteVenda.Size = new System.Drawing.Size(151, 28);
            this.comboBoxClienteVenda.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(26, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // FrmBuscarVendaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 745);
            this.Controls.Add(this.panelBuscarVendaCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBuscarVendaCliente";
            this.Text = "FrmBuscarVendaCliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelBuscarVendaCliente.ResumeLayout(false);
            this.panelBuscarVendaCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProdutosVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVVendas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelBuscarVendaCliente;
        private GroupBox groupBox1;
        private Button btnBuscarVendas;
        private ComboBox comboBoxClienteVenda;
        private Label label2;
        private DataGridView dGVVendas;
        private DataGridView dGVProdutosVendas;
        private Label label1;
        private Label label3;
        private Button btnDesfazerProduto;
        private Button btnDesfazerVenda;
        private Button btnAdicionarProduto;
        private TextBox textBoxQuantidade;
        private Label label5;
        private ComboBox comboBoxProduto;
        private Label label4;
        private ComboBox comboBoxCategoria;
        private Label label6;
        private TextBox textBoxValorPago;
        private Label label7;
        private Label LabelValor;
        private Label label8;
    }
}