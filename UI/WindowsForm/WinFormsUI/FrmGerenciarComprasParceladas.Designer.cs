namespace WinFormsUI
{
    partial class FrmGerenciarComprasParceladas
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
            this.btnPagarParcela = new System.Windows.Forms.Button();
            this.btnAbaterRegistro = new System.Windows.Forms.Button();
            this.btnRemoverRegistro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dGVInfoCompraParcela = new System.Windows.Forms.DataGridView();
            this.dGVRegistrosComprasParceladas = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVInfoCompraParcela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVRegistrosComprasParceladas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPagarParcela);
            this.panel1.Controls.Add(this.btnAbaterRegistro);
            this.panel1.Controls.Add(this.btnRemoverRegistro);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dGVInfoCompraParcela);
            this.panel1.Controls.Add(this.dGVRegistrosComprasParceladas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 745);
            this.panel1.TabIndex = 0;
            // 
            // btnPagarParcela
            // 
            this.btnPagarParcela.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPagarParcela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagarParcela.Location = new System.Drawing.Point(661, 648);
            this.btnPagarParcela.Name = "btnPagarParcela";
            this.btnPagarParcela.Size = new System.Drawing.Size(133, 61);
            this.btnPagarParcela.TabIndex = 32;
            this.btnPagarParcela.Text = "Pagar parcela";
            this.btnPagarParcela.UseVisualStyleBackColor = true;
            // 
            // btnAbaterRegistro
            // 
            this.btnAbaterRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAbaterRegistro.BackColor = System.Drawing.Color.Navy;
            this.btnAbaterRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbaterRegistro.ForeColor = System.Drawing.Color.White;
            this.btnAbaterRegistro.Location = new System.Drawing.Point(836, 648);
            this.btnAbaterRegistro.Name = "btnAbaterRegistro";
            this.btnAbaterRegistro.Size = new System.Drawing.Size(137, 61);
            this.btnAbaterRegistro.TabIndex = 31;
            this.btnAbaterRegistro.Text = "Abater Registro Parcela";
            this.btnAbaterRegistro.UseVisualStyleBackColor = false;
            // 
            // btnRemoverRegistro
            // 
            this.btnRemoverRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoverRegistro.BackColor = System.Drawing.Color.Red;
            this.btnRemoverRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverRegistro.ForeColor = System.Drawing.Color.White;
            this.btnRemoverRegistro.Location = new System.Drawing.Point(479, 648);
            this.btnRemoverRegistro.Name = "btnRemoverRegistro";
            this.btnRemoverRegistro.Size = new System.Drawing.Size(140, 61);
            this.btnRemoverRegistro.TabIndex = 30;
            this.btnRemoverRegistro.Text = "Remover registro parcela";
            this.btnRemoverRegistro.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(443, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Dados referente a parcela:(Selecione para alterar as informacões)";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Registros de Compras parceladas:(Selecione a compra para ver detalhes da parcela)" +
    "";
            // 
            // dGVInfoCompraParcela
            // 
            this.dGVInfoCompraParcela.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dGVInfoCompraParcela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVInfoCompraParcela.Location = new System.Drawing.Point(38, 437);
            this.dGVInfoCompraParcela.Name = "dGVInfoCompraParcela";
            this.dGVInfoCompraParcela.RowHeadersWidth = 51;
            this.dGVInfoCompraParcela.RowTemplate.Height = 29;
            this.dGVInfoCompraParcela.Size = new System.Drawing.Size(935, 140);
            this.dGVInfoCompraParcela.TabIndex = 27;
            // 
            // dGVRegistrosComprasParceladas
            // 
            this.dGVRegistrosComprasParceladas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dGVRegistrosComprasParceladas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVRegistrosComprasParceladas.Location = new System.Drawing.Point(38, 71);
            this.dGVRegistrosComprasParceladas.Name = "dGVRegistrosComprasParceladas";
            this.dGVRegistrosComprasParceladas.RowHeadersWidth = 51;
            this.dGVRegistrosComprasParceladas.RowTemplate.Height = 29;
            this.dGVRegistrosComprasParceladas.Size = new System.Drawing.Size(935, 312);
            this.dGVRegistrosComprasParceladas.TabIndex = 26;
            // 
            // FrmGerenciarComprasParceladas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 745);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGerenciarComprasParceladas";
            this.Text = "FrmGerenciarComprasParceladas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVInfoCompraParcela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVRegistrosComprasParceladas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnPagarParcela;
        private Button btnAbaterRegistro;
        private Button btnRemoverRegistro;
        private Label label2;
        private Label label1;
        private DataGridView dGVInfoCompraParcela;
        private DataGridView dGVRegistrosComprasParceladas;
    }
}