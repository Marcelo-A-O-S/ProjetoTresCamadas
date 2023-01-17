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
            this.panelBuscarVendaCliente = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dGVProdutosVendas = new System.Windows.Forms.DataGridView();
            this.dGVVendas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarVendas = new System.Windows.Forms.Button();
            this.comboBoxClienteVenda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemoverVenda = new System.Windows.Forms.Button();
            this.panelBuscarVendaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProdutosVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVVendas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBuscarVendaCliente
            // 
            this.panelBuscarVendaCliente.Controls.Add(this.label1);
            this.panelBuscarVendaCliente.Controls.Add(this.label3);
            this.panelBuscarVendaCliente.Controls.Add(this.dGVProdutosVendas);
            this.panelBuscarVendaCliente.Controls.Add(this.dGVVendas);
            this.panelBuscarVendaCliente.Controls.Add(this.groupBox1);
            this.panelBuscarVendaCliente.Controls.Add(this.btnRemoverVenda);
            this.panelBuscarVendaCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBuscarVendaCliente.Location = new System.Drawing.Point(0, 0);
            this.panelBuscarVendaCliente.Name = "panelBuscarVendaCliente";
            this.panelBuscarVendaCliente.Size = new System.Drawing.Size(1010, 745);
            this.panelBuscarVendaCliente.TabIndex = 0;
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
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 40);
            this.label3.TabIndex = 23;
            this.label3.Text = "Produtos relacionados a venda:\r\n(Selecione para remover ou editar)";
            // 
            // dGVProdutosVendas
            // 
            this.dGVProdutosVendas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dGVProdutosVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVProdutosVendas.Location = new System.Drawing.Point(43, 445);
            this.dGVProdutosVendas.Name = "dGVProdutosVendas";
            this.dGVProdutosVendas.RowHeadersWidth = 51;
            this.dGVProdutosVendas.RowTemplate.Height = 29;
            this.dGVProdutosVendas.Size = new System.Drawing.Size(917, 229);
            this.dGVProdutosVendas.TabIndex = 22;
            this.dGVProdutosVendas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGVProdutosVendas_CellMouseClick);
            // 
            // dGVVendas
            // 
            this.dGVVendas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dGVVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVVendas.Location = new System.Drawing.Point(43, 200);
            this.dGVVendas.Name = "dGVVendas";
            this.dGVVendas.RowHeadersWidth = 51;
            this.dGVVendas.RowTemplate.Height = 29;
            this.dGVVendas.Size = new System.Drawing.Size(917, 194);
            this.dGVVendas.TabIndex = 21;
            this.dGVVendas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGVVendas_CellMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            // btnBuscarVendas
            // 
            this.btnBuscarVendas.BackColor = System.Drawing.Color.Navy;
            this.btnBuscarVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarVendas.ForeColor = System.Drawing.Color.White;
            this.btnBuscarVendas.Location = new System.Drawing.Point(220, 54);
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
            this.comboBoxClienteVenda.Location = new System.Drawing.Point(26, 64);
            this.comboBoxClienteVenda.Name = "comboBoxClienteVenda";
            this.comboBoxClienteVenda.Size = new System.Drawing.Size(151, 28);
            this.comboBoxClienteVenda.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(26, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // btnRemoverVenda
            // 
            this.btnRemoverVenda.BackColor = System.Drawing.Color.Red;
            this.btnRemoverVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverVenda.ForeColor = System.Drawing.Color.White;
            this.btnRemoverVenda.Location = new System.Drawing.Point(855, 685);
            this.btnRemoverVenda.Name = "btnRemoverVenda";
            this.btnRemoverVenda.Size = new System.Drawing.Size(105, 53);
            this.btnRemoverVenda.TabIndex = 20;
            this.btnRemoverVenda.Text = "Remover produto";
            this.btnRemoverVenda.UseVisualStyleBackColor = false;
            this.btnRemoverVenda.Click += new System.EventHandler(this.btnRemoverVenda_Click);
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
        private Button btnRemoverVenda;
        private ComboBox comboBoxClienteVenda;
        private Label label2;
        private DataGridView dGVVendas;
        private DataGridView dGVProdutosVendas;
        private Label label1;
        private Label label3;
    }
}