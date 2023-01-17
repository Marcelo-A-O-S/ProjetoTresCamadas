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
            this.dataGridViewVendas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdicionarVenda = new System.Windows.Forms.Button();
            this.btnRemoverVenda = new System.Windows.Forms.Button();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxProduto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxFornecedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFuncionario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelGerenciarCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGerenciarCompras
            // 
            this.panelGerenciarCompras.Controls.Add(this.dataGridViewVendas);
            this.panelGerenciarCompras.Controls.Add(this.groupBox1);
            this.panelGerenciarCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGerenciarCompras.Location = new System.Drawing.Point(0, 0);
            this.panelGerenciarCompras.Name = "panelGerenciarCompras";
            this.panelGerenciarCompras.Size = new System.Drawing.Size(1010, 745);
            this.panelGerenciarCompras.TabIndex = 0;
            // 
            // dataGridViewVendas
            // 
            this.dataGridViewVendas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVendas.Location = new System.Drawing.Point(37, 288);
            this.dataGridViewVendas.Name = "dataGridViewVendas";
            this.dataGridViewVendas.RowHeadersWidth = 51;
            this.dataGridViewVendas.RowTemplate.Height = 29;
            this.dataGridViewVendas.Size = new System.Drawing.Size(937, 407);
            this.dataGridViewVendas.TabIndex = 3;
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
            this.groupBox1.Controls.Add(this.comboBoxFornecedor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxFuncionario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(69, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(865, 196);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Realizar Compras";
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
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQuantidade.Location = new System.Drawing.Point(692, 63);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(150, 20);
            this.textBoxQuantidade.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(691, 37);
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
            this.comboBoxProduto.Location = new System.Drawing.Point(522, 60);
            this.comboBoxProduto.Name = "comboBoxProduto";
            this.comboBoxProduto.Size = new System.Drawing.Size(151, 28);
            this.comboBoxProduto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(522, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Produto";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(354, 60);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(151, 28);
            this.comboBoxCategoria.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(354, 37);
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
            this.comboBoxFornecedor.Location = new System.Drawing.Point(186, 60);
            this.comboBoxFornecedor.Name = "comboBoxFornecedor";
            this.comboBoxFornecedor.Size = new System.Drawing.Size(151, 28);
            this.comboBoxFornecedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(186, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fornecedor";
            // 
            // comboBoxFuncionario
            // 
            this.comboBoxFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxFuncionario.FormattingEnabled = true;
            this.comboBoxFuncionario.Location = new System.Drawing.Point(18, 60);
            this.comboBoxFuncionario.Name = "comboBoxFuncionario";
            this.comboBoxFuncionario.Size = new System.Drawing.Size(151, 28);
            this.comboBoxFuncionario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Funcionário";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelGerenciarCompras;
        private DataGridView dataGridViewVendas;
        private GroupBox groupBox1;
        private Button btnAdicionarVenda;
        private Button btnRemoverVenda;
        private TextBox textBoxQuantidade;
        private Label label5;
        private ComboBox comboBoxProduto;
        private Label label4;
        private ComboBox comboBoxCategoria;
        private Label label3;
        private ComboBox comboBoxFornecedor;
        private Label label2;
        private ComboBox comboBoxFuncionario;
        private Label label1;
    }
}