namespace WinFormsUI
{
    partial class FrmRegistroCompras
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
            this.panelRegistroCompras = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dGVProdutosCompras = new System.Windows.Forms.DataGridView();
            this.dGVRegistrosCompras = new System.Windows.Forms.DataGridView();
            this.panelRegistroCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProdutosCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVRegistrosCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRegistroCompras
            // 
            this.panelRegistroCompras.Controls.Add(this.label2);
            this.panelRegistroCompras.Controls.Add(this.label1);
            this.panelRegistroCompras.Controls.Add(this.dGVProdutosCompras);
            this.panelRegistroCompras.Controls.Add(this.dGVRegistrosCompras);
            this.panelRegistroCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegistroCompras.Location = new System.Drawing.Point(0, 0);
            this.panelRegistroCompras.Name = "panelRegistroCompras";
            this.panelRegistroCompras.Size = new System.Drawing.Size(1010, 745);
            this.panelRegistroCompras.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Produtos por compra:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Registros de Compras:";
            // 
            // dGVProdutosCompras
            // 
            this.dGVProdutosCompras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dGVProdutosCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVProdutosCompras.Location = new System.Drawing.Point(39, 400);
            this.dGVProdutosCompras.Name = "dGVProdutosCompras";
            this.dGVProdutosCompras.RowHeadersWidth = 51;
            this.dGVProdutosCompras.RowTemplate.Height = 29;
            this.dGVProdutosCompras.Size = new System.Drawing.Size(935, 305);
            this.dGVProdutosCompras.TabIndex = 5;
            // 
            // dGVRegistrosCompras
            // 
            this.dGVRegistrosCompras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dGVRegistrosCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVRegistrosCompras.Location = new System.Drawing.Point(39, 48);
            this.dGVRegistrosCompras.Name = "dGVRegistrosCompras";
            this.dGVRegistrosCompras.RowHeadersWidth = 51;
            this.dGVRegistrosCompras.RowTemplate.Height = 29;
            this.dGVRegistrosCompras.Size = new System.Drawing.Size(935, 305);
            this.dGVRegistrosCompras.TabIndex = 4;
            this.dGVRegistrosCompras.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGVRegistrosCompras_CellMouseClick);
            // 
            // FrmRegistroCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 745);
            this.Controls.Add(this.panelRegistroCompras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistroCompras";
            this.Text = "FrmRegistroCompras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelRegistroCompras.ResumeLayout(false);
            this.panelRegistroCompras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProdutosCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVRegistrosCompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelRegistroCompras;
        private Label label2;
        private Label label1;
        private DataGridView dGVProdutosCompras;
        private DataGridView dGVRegistrosCompras;
    }
}