namespace WinFormsUI
{
    partial class FrmRegistroVendas
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
            this.panelRegistroVendas = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dGVProdutosVendas = new System.Windows.Forms.DataGridView();
            this.dGVRegistrosVendas = new System.Windows.Forms.DataGridView();
            this.panelRegistroVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProdutosVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVRegistrosVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRegistroVendas
            // 
            this.panelRegistroVendas.Controls.Add(this.label2);
            this.panelRegistroVendas.Controls.Add(this.label1);
            this.panelRegistroVendas.Controls.Add(this.dGVProdutosVendas);
            this.panelRegistroVendas.Controls.Add(this.dGVRegistrosVendas);
            this.panelRegistroVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegistroVendas.Location = new System.Drawing.Point(0, 0);
            this.panelRegistroVendas.Name = "panelRegistroVendas";
            this.panelRegistroVendas.Size = new System.Drawing.Size(1010, 745);
            this.panelRegistroVendas.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Produtos por venda";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registros de Venda";
            // 
            // dGVProdutosVendas
            // 
            this.dGVProdutosVendas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dGVProdutosVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVProdutosVendas.Location = new System.Drawing.Point(36, 390);
            this.dGVProdutosVendas.Name = "dGVProdutosVendas";
            this.dGVProdutosVendas.RowHeadersWidth = 51;
            this.dGVProdutosVendas.RowTemplate.Height = 29;
            this.dGVProdutosVendas.Size = new System.Drawing.Size(935, 305);
            this.dGVProdutosVendas.TabIndex = 1;
            // 
            // dGVRegistrosVendas
            // 
            this.dGVRegistrosVendas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dGVRegistrosVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVRegistrosVendas.Location = new System.Drawing.Point(36, 38);
            this.dGVRegistrosVendas.Name = "dGVRegistrosVendas";
            this.dGVRegistrosVendas.RowHeadersWidth = 51;
            this.dGVRegistrosVendas.RowTemplate.Height = 29;
            this.dGVRegistrosVendas.Size = new System.Drawing.Size(935, 305);
            this.dGVRegistrosVendas.TabIndex = 0;
            this.dGVRegistrosVendas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGVRegistrosVendas_CellMouseClick);
            // 
            // FrmRegistroVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 745);
            this.Controls.Add(this.panelRegistroVendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistroVendas";
            this.Text = "FrmRegistroVendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRegistroVendas_Load);
            this.panelRegistroVendas.ResumeLayout(false);
            this.panelRegistroVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProdutosVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVRegistrosVendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelRegistroVendas;
        private DataGridView dGVProdutosVendas;
        private DataGridView dGVRegistrosVendas;
        private Label label2;
        private Label label1;
    }
}