namespace WinFormsUI
{
    partial class FrmRegistrarFuncionario
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
            this.panelRegistrarFuncionario = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewFuncionario = new System.Windows.Forms.DataGridView();
            this.groupRegistrarFuncionario = new System.Windows.Forms.GroupBox();
            this.btnEditarFuncionario = new System.Windows.Forms.Button();
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.textSenhaFuncionario = new System.Windows.Forms.TextBox();
            this.btnRemoverFuncionário = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textNumeroFuncionario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textRuaFuncionario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBairroFuncionario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textCidadeFuncionario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textCepFuncionario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textTelefoneFuncionario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textCpfFuncionario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNomeFuncionario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRegistrarFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionario)).BeginInit();
            this.groupRegistrarFuncionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRegistrarFuncionario
            // 
            this.panelRegistrarFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRegistrarFuncionario.AutoScroll = true;
            this.panelRegistrarFuncionario.AutoSize = true;
            this.panelRegistrarFuncionario.Controls.Add(this.label10);
            this.panelRegistrarFuncionario.Controls.Add(this.dataGridViewFuncionario);
            this.panelRegistrarFuncionario.Controls.Add(this.groupRegistrarFuncionario);
            this.panelRegistrarFuncionario.Location = new System.Drawing.Point(0, 0);
            this.panelRegistrarFuncionario.Name = "panelRegistrarFuncionario";
            this.panelRegistrarFuncionario.Size = new System.Drawing.Size(1010, 686);
            this.panelRegistrarFuncionario.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(465, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Selecione o indice para editar ou remover um funcionário especifico:";
            // 
            // dataGridViewFuncionario
            // 
            this.dataGridViewFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFuncionario.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFuncionario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFuncionario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewFuncionario.EnableHeadersVisualStyles = false;
            this.dataGridViewFuncionario.GridColor = System.Drawing.Color.Blue;
            this.dataGridViewFuncionario.Location = new System.Drawing.Point(32, 382);
            this.dataGridViewFuncionario.Name = "dataGridViewFuncionario";
            this.dataGridViewFuncionario.RowHeadersWidth = 51;
            this.dataGridViewFuncionario.RowTemplate.Height = 29;
            this.dataGridViewFuncionario.Size = new System.Drawing.Size(937, 269);
            this.dataGridViewFuncionario.TabIndex = 2;
            this.dataGridViewFuncionario.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewFuncionario_CellMouseClick);
            // 
            // groupRegistrarFuncionario
            // 
            this.groupRegistrarFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupRegistrarFuncionario.AutoSize = true;
            this.groupRegistrarFuncionario.Controls.Add(this.btnEditarFuncionario);
            this.groupRegistrarFuncionario.Controls.Add(this.btnCadastrarFuncionario);
            this.groupRegistrarFuncionario.Controls.Add(this.textSenhaFuncionario);
            this.groupRegistrarFuncionario.Controls.Add(this.btnRemoverFuncionário);
            this.groupRegistrarFuncionario.Controls.Add(this.label9);
            this.groupRegistrarFuncionario.Controls.Add(this.textNumeroFuncionario);
            this.groupRegistrarFuncionario.Controls.Add(this.label8);
            this.groupRegistrarFuncionario.Controls.Add(this.textRuaFuncionario);
            this.groupRegistrarFuncionario.Controls.Add(this.label7);
            this.groupRegistrarFuncionario.Controls.Add(this.textBairroFuncionario);
            this.groupRegistrarFuncionario.Controls.Add(this.label6);
            this.groupRegistrarFuncionario.Controls.Add(this.textCidadeFuncionario);
            this.groupRegistrarFuncionario.Controls.Add(this.label5);
            this.groupRegistrarFuncionario.Controls.Add(this.textCepFuncionario);
            this.groupRegistrarFuncionario.Controls.Add(this.label4);
            this.groupRegistrarFuncionario.Controls.Add(this.textTelefoneFuncionario);
            this.groupRegistrarFuncionario.Controls.Add(this.label3);
            this.groupRegistrarFuncionario.Controls.Add(this.textCpfFuncionario);
            this.groupRegistrarFuncionario.Controls.Add(this.label2);
            this.groupRegistrarFuncionario.Controls.Add(this.textNomeFuncionario);
            this.groupRegistrarFuncionario.Controls.Add(this.label1);
            this.groupRegistrarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupRegistrarFuncionario.Location = new System.Drawing.Point(32, 23);
            this.groupRegistrarFuncionario.Name = "groupRegistrarFuncionario";
            this.groupRegistrarFuncionario.Size = new System.Drawing.Size(936, 328);
            this.groupRegistrarFuncionario.TabIndex = 1;
            this.groupRegistrarFuncionario.TabStop = false;
            this.groupRegistrarFuncionario.Text = "Registrar Funcionário";
            // 
            // btnEditarFuncionario
            // 
            this.btnEditarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarFuncionario.Location = new System.Drawing.Point(630, 260);
            this.btnEditarFuncionario.Name = "btnEditarFuncionario";
            this.btnEditarFuncionario.Size = new System.Drawing.Size(105, 42);
            this.btnEditarFuncionario.TabIndex = 18;
            this.btnEditarFuncionario.Text = "Editar";
            this.btnEditarFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.BackColor = System.Drawing.Color.Navy;
            this.btnCadastrarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(764, 260);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(105, 42);
            this.btnCadastrarFuncionario.TabIndex = 2;
            this.btnCadastrarFuncionario.Text = "Cadastrar ";
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = false;
            this.btnCadastrarFuncionario.Click += new System.EventHandler(this.btnCadastrarFuncionario_Click);
            // 
            // textSenhaFuncionario
            // 
            this.textSenhaFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSenhaFuncionario.Location = new System.Drawing.Point(68, 109);
            this.textSenhaFuncionario.Name = "textSenhaFuncionario";
            this.textSenhaFuncionario.Size = new System.Drawing.Size(350, 20);
            this.textSenhaFuncionario.TabIndex = 17;
            // 
            // btnRemoverFuncionário
            // 
            this.btnRemoverFuncionário.BackColor = System.Drawing.Color.Red;
            this.btnRemoverFuncionário.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverFuncionário.ForeColor = System.Drawing.Color.White;
            this.btnRemoverFuncionário.Location = new System.Drawing.Point(495, 260);
            this.btnRemoverFuncionário.Name = "btnRemoverFuncionário";
            this.btnRemoverFuncionário.Size = new System.Drawing.Size(105, 42);
            this.btnRemoverFuncionário.TabIndex = 1;
            this.btnRemoverFuncionário.Text = "Remover";
            this.btnRemoverFuncionário.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Senha para acesso";
            // 
            // textNumeroFuncionario
            // 
            this.textNumeroFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNumeroFuncionario.Location = new System.Drawing.Point(752, 212);
            this.textNumeroFuncionario.Name = "textNumeroFuncionario";
            this.textNumeroFuncionario.Size = new System.Drawing.Size(117, 20);
            this.textNumeroFuncionario.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(752, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Numero da casa";
            // 
            // textRuaFuncionario
            // 
            this.textRuaFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textRuaFuncionario.Location = new System.Drawing.Point(494, 212);
            this.textRuaFuncionario.Name = "textRuaFuncionario";
            this.textRuaFuncionario.Size = new System.Drawing.Size(252, 20);
            this.textRuaFuncionario.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(494, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Rua";
            // 
            // textBairroFuncionario
            // 
            this.textBairroFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBairroFuncionario.Location = new System.Drawing.Point(496, 161);
            this.textBairroFuncionario.Name = "textBairroFuncionario";
            this.textBairroFuncionario.Size = new System.Drawing.Size(373, 20);
            this.textBairroFuncionario.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bairro";
            // 
            // textCidadeFuncionario
            // 
            this.textCidadeFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCidadeFuncionario.Location = new System.Drawing.Point(496, 109);
            this.textCidadeFuncionario.Name = "textCidadeFuncionario";
            this.textCidadeFuncionario.Size = new System.Drawing.Size(373, 20);
            this.textCidadeFuncionario.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cidade";
            // 
            // textCepFuncionario
            // 
            this.textCepFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCepFuncionario.Location = new System.Drawing.Point(496, 56);
            this.textCepFuncionario.Name = "textCepFuncionario";
            this.textCepFuncionario.Size = new System.Drawing.Size(373, 20);
            this.textCepFuncionario.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "CEP";
            // 
            // textTelefoneFuncionario
            // 
            this.textTelefoneFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTelefoneFuncionario.Location = new System.Drawing.Point(68, 211);
            this.textTelefoneFuncionario.Name = "textTelefoneFuncionario";
            this.textTelefoneFuncionario.Size = new System.Drawing.Size(350, 20);
            this.textTelefoneFuncionario.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone";
            // 
            // textCpfFuncionario
            // 
            this.textCpfFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCpfFuncionario.Location = new System.Drawing.Point(68, 159);
            this.textCpfFuncionario.Name = "textCpfFuncionario";
            this.textCpfFuncionario.Size = new System.Drawing.Size(350, 20);
            this.textCpfFuncionario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF";
            // 
            // textNomeFuncionario
            // 
            this.textNomeFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNomeFuncionario.Location = new System.Drawing.Point(68, 56);
            this.textNomeFuncionario.Name = "textNomeFuncionario";
            this.textNomeFuncionario.Size = new System.Drawing.Size(350, 20);
            this.textNomeFuncionario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // FrmRegistrarFuncionario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1010, 686);
            this.Controls.Add(this.panelRegistrarFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistrarFuncionario";
            this.Text = "FrmRegistrarFuncionario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRegistrarFuncionario_Load);
            this.panelRegistrarFuncionario.ResumeLayout(false);
            this.panelRegistrarFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionario)).EndInit();
            this.groupRegistrarFuncionario.ResumeLayout(false);
            this.groupRegistrarFuncionario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelRegistrarFuncionario;
        private Button btnCadastrarFuncionario;
        private Button btnRemoverFuncionário;
        private GroupBox groupRegistrarFuncionario;
        private TextBox textSenhaFuncionario;
        private Label label9;
        private TextBox textNumeroFuncionario;
        private Label label8;
        private TextBox textRuaFuncionario;
        private Label label7;
        private TextBox textBairroFuncionario;
        private Label label6;
        private TextBox textCidadeFuncionario;
        private Label label5;
        private TextBox textCepFuncionario;
        private Label label4;
        private TextBox textTelefoneFuncionario;
        private Label label3;
        private TextBox textCpfFuncionario;
        private Label label2;
        private TextBox textNomeFuncionario;
        private Label label1;
        private DataGridView dataGridViewFuncionario;
        private Label label10;
        private Button btnEditarFuncionario;
    }
}