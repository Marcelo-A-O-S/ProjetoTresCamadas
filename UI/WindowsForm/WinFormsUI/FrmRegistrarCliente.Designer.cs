namespace WinFormsUI
{
    partial class FrmRegistrarCliente
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
            this.PanelRegistrarCliente = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.groupRegistrarCliente = new System.Windows.Forms.GroupBox();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.textNumeroCliente = new System.Windows.Forms.TextBox();
            this.btnRemoverCliente = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textRuaCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBairroCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textCidadeCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textCepCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textTelefoneCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textCpfCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNomeCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelRegistrarCliente.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.groupRegistrarCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelRegistrarCliente
            // 
            this.PanelRegistrarCliente.AutoScroll = true;
            this.PanelRegistrarCliente.AutoSize = true;
            this.PanelRegistrarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelRegistrarCliente.Controls.Add(this.panel1);
            this.PanelRegistrarCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRegistrarCliente.Location = new System.Drawing.Point(0, 0);
            this.PanelRegistrarCliente.Name = "PanelRegistrarCliente";
            this.PanelRegistrarCliente.Size = new System.Drawing.Size(1010, 686);
            this.PanelRegistrarCliente.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dataGridViewClientes);
            this.panel1.Controls.Add(this.groupRegistrarCliente);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 686);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(434, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Selecione o indice para editar ou remover um cliente especifico:";
            // 
            // dataGridViewClientes
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dataGridViewClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(38, 405);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.RowHeadersWidth = 51;
            this.dataGridViewClientes.RowTemplate.Height = 29;
            this.dataGridViewClientes.Size = new System.Drawing.Size(937, 269);
            this.dataGridViewClientes.TabIndex = 2;
            this.dataGridViewClientes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewClientes_CellMouseClick);
            // 
            // groupRegistrarCliente
            // 
            this.groupRegistrarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupRegistrarCliente.AutoSize = true;
            this.groupRegistrarCliente.Controls.Add(this.btnEditarCliente);
            this.groupRegistrarCliente.Controls.Add(this.btnCadastrarCliente);
            this.groupRegistrarCliente.Controls.Add(this.textNumeroCliente);
            this.groupRegistrarCliente.Controls.Add(this.btnRemoverCliente);
            this.groupRegistrarCliente.Controls.Add(this.label8);
            this.groupRegistrarCliente.Controls.Add(this.textRuaCliente);
            this.groupRegistrarCliente.Controls.Add(this.label7);
            this.groupRegistrarCliente.Controls.Add(this.textBairroCliente);
            this.groupRegistrarCliente.Controls.Add(this.label6);
            this.groupRegistrarCliente.Controls.Add(this.textCidadeCliente);
            this.groupRegistrarCliente.Controls.Add(this.label5);
            this.groupRegistrarCliente.Controls.Add(this.textCepCliente);
            this.groupRegistrarCliente.Controls.Add(this.label4);
            this.groupRegistrarCliente.Controls.Add(this.textTelefoneCliente);
            this.groupRegistrarCliente.Controls.Add(this.label3);
            this.groupRegistrarCliente.Controls.Add(this.textCpfCliente);
            this.groupRegistrarCliente.Controls.Add(this.label2);
            this.groupRegistrarCliente.Controls.Add(this.textNomeCliente);
            this.groupRegistrarCliente.Controls.Add(this.label1);
            this.groupRegistrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupRegistrarCliente.Location = new System.Drawing.Point(38, 48);
            this.groupRegistrarCliente.Name = "groupRegistrarCliente";
            this.groupRegistrarCliente.Size = new System.Drawing.Size(937, 310);
            this.groupRegistrarCliente.TabIndex = 1;
            this.groupRegistrarCliente.TabStop = false;
            this.groupRegistrarCliente.Text = "Registrar Cliente";
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCliente.Location = new System.Drawing.Point(652, 242);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(105, 42);
            this.btnEditarCliente.TabIndex = 16;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.BackColor = System.Drawing.Color.Navy;
            this.btnCadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCliente.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarCliente.Location = new System.Drawing.Point(785, 242);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(112, 42);
            this.btnCadastrarCliente.TabIndex = 2;
            this.btnCadastrarCliente.Text = "Cadastrar ";
            this.btnCadastrarCliente.UseVisualStyleBackColor = false;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click_1);
            // 
            // textNumeroCliente
            // 
            this.textNumeroCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNumeroCliente.Location = new System.Drawing.Point(780, 173);
            this.textNumeroCliente.Name = "textNumeroCliente";
            this.textNumeroCliente.Size = new System.Drawing.Size(117, 20);
            this.textNumeroCliente.TabIndex = 15;
            // 
            // btnRemoverCliente
            // 
            this.btnRemoverCliente.BackColor = System.Drawing.Color.Red;
            this.btnRemoverCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverCliente.ForeColor = System.Drawing.Color.White;
            this.btnRemoverCliente.Location = new System.Drawing.Point(501, 242);
            this.btnRemoverCliente.Name = "btnRemoverCliente";
            this.btnRemoverCliente.Size = new System.Drawing.Size(105, 42);
            this.btnRemoverCliente.TabIndex = 1;
            this.btnRemoverCliente.Text = "Remover";
            this.btnRemoverCliente.UseVisualStyleBackColor = false;
            this.btnRemoverCliente.Click += new System.EventHandler(this.btnRemoverCliente_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(780, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Numero da casa";
            // 
            // textRuaCliente
            // 
            this.textRuaCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textRuaCliente.Location = new System.Drawing.Point(501, 173);
            this.textRuaCliente.Name = "textRuaCliente";
            this.textRuaCliente.Size = new System.Drawing.Size(256, 20);
            this.textRuaCliente.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(501, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Rua";
            // 
            // textBairroCliente
            // 
            this.textBairroCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBairroCliente.Location = new System.Drawing.Point(501, 114);
            this.textBairroCliente.Name = "textBairroCliente";
            this.textBairroCliente.Size = new System.Drawing.Size(396, 20);
            this.textBairroCliente.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(501, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bairro";
            // 
            // textCidadeCliente
            // 
            this.textCidadeCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCidadeCliente.Location = new System.Drawing.Point(502, 59);
            this.textCidadeCliente.Name = "textCidadeCliente";
            this.textCidadeCliente.Size = new System.Drawing.Size(396, 20);
            this.textCidadeCliente.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cidade";
            // 
            // textCepCliente
            // 
            this.textCepCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCepCliente.Location = new System.Drawing.Point(42, 242);
            this.textCepCliente.Name = "textCepCliente";
            this.textCepCliente.Size = new System.Drawing.Size(396, 20);
            this.textCepCliente.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "CEP";
            // 
            // textTelefoneCliente
            // 
            this.textTelefoneCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTelefoneCliente.Location = new System.Drawing.Point(42, 173);
            this.textTelefoneCliente.Name = "textTelefoneCliente";
            this.textTelefoneCliente.Size = new System.Drawing.Size(396, 20);
            this.textTelefoneCliente.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone";
            // 
            // textCpfCliente
            // 
            this.textCpfCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCpfCliente.Location = new System.Drawing.Point(42, 114);
            this.textCpfCliente.Name = "textCpfCliente";
            this.textCpfCliente.Size = new System.Drawing.Size(396, 20);
            this.textCpfCliente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF";
            // 
            // textNomeCliente
            // 
            this.textNomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNomeCliente.Location = new System.Drawing.Point(42, 59);
            this.textNomeCliente.Name = "textNomeCliente";
            this.textNomeCliente.Size = new System.Drawing.Size(396, 20);
            this.textNomeCliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // FrmRegistrarCliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1010, 686);
            this.Controls.Add(this.PanelRegistrarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistrarCliente";
            this.Text = "FrmRegistrarCliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRegistrarCliente_Load);
            this.PanelRegistrarCliente.ResumeLayout(false);
            this.PanelRegistrarCliente.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.groupRegistrarCliente.ResumeLayout(false);
            this.groupRegistrarCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel PanelRegistrarCliente;
        private Panel panel1;
        private GroupBox groupRegistrarCliente;
        private Button btnCadastrarCliente;
        private TextBox textNumeroCliente;
        private Button btnRemoverCliente;
        private Label label8;
        private TextBox textRuaCliente;
        private Label label7;
        private TextBox textBairroCliente;
        private Label label6;
        private TextBox textCidadeCliente;
        private Label label5;
        private TextBox textCepCliente;
        private Label label4;
        private TextBox textTelefoneCliente;
        private Label label3;
        private TextBox textCpfCliente;
        private Label label2;
        private TextBox textNomeCliente;
        private Label label1;
        private DataGridView dataGridViewClientes;
        private Button btnEditarCliente;
        private Label label9;
    }
}