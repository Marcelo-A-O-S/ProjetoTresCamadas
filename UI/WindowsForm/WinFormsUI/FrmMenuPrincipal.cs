namespace WinFormsUI
{
    public partial class FrmMenuPrincipal : Form
    {
        public Form FormAtivo;
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            CustomizacaoMenu();
        }
        private void Redimensionamento()
        {
            var Frm = PanelContent.Controls[0].FindForm();
            if (Frm.Name != "FrmMenuPrincipal")
            {
                Frm.WindowState = FormWindowState.Normal;
                Frm.WindowState = FormWindowState.Maximized;
            }
        }
        private void CustomizacaoMenu()
        {
            DropdownCliente.Visible = false;
            DropdownFuncionarios.Visible = false;
            DropdownProdutos.Visible = false;
            DropdownFornecedores.Visible = false;

        }
        private void MostrarForm(Form Frm)
        {
            FecharFormsAtivado();
            FormAtivo = Frm;
            Frm.TopLevel = false;
            PanelContent.Controls.Add(Frm);
            Frm.BringToFront();
            Frm.Show();
        }
        private void FecharFormsAtivado()
        {
            if(FormAtivo != null)
            {
                FormAtivo.Close();
            }
        }
        private void CloseDropdown()
        {
            if(DropdownCliente.Visible == true)
            {
                DropdownCliente.Visible = false;
            }
            if(DropdownFuncionarios.Visible == true)
            {
                DropdownFuncionarios.Visible = false;
            }
            if (DropdownFornecedores.Visible == true)
            {
                DropdownFornecedores.Visible = false;
            }
            if (DropdownProdutos.Visible == true)
            {
                DropdownProdutos.Visible = false;
            }

        }
        private void OpenDropdown(Panel DropdownName)
        {
            if(DropdownName.Visible == false)
            {
                CloseDropdown();
                DropdownName.Visible = true;
            }
            else
            {
                DropdownName.Visible = false;
            }
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            OpenDropdown(DropdownFuncionarios);
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            OpenDropdown(DropdownFornecedores);
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            OpenDropdown(DropdownProdutos);
        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            OpenDropdown(DropdownCliente);
        }

        private void btnClienteRegistrar_Click(object sender, EventArgs e)
        {
            MostrarForm(new FrmRegistrarCliente());
        }

        private void FrmMenuPrincipal_SizeChanged(object sender, EventArgs e)
        {
            
            Redimensionamento();
        }

        private void btnClienteRemove_Click(object sender, EventArgs e)
        {
            MostrarForm(new FrmRemoverCliente());
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FecharFormsAtivado();
        }

        private void btnClienteListar_Click(object sender, EventArgs e)
        {
            MostrarForm(new FrmListagemClientes());
        }

        private void btnFuncionarioRegistrar_Click(object sender, EventArgs e)
        {
            MostrarForm(new FrmRegistrarFuncionario());
        }

        private void btnFornecedorRegistrar_Click(object sender, EventArgs e)
        {
            MostrarForm(new FrmRegistrarFornecedor());
        }
    }
}