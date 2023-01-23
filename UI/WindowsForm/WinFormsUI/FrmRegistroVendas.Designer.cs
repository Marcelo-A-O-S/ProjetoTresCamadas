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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Produtos por venda";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registros de Venda";
            // 
            // dGVProdutosVendas
            // 
            this.dGVProdutosVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVProdutosVendas.BackgroundColor = System.Drawing.Color.White;
            this.dGVProdutosVendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.dGVProdutosVendas.Location = new System.Drawing.Point(36, 378);
            this.dGVProdutosVendas.Name = "dGVProdutosVendas";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVProdutosVendas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGVProdutosVendas.RowHeadersWidth = 51;
            this.dGVProdutosVendas.RowTemplate.Height = 29;
            this.dGVProdutosVendas.Size = new System.Drawing.Size(935, 305);
            this.dGVProdutosVendas.TabIndex = 1;
            // 
            // dGVRegistrosVendas
            // 
            this.dGVRegistrosVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVRegistrosVendas.BackgroundColor = System.Drawing.Color.White;
            this.dGVRegistrosVendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVRegistrosVendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dGVRegistrosVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVRegistrosVendas.DefaultCellStyle = dataGridViewCellStyle5;
            this.dGVRegistrosVendas.EnableHeadersVisualStyles = false;
            this.dGVRegistrosVendas.GridColor = System.Drawing.Color.Blue;
            this.dGVRegistrosVendas.Location = new System.Drawing.Point(36, 38);
            this.dGVRegistrosVendas.Name = "dGVRegistrosVendas";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVRegistrosVendas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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