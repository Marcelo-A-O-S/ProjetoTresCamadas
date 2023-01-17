namespace WinFormsUI
{
    partial class FrmGerenciarProdutos
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
            this.panelGerenciarProdutos = new System.Windows.Forms.Panel();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textEstoqueProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.btnRemoverProduto = new System.Windows.Forms.Button();
            this.textDescricaoProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCategoriaProdutos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textValorProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNomeProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelGerenciarProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGerenciarProdutos
            // 
            this.panelGerenciarProdutos.Controls.Add(this.dataGridViewProdutos);
            this.panelGerenciarProdutos.Controls.Add(this.groupBox1);
            this.panelGerenciarProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGerenciarProdutos.Location = new System.Drawing.Point(0, 0);
            this.panelGerenciarProdutos.Name = "panelGerenciarProdutos";
            this.panelGerenciarProdutos.Size = new System.Drawing.Size(1010, 686);
            this.panelGerenciarProdutos.TabIndex = 0;
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(40, 361);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.RowHeadersWidth = 51;
            this.dataGridViewProdutos.RowTemplate.Height = 29;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(932, 297);
            this.dataGridViewProdutos.TabIndex = 1;
            this.dataGridViewProdutos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewProdutos_CellMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.textEstoqueProduto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnEditarProduto);
            this.groupBox1.Controls.Add(this.btnCadastrarProduto);
            this.groupBox1.Controls.Add(this.btnRemoverProduto);
            this.groupBox1.Controls.Add(this.textDescricaoProduto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxCategoriaProdutos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textValorProduto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textNomeProduto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(194, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Produto";
            // 
            // textEstoqueProduto
            // 
            this.textEstoqueProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEstoqueProduto.Location = new System.Drawing.Point(28, 206);
            this.textEstoqueProduto.Name = "textEstoqueProduto";
            this.textEstoqueProduto.PlaceholderText = "Digite aqui a quantidade em estoque";
            this.textEstoqueProduto.Size = new System.Drawing.Size(278, 20);
            this.textEstoqueProduto.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Quantidade em Estoque";
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProduto.Location = new System.Drawing.Point(258, 240);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(105, 42);
            this.btnEditarProduto.TabIndex = 22;
            this.btnEditarProduto.Text = "Editar";
            this.btnEditarProduto.UseVisualStyleBackColor = true;
            this.btnEditarProduto.Click += new System.EventHandler(this.btnEditarProduto_Click);
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.BackColor = System.Drawing.Color.Navy;
            this.btnCadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarProduto.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarProduto.Location = new System.Drawing.Point(400, 240);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(112, 42);
            this.btnCadastrarProduto.TabIndex = 21;
            this.btnCadastrarProduto.Text = "Cadastrar ";
            this.btnCadastrarProduto.UseVisualStyleBackColor = false;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.BackColor = System.Drawing.Color.Red;
            this.btnRemoverProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverProduto.ForeColor = System.Drawing.Color.White;
            this.btnRemoverProduto.Location = new System.Drawing.Point(111, 240);
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Size = new System.Drawing.Size(105, 42);
            this.btnRemoverProduto.TabIndex = 20;
            this.btnRemoverProduto.Text = "Remover";
            this.btnRemoverProduto.UseVisualStyleBackColor = false;
            this.btnRemoverProduto.Click += new System.EventHandler(this.btnRemoverProduto_Click);
            // 
            // textDescricaoProduto
            // 
            this.textDescricaoProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDescricaoProduto.Location = new System.Drawing.Point(328, 55);
            this.textDescricaoProduto.Multiline = true;
            this.textDescricaoProduto.Name = "textDescricaoProduto";
            this.textDescricaoProduto.PlaceholderText = "Digite aqui uma descricão para o produto";
            this.textDescricaoProduto.Size = new System.Drawing.Size(278, 171);
            this.textDescricaoProduto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descricão do produto";
            // 
            // comboBoxCategoriaProdutos
            // 
            this.comboBoxCategoriaProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCategoriaProdutos.FormattingEnabled = true;
            this.comboBoxCategoriaProdutos.Location = new System.Drawing.Point(30, 154);
            this.comboBoxCategoriaProdutos.Name = "comboBoxCategoriaProdutos";
            this.comboBoxCategoriaProdutos.Size = new System.Drawing.Size(276, 28);
            this.comboBoxCategoriaProdutos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categoria do produto";
            // 
            // textValorProduto
            // 
            this.textValorProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textValorProduto.Location = new System.Drawing.Point(28, 105);
            this.textValorProduto.Name = "textValorProduto";
            this.textValorProduto.PlaceholderText = "Digite aqui o valor para o produto";
            this.textValorProduto.Size = new System.Drawing.Size(278, 20);
            this.textValorProduto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor do produto";
            // 
            // textNomeProduto
            // 
            this.textNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNomeProduto.Location = new System.Drawing.Point(28, 55);
            this.textNomeProduto.Name = "textNomeProduto";
            this.textNomeProduto.PlaceholderText = "Digite aqui o nome para o produto";
            this.textNomeProduto.Size = new System.Drawing.Size(278, 20);
            this.textNomeProduto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do produto";
            // 
            // FrmGerenciarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 686);
            this.Controls.Add(this.panelGerenciarProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGerenciarProdutos";
            this.Text = "FrmGerenciarProdutos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmGerenciarProdutos_Load);
            this.panelGerenciarProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelGerenciarProdutos;
        private GroupBox groupBox1;
        private ComboBox comboBoxCategoriaProdutos;
        private Label label3;
        private TextBox textValorProduto;
        private Label label2;
        private TextBox textNomeProduto;
        private Label label1;
        private TextBox textDescricaoProduto;
        private Label label4;
        private DataGridView dataGridViewProdutos;
        private Button btnEditarProduto;
        private Button btnCadastrarProduto;
        private Button btnRemoverProduto;
        private TextBox textEstoqueProduto;
        private Label label5;
    }
}