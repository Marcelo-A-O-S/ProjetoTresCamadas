using ProjetoTresCamadas.Bussines.Services;
using ProjetoTresCamadas.DTO.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class FrmLogin : Form
    {
        FrmMenuPrincipal frmMenu;
        private List<Funcionario> funcionarios = new();
        private Funcionario funcionario = new();
        private GestaoFuncionarios gestaoFuncionarios = new();
        public FrmLogin(FrmMenuPrincipal frmMenu)
        {
            InitializeComponent();
            this.frmMenu = frmMenu;
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void btnAcessar_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxNome.Text == String.Empty || textBoxSenha.Text == String.Empty)
                {
                    MessageBox.Show("Informe os dados");
                }
                else
                {
                    funcionario = funcionarios.Where(x => x.Nome == textBoxNome.Text && x.Senha == textBoxSenha.Text).FirstOrDefault();
                    if(funcionario == null)
                    {
                        MessageBox.Show("Informe os campos corretamente");
                    }
                    else
                    {
                        frmMenu.funcionario = funcionario;
                        this.Close();
                        return;
                    }
                    
                }
            }catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            funcionarios = gestaoFuncionarios.ObterFuncionarios().Result.ToList();
        }
    }
}
