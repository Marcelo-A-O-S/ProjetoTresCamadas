namespace WinFormsUI
{
    partial class FrmListagemClientes
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
            this.PanelHome = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHome
            // 
            this.PanelHome.AutoScroll = true;
            this.PanelHome.AutoSize = true;
            this.PanelHome.Controls.Add(this.label1);
            this.PanelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHome.Location = new System.Drawing.Point(0, 0);
            this.PanelHome.Name = "PanelHome";
            this.PanelHome.Size = new System.Drawing.Size(800, 450);
            this.PanelHome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listagem de Clientes";
            // 
            // FrmListagemClientes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListagemClientes";
            this.Text = "FrmListagemClientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PanelHome.ResumeLayout(false);
            this.PanelHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel PanelHome;
        private Label label1;
    }
}