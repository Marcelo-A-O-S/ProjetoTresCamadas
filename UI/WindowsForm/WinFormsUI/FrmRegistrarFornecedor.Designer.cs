namespace WinFormsUI
{
    partial class FrmRegistrarFornecedor
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
            this.PanelRegistrarFornecedor = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewFornecedor = new System.Windows.Forms.DataGridView();
            this.groupRegistrarFornecedor = new System.Windows.Forms.GroupBox();
            this.btnEditarFornecedor = new System.Windows.Forms.Button();
            this.textNomeFantasiaFornecedor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCadastrarFornecedor = new System.Windows.Forms.Button();
            this.textNumeroFornecedor = new System.Windows.Forms.TextBox();
            this.btnRemoverFornecedor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textRuaFornecedor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBairroFornecedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textCidadeFornecedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textCepFornecedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textTelefoneFornecedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textCnpjFornecedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textRazaoSocialFornecedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelRegistrarFornecedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedor)).BeginInit();
            this.groupRegistrarFornecedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelRegistrarFornecedor
            // 
            this.PanelRegistrarFornecedor.Controls.Add(this.label10);
            this.PanelRegistrarFornecedor.Controls.Add(this.dataGridViewFornecedor);
            this.PanelRegistrarFornecedor.Controls.Add(this.groupRegistrarFornecedor);
            this.PanelRegistrarFornecedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRegistrarFornecedor.Location = new System.Drawing.Point(0, 0);
            this.PanelRegistrarFornecedor.Name = "PanelRegistrarFornecedor";
            this.PanelRegistrarFornecedor.Size = new System.Drawing.Size(1010, 686);
            this.PanelRegistrarFornecedor.TabIndex = 0;
            this.PanelRegistrarFornecedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelRegistrarFornecedor_Paint);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(463, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Selecione o indice para editar ou remover um fornecedor especifico:";
            // 
            // dataGridViewFornecedor
            // 
            this.dataGridViewFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFornecedor.Location = new System.Drawing.Point(36, 402);
            this.dataGridViewFornecedor.Name = "dataGridViewFornecedor";
            this.dataGridViewFornecedor.RowHeadersWidth = 51;
            this.dataGridViewFornecedor.RowTemplate.Height = 29;
            this.dataGridViewFornecedor.Size = new System.Drawing.Size(937, 269);
            this.dataGridViewFornecedor.TabIndex = 2;
            this.dataGridViewFornecedor.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewFornecedor_CellMouseClick);
            // 
            // groupRegistrarFornecedor
            // 
            this.groupRegistrarFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupRegistrarFornecedor.AutoSize = true;
            this.groupRegistrarFornecedor.Controls.Add(this.btnEditarFornecedor);
            this.groupRegistrarFornecedor.Controls.Add(this.textNomeFantasiaFornecedor);
            this.groupRegistrarFornecedor.Controls.Add(this.label9);
            this.groupRegistrarFornecedor.Controls.Add(this.btnCadastrarFornecedor);
            this.groupRegistrarFornecedor.Controls.Add(this.textNumeroFornecedor);
            this.groupRegistrarFornecedor.Controls.Add(this.btnRemoverFornecedor);
            this.groupRegistrarFornecedor.Controls.Add(this.label8);
            this.groupRegistrarFornecedor.Controls.Add(this.textRuaFornecedor);
            this.groupRegistrarFornecedor.Controls.Add(this.label7);
            this.groupRegistrarFornecedor.Controls.Add(this.textBairroFornecedor);
            this.groupRegistrarFornecedor.Controls.Add(this.label6);
            this.groupRegistrarFornecedor.Controls.Add(this.textCidadeFornecedor);
            this.groupRegistrarFornecedor.Controls.Add(this.label5);
            this.groupRegistrarFornecedor.Controls.Add(this.textCepFornecedor);
            this.groupRegistrarFornecedor.Controls.Add(this.label4);
            this.groupRegistrarFornecedor.Controls.Add(this.textTelefoneFornecedor);
            this.groupRegistrarFornecedor.Controls.Add(this.label3);
            this.groupRegistrarFornecedor.Controls.Add(this.textCnpjFornecedor);
            this.groupRegistrarFornecedor.Controls.Add(this.label2);
            this.groupRegistrarFornecedor.Controls.Add(this.textRazaoSocialFornecedor);
            this.groupRegistrarFornecedor.Controls.Add(this.label1);
            this.groupRegistrarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupRegistrarFornecedor.Location = new System.Drawing.Point(37, 41);
            this.groupRegistrarFornecedor.Name = "groupRegistrarFornecedor";
            this.groupRegistrarFornecedor.Size = new System.Drawing.Size(936, 319);
            this.groupRegistrarFornecedor.TabIndex = 1;
            this.groupRegistrarFornecedor.TabStop = false;
            this.groupRegistrarFornecedor.Text = "Registrar Fornecedor";
            // 
            // btnEditarFornecedor
            // 
            this.btnEditarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarFornecedor.Location = new System.Drawing.Point(622, 251);
            this.btnEditarFornecedor.Name = "btnEditarFornecedor";
            this.btnEditarFornecedor.Size = new System.Drawing.Size(112, 42);
            this.btnEditarFornecedor.TabIndex = 18;
            this.btnEditarFornecedor.Text = "Editar";
            this.btnEditarFornecedor.UseVisualStyleBackColor = true;
            this.btnEditarFornecedor.Click += new System.EventHandler(this.btnEditarFornecedor_Click);
            // 
            // textNomeFantasiaFornecedor
            // 
            this.textNomeFantasiaFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNomeFantasiaFornecedor.Location = new System.Drawing.Point(70, 113);
            this.textNomeFantasiaFornecedor.Name = "textNomeFantasiaFornecedor";
            this.textNomeFantasiaFornecedor.Size = new System.Drawing.Size(350, 20);
            this.textNomeFantasiaFornecedor.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nome Fantasia";
            // 
            // btnCadastrarFornecedor
            // 
            this.btnCadastrarFornecedor.BackColor = System.Drawing.Color.Navy;
            this.btnCadastrarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarFornecedor.Location = new System.Drawing.Point(765, 251);
            this.btnCadastrarFornecedor.Name = "btnCadastrarFornecedor";
            this.btnCadastrarFornecedor.Size = new System.Drawing.Size(112, 42);
            this.btnCadastrarFornecedor.TabIndex = 2;
            this.btnCadastrarFornecedor.Text = "Cadastrar ";
            this.btnCadastrarFornecedor.UseVisualStyleBackColor = false;
            this.btnCadastrarFornecedor.Click += new System.EventHandler(this.btnCadastrarFornecedor_Click);
            // 
            // textNumeroFornecedor
            // 
            this.textNumeroFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNumeroFornecedor.Location = new System.Drawing.Point(748, 214);
            this.textNumeroFornecedor.Name = "textNumeroFornecedor";
            this.textNumeroFornecedor.Size = new System.Drawing.Size(129, 20);
            this.textNumeroFornecedor.TabIndex = 15;
            // 
            // btnRemoverFornecedor
            // 
            this.btnRemoverFornecedor.BackColor = System.Drawing.Color.Red;
            this.btnRemoverFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnRemoverFornecedor.Location = new System.Drawing.Point(481, 251);
            this.btnRemoverFornecedor.Name = "btnRemoverFornecedor";
            this.btnRemoverFornecedor.Size = new System.Drawing.Size(105, 42);
            this.btnRemoverFornecedor.TabIndex = 1;
            this.btnRemoverFornecedor.Text = "Remover";
            this.btnRemoverFornecedor.UseVisualStyleBackColor = false;
            this.btnRemoverFornecedor.Click += new System.EventHandler(this.btnRemoverFornecedor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(748, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Número do local";
            // 
            // textRuaFornecedor
            // 
            this.textRuaFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textRuaFornecedor.Location = new System.Drawing.Point(481, 214);
            this.textRuaFornecedor.Name = "textRuaFornecedor";
            this.textRuaFornecedor.Size = new System.Drawing.Size(256, 20);
            this.textRuaFornecedor.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(481, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Rua";
            // 
            // textBairroFornecedor
            // 
            this.textBairroFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBairroFornecedor.Location = new System.Drawing.Point(481, 161);
            this.textBairroFornecedor.Name = "textBairroFornecedor";
            this.textBairroFornecedor.Size = new System.Drawing.Size(396, 20);
            this.textBairroFornecedor.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(481, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bairro";
            // 
            // textCidadeFornecedor
            // 
            this.textCidadeFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCidadeFornecedor.Location = new System.Drawing.Point(481, 113);
            this.textCidadeFornecedor.Name = "textCidadeFornecedor";
            this.textCidadeFornecedor.Size = new System.Drawing.Size(396, 20);
            this.textCidadeFornecedor.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cidade";
            // 
            // textCepFornecedor
            // 
            this.textCepFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCepFornecedor.Location = new System.Drawing.Point(481, 61);
            this.textCepFornecedor.Name = "textCepFornecedor";
            this.textCepFornecedor.Size = new System.Drawing.Size(396, 20);
            this.textCepFornecedor.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "CEP";
            // 
            // textTelefoneFornecedor
            // 
            this.textTelefoneFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTelefoneFornecedor.Location = new System.Drawing.Point(70, 211);
            this.textTelefoneFornecedor.Name = "textTelefoneFornecedor";
            this.textTelefoneFornecedor.Size = new System.Drawing.Size(350, 20);
            this.textTelefoneFornecedor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone";
            // 
            // textCnpjFornecedor
            // 
            this.textCnpjFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCnpjFornecedor.Location = new System.Drawing.Point(70, 161);
            this.textCnpjFornecedor.Name = "textCnpjFornecedor";
            this.textCnpjFornecedor.Size = new System.Drawing.Size(350, 20);
            this.textCnpjFornecedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "CNPJ";
            // 
            // textRazaoSocialFornecedor
            // 
            this.textRazaoSocialFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textRazaoSocialFornecedor.Location = new System.Drawing.Point(70, 61);
            this.textRazaoSocialFornecedor.Name = "textRazaoSocialFornecedor";
            this.textRazaoSocialFornecedor.Size = new System.Drawing.Size(350, 20);
            this.textRazaoSocialFornecedor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Razão Social";
            // 
            // FrmRegistrarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 686);
            this.Controls.Add(this.PanelRegistrarFornecedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistrarFornecedor";
            this.Text = "FrmRegistrarFornecedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRegistrarFornecedor_Load);
            this.PanelRegistrarFornecedor.ResumeLayout(false);
            this.PanelRegistrarFornecedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedor)).EndInit();
            this.groupRegistrarFornecedor.ResumeLayout(false);
            this.groupRegistrarFornecedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelRegistrarFornecedor;
        private GroupBox groupRegistrarFornecedor;
        private Button btnCadastrarFornecedor;
        private TextBox textNumeroFornecedor;
        private Button btnRemoverFornecedor;
        private Label label8;
        private TextBox textRuaFornecedor;
        private Label label7;
        private TextBox textBairroFornecedor;
        private Label label6;
        private TextBox textCidadeFornecedor;
        private Label label5;
        private TextBox textCepFornecedor;
        private Label label4;
        private TextBox textTelefoneFornecedor;
        private Label label3;
        private TextBox textCnpjFornecedor;
        private Label label2;
        private TextBox textRazaoSocialFornecedor;
        private Label label1;
        private TextBox textNomeFantasiaFornecedor;
        private Label label9;
        private DataGridView dataGridViewFornecedor;
        private Label label10;
        private Button btnEditarFornecedor;
    }
}