namespace WinFormsUI
{
    partial class FrmGerenciarCategoria
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditarCategoria = new System.Windows.Forms.Button();
            this.btnCadastrarCategoria = new System.Windows.Forms.Button();
            this.btnRemoverCategoria = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textCategoriasProdutos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCategorias = new System.Windows.Forms.DataGridView();
            this.panelGerenciarCategoria = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnEditarCategoria);
            this.groupBox1.Controls.Add(this.btnCadastrarCategoria);
            this.groupBox1.Controls.Add(this.btnRemoverCategoria);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textCategoriasProdutos);
            this.groupBox1.Location = new System.Drawing.Point(289, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Categoria";
            // 
            // btnEditarCategoria
            // 
            this.btnEditarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCategoria.Location = new System.Drawing.Point(167, 109);
            this.btnEditarCategoria.Name = "btnEditarCategoria";
            this.btnEditarCategoria.Size = new System.Drawing.Size(105, 42);
            this.btnEditarCategoria.TabIndex = 19;
            this.btnEditarCategoria.Text = "Editar";
            this.btnEditarCategoria.UseVisualStyleBackColor = true;
            this.btnEditarCategoria.Click += new System.EventHandler(this.btnEditarCategoria_Click);
            // 
            // btnCadastrarCategoria
            // 
            this.btnCadastrarCategoria.BackColor = System.Drawing.Color.Navy;
            this.btnCadastrarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarCategoria.Location = new System.Drawing.Point(309, 109);
            this.btnCadastrarCategoria.Name = "btnCadastrarCategoria";
            this.btnCadastrarCategoria.Size = new System.Drawing.Size(112, 42);
            this.btnCadastrarCategoria.TabIndex = 18;
            this.btnCadastrarCategoria.Text = "Cadastrar ";
            this.btnCadastrarCategoria.UseVisualStyleBackColor = false;
            this.btnCadastrarCategoria.Click += new System.EventHandler(this.btnCadastrarCategoria_Click);
            // 
            // btnRemoverCategoria
            // 
            this.btnRemoverCategoria.BackColor = System.Drawing.Color.Red;
            this.btnRemoverCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverCategoria.ForeColor = System.Drawing.Color.White;
            this.btnRemoverCategoria.Location = new System.Drawing.Point(20, 109);
            this.btnRemoverCategoria.Name = "btnRemoverCategoria";
            this.btnRemoverCategoria.Size = new System.Drawing.Size(105, 42);
            this.btnRemoverCategoria.TabIndex = 17;
            this.btnRemoverCategoria.Text = "Remover";
            this.btnRemoverCategoria.UseVisualStyleBackColor = false;
            this.btnRemoverCategoria.Click += new System.EventHandler(this.btnRemoverCategoria_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categoria";
            // 
            // textCategoriasProdutos
            // 
            this.textCategoriasProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCategoriasProdutos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textCategoriasProdutos.Location = new System.Drawing.Point(34, 59);
            this.textCategoriasProdutos.Name = "textCategoriasProdutos";
            this.textCategoriasProdutos.PlaceholderText = "Digite aqui o nome da categoria de produtos";
            this.textCategoriasProdutos.Size = new System.Drawing.Size(370, 20);
            this.textCategoriasProdutos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerenciar Categorias dos Produtos";
            // 
            // dataGridViewCategorias
            // 
            this.dataGridViewCategorias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewCategorias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategorias.Location = new System.Drawing.Point(251, 264);
            this.dataGridViewCategorias.Name = "dataGridViewCategorias";
            this.dataGridViewCategorias.RowHeadersWidth = 51;
            this.dataGridViewCategorias.RowTemplate.Height = 29;
            this.dataGridViewCategorias.Size = new System.Drawing.Size(512, 393);
            this.dataGridViewCategorias.TabIndex = 1;
            this.dataGridViewCategorias.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCategorias_CellMouseClick);
            // 
            // panelGerenciarCategoria
            // 
            this.panelGerenciarCategoria.AutoSize = true;
            this.panelGerenciarCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGerenciarCategoria.Location = new System.Drawing.Point(0, 0);
            this.panelGerenciarCategoria.Name = "panelGerenciarCategoria";
            this.panelGerenciarCategoria.Size = new System.Drawing.Size(1010, 686);
            this.panelGerenciarCategoria.TabIndex = 2;
            this.panelGerenciarCategoria.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGerenciarCategoria_Paint);
            // 
            // FrmGerenciarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 686);
            this.Controls.Add(this.dataGridViewCategorias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelGerenciarCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGerenciarCategoria";
            this.Text = "FrmGerenciarProduto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmGerenciarCategoria_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private TextBox textCategoriasProdutos;
        private Label label1;
        private Button btnEditarCategoria;
        private Button btnCadastrarCategoria;
        private Button btnRemoverCategoria;
        private DataGridView dataGridViewCategorias;
        private Panel panelGerenciarCategoria;
    }
}