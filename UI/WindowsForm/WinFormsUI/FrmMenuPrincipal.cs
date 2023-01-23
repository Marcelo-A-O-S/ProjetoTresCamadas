using ProjetoTresCamadas.Bussines.Services;
using ProjetoTresCamadas.DTO.Entidades;

namespace WinFormsUI
{
    public partial class FrmMenuPrincipal : Form
    {
        public Funcionario funcionario = new();
        public Form FormAtivo;
        private GestaoVendas GestaoVendas = new();
        private GestaoCompra GestaoCompra = new();
        public FrmMenuPrincipal()
        {
            var frmlogin = new FrmLogin(this);
            frmlogin.ShowDialog();
            InitializeComponent();
            CustomizacaoMenu();
            //MostrarForm(new FrmHome());

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
            DropdownVendas.Visible = false;
            DropdownCompras.Visible = false;
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
            if (DropdownVendas.Visible == true)
            {
                DropdownVendas.Visible = false;
            }
            if (DropdownCompras.Visible == true)
            {
                DropdownCompras.Visible = false;
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
            label1.Text = "Olá, seja bem vindo "+ funcionario.Nome;
            carregarDadosHome(); 
        }
        private void carregarDadosHome()
        {
            var compras = GestaoCompra.ObterCompras().Result;
            var vendas = GestaoVendas.ObterVendas().Result;
            labelValorVenda.Text = vendas.Sum(x => x.ValorPago).ToString();
            labelValorCompras.Text = compras.Sum(x => x.ValorPago).ToString();
            labelVendasHoje.Text = vendas.Where(x => x.DataDaVenda.Date == DateTime.Now.Date).Sum(x => x.ValorPago).ToString();
            labelGastosHoje.Text = compras.Where(x => x.DataDaCompra.Date == DateTime.Now.Date).Sum(x => x.ValorPago).ToString();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            carregarDadosHome();
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
        private void btnGerenciarCategoria_Click(object sender, EventArgs e)
        {
            MostrarForm(new FrmGerenciarCategoria());
        }
        private void btnGerenciarProduto_Click(object sender, EventArgs e)
        {
            MostrarForm(new FrmGerenciarProdutos());
        }
        private void btnVendas_Click(object sender, EventArgs e)
        {
            OpenDropdown(DropdownVendas);
        }
        private void btnGerenciarVendas_Click(object sender, EventArgs e)
        {
            MostrarForm(new FrmGerenciarVendas(funcionario));
        }
        private void btnRegistroVendas_Click(object sender, EventArgs e)
        {
            MostrarForm(new FrmRegistroVendas());
        }
        private void btnGerenciarVendasParceladas_Click(object sender, EventArgs e)
        {
            MostrarForm(new FrmGerenciarVendasParceladas());
        }

        private void btnBuscarVendaCliente_Click(object sender, EventArgs e)
        {
            MostrarForm(new FrmBuscarVendaCliente());
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            OpenDropdown(DropdownCompras);
        }

        private void btnGerenciarCompras_Click(object sender, EventArgs e)
        {
            MostrarForm(new FrmGerenciarCompras(funcionario));
        }

        private void btnRegistroCompra_Click(object sender, EventArgs e)
        {
            MostrarForm(new FrmRegistroCompras());
        }

        private void btnGerenciarCompraParcelada_Click(object sender, EventArgs e)
        {
            MostrarForm(new FrmGerenciarComprasParceladas());
        }

        private void btnBuscarCompraFornecedor_Click(object sender, EventArgs e)
        {
            MostrarForm(new FrmBuscarCompraFornecedor());
        }
    }
}