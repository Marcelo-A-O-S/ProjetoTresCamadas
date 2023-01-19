namespace WinFormsUI
{
    partial class FrmGerenciarVendasParceladas
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
            this.panelGerenciarVendasParceladas = new System.Windows.Forms.Panel();
            this.btnPagarParcela = new System.Windows.Forms.Button();
            this.btnAbaterRegistro = new System.Windows.Forms.Button();
            this.btnRemoverRegistro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dGVInfoParcela = new System.Windows.Forms.DataGridView();
            this.dGVRegistrosVendasParceladas = new System.Windows.Forms.DataGridView();
            this.panelGerenciarVendasParceladas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVInfoParcela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVRegistrosVendasParceladas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGerenciarVendasParceladas
            // 
            this.panelGerenciarVendasParceladas.Controls.Add(this.btnPagarParcela);
            this.panelGerenciarVendasParceladas.Controls.Add(this.btnAbaterRegistro);
            this.panelGerenciarVendasParceladas.Controls.Add(this.btnRemoverRegistro);
            this.panelGerenciarVendasParceladas.Controls.Add(this.label2);
            this.panelGerenciarVendasParceladas.Controls.Add(this.label1);
            this.panelGerenciarVendasParceladas.Controls.Add(this.dGVInfoParcela);
            this.panelGerenciarVendasParceladas.Controls.Add(this.dGVRegistrosVendasParceladas);
            this.panelGerenciarVendasParceladas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGerenciarVendasParceladas.Location = new System.Drawing.Point(0, 0);
            this.panelGerenciarVendasParceladas.Name = "panelGerenciarVendasParceladas";
            this.panelGerenciarVendasParceladas.Size = new System.Drawing.Size(1010, 745);
            this.panelGerenciarVendasParceladas.TabIndex = 0;
            // 
            // btnPagarParcela
            // 
            this.btnPagarParcela.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPagarParcela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagarParcela.Location = new System.Drawing.Point(662, 626);
            this.btnPagarParcela.Name = "btnPagarParcela";
            this.btnPagarParcela.Size = new System.Drawing.Size(133, 61);
            this.btnPagarParcela.TabIndex = 25;
            this.btnPagarParcela.Text = "Pagar parcela";
            this.btnPagarParcela.UseVisualStyleBackColor = true;
            this.btnPagarParcela.Click += new System.EventHandler(this.btnPagarParcela_Click);
            // 
            // btnAbaterRegistro
            // 
            this.btnAbaterRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAbaterRegistro.BackColor = System.Drawing.Color.Navy;
            this.btnAbaterRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbaterRegistro.ForeColor = System.Drawing.Color.White;
            this.btnAbaterRegistro.Location = new System.Drawing.Point(837, 626);
            this.btnAbaterRegistro.Name = "btnAbaterRegistro";
            this.btnAbaterRegistro.Size = new System.Drawing.Size(137, 61);
            this.btnAbaterRegistro.TabIndex = 24;
            this.btnAbaterRegistro.Text = "Abater Registro Parcela";
            this.btnAbaterRegistro.UseVisualStyleBackColor = false;
            this.btnAbaterRegistro.Click += new System.EventHandler(this.btnAbaterRegistro_Click);
            // 
            // btnRemoverRegistro
            // 
            this.btnRemoverRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoverRegistro.BackColor = System.Drawing.Color.Red;
            this.btnRemoverRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverRegistro.ForeColor = System.Drawing.Color.White;
            this.btnRemoverRegistro.Location = new System.Drawing.Point(480, 626);
            this.btnRemoverRegistro.Name = "btnRemoverRegistro";
            this.btnRemoverRegistro.Size = new System.Drawing.Size(140, 61);
            this.btnRemoverRegistro.TabIndex = 23;
            this.btnRemoverRegistro.Text = "Remover registro parcela";
            this.btnRemoverRegistro.UseVisualStyleBackColor = false;
            this.btnRemoverRegistro.Click += new System.EventHandler(this.btnRemoverRegistro_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(443, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dados referente a parcela:(Selecione para alterar as informacões)";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Registros de Vendas parceladas:(Selecione a venda para ver detalhes da parcela)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dGVInfoParcela
            // 
            this.dGVInfoParcela.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dGVInfoParcela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVInfoParcela.Location = new System.Drawing.Point(39, 415);
            this.dGVInfoParcela.Name = "dGVInfoParcela";
            this.dGVInfoParcela.RowHeadersWidth = 51;
            this.dGVInfoParcela.RowTemplate.Height = 29;
            this.dGVInfoParcela.Size = new System.Drawing.Size(935, 140);
            this.dGVInfoParcela.TabIndex = 5;
            this.dGVInfoParcela.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGVInfoParcela_CellMouseClick);
            // 
            // dGVRegistrosVendasParceladas
            // 
            this.dGVRegistrosVendasParceladas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dGVRegistrosVendasParceladas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVRegistrosVendasParceladas.Location = new System.Drawing.Point(39, 49);
            this.dGVRegistrosVendasParceladas.Name = "dGVRegistrosVendasParceladas";
            this.dGVRegistrosVendasParceladas.RowHeadersWidth = 51;
            this.dGVRegistrosVendasParceladas.RowTemplate.Height = 29;
            this.dGVRegistrosVendasParceladas.Size = new System.Drawing.Size(935, 312);
            this.dGVRegistrosVendasParceladas.TabIndex = 4;
            this.dGVRegistrosVendasParceladas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGVRegistrosVendasParceladas_CellMouseClick);
            // 
            // FrmGerenciarVendasParceladas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 745);
            this.Controls.Add(this.panelGerenciarVendasParceladas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGerenciarVendasParceladas";
            this.Text = "FrmGerenciarVendasParceladas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelGerenciarVendasParceladas.ResumeLayout(false);
            this.panelGerenciarVendasParceladas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVInfoParcela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVRegistrosVendasParceladas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelGerenciarVendasParceladas;
        private Label label2;
        private Label label1;
        private DataGridView dGVInfoParcela;
        private DataGridView dGVRegistrosVendasParceladas;
        private Button btnPagarParcela;
        private Button btnAbaterRegistro;
        private Button btnRemoverRegistro;
    }
}