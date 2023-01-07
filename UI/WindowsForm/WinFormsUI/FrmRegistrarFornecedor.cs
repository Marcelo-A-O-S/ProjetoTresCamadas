using ProjetosTresCamadas.Data.Entidades;

using ProjetoTresCamadas.Bussines.Services;
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
    public partial class FrmRegistrarFornecedor : Form
    {
        private GestaoFornecedores gestaoFornecedores = new();
        private Fornecedor fornecedor = new();
        public FrmRegistrarFornecedor()
        {
            InitializeComponent();
        }

        private void btnCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            fornecedor.Id = 0;
            fornecedor.RazaoSocial = textRazaoSocialFornecedor.Text;
            fornecedor.NomeFantasia = textNomeFantasiaFornecedor.Text;
            fornecedor.CNPJ = textCnpjFornecedor.Text;
            fornecedor.Numeracao = Convert.ToInt32(textNumeroFornecedor.Text);
            fornecedor.Telefone = textTelefoneFornecedor.Text;
            fornecedor.Bairro = textBairroFornecedor.Text;
            fornecedor.Cep = textCepFornecedor.Text;
            fornecedor.Cidade = textCidadeFornecedor.Text;
            fornecedor.Rua = textRuaFornecedor.Text;
            var retorno = gestaoFornecedores.SalvarFornecedor(fornecedor);
            MessageBox.Show(retorno);
            RecarregarGrid();
        }
        private async void RecarregarGrid()
        {
            dataGridViewFornecedor.DataSource = await gestaoFornecedores.ObterFornecedores();
            //.Select(x => new { x.Nome, x.Telefone, x.Cep, x.Bairro, x.Cidade, x.Numeracao, x.CPF, x.Rua }).ToList();
        }
        private async void FrmRegistrarFornecedor_Load(object sender, EventArgs e)
        {
            dataGridViewFornecedor.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewFornecedor.MultiSelect = false;
            dataGridViewFornecedor.ColumnCount = 9;
            dataGridViewFornecedor.Columns[0].HeaderText = "Id";
            dataGridViewFornecedor.Columns[0].DataPropertyName = "Id";
            dataGridViewFornecedor.Columns[0].Name = "Id";
            dataGridViewFornecedor.Columns[0].HeaderText = "Razao Social";
            dataGridViewFornecedor.Columns[0].DataPropertyName = "RazaoSocial";
            dataGridViewFornecedor.Columns[0].Name = "RazaoSocial";
            dataGridViewFornecedor.Columns[1].HeaderText = "Nome Fantasia";
            dataGridViewFornecedor.Columns[1].DataPropertyName = "NomeFantasia";
            dataGridViewFornecedor.Columns[1].Name = "NomeFantasia";
            dataGridViewFornecedor.Columns[2].HeaderText = "Telefone";
            dataGridViewFornecedor.Columns[2].DataPropertyName = "Telefone";
            dataGridViewFornecedor.Columns[2].Name = "Telefone";
            dataGridViewFornecedor.Columns[3].HeaderText = "CNPJ";
            dataGridViewFornecedor.Columns[3].DataPropertyName = "CNPJ";
            dataGridViewFornecedor.Columns[3].Name = "CNPJ";
            dataGridViewFornecedor.Columns[4].HeaderText = "Numeracao";
            dataGridViewFornecedor.Columns[4].DataPropertyName = "Numeracao";
            dataGridViewFornecedor.Columns[4].Name = "Numeracao";
            dataGridViewFornecedor.Columns[5].HeaderText = "Bairro";
            dataGridViewFornecedor.Columns[5].DataPropertyName = "Bairro";
            dataGridViewFornecedor.Columns[5].Name = "Bairro";
            dataGridViewFornecedor.Columns[6].HeaderText = "Cidade";
            dataGridViewFornecedor.Columns[6].DataPropertyName = "Cidade";
            dataGridViewFornecedor.Columns[6].Name = "Cidade";
            dataGridViewFornecedor.Columns[7].HeaderText = "CEP";
            dataGridViewFornecedor.Columns[7].DataPropertyName = "CEP";
            dataGridViewFornecedor.Columns[7].Name = "CEP";
            dataGridViewFornecedor.Columns[8].HeaderText = "Rua";
            dataGridViewFornecedor.Columns[8].DataPropertyName = "Rua";
            dataGridViewFornecedor.Columns[8].Name = "Rua";
            RecarregarGrid();
        }

        private void PanelRegistrarFornecedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewFornecedor_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewFornecedor.SelectedRows.Count > 0)
            {
                DataGridViewRow lines = dataGridViewFornecedor.SelectedRows[0];
                textRazaoSocialFornecedor.Text = (string)lines.Cells["RazaoSocial"].Value;
                textNomeFantasiaFornecedor.Text = (string)lines.Cells["NomeFantasia"].Value;
                textCnpjFornecedor.Text = (string)lines.Cells["CNPJ"].Value;
                textTelefoneFornecedor.Text = (string)lines.Cells["Telefone"].Value; ;
                textBairroFornecedor.Text = (string)lines.Cells["Bairro"].Value;
                textCepFornecedor.Text = (string)lines.Cells["CEP"].Value;
                textCidadeFornecedor.Text = (string)lines.Cells["Cidade"].Value;
                textNumeroFornecedor.Text = lines.Cells["Numeracao"].Value.ToString();
                textRuaFornecedor.Text = (string)lines.Cells["Rua"].Value;
                fornecedor.Id = (int)lines.Cells["Id"].Value;
            }
        }

        private void btnEditarFornecedor_Click(object sender, EventArgs e)
        {
            fornecedor.RazaoSocial = textRazaoSocialFornecedor.Text;
            fornecedor.NomeFantasia = textNomeFantasiaFornecedor.Text;
            fornecedor.CNPJ = textCnpjFornecedor.Text;
            fornecedor.Numeracao = Convert.ToInt32(textNumeroFornecedor.Text);
            fornecedor.Telefone = textTelefoneFornecedor.Text;
            fornecedor.Bairro = textBairroFornecedor.Text;
            fornecedor.Cep = textCepFornecedor.Text;
            fornecedor.Cidade = textCidadeFornecedor.Text;
            fornecedor.Rua = textRuaFornecedor.Text;
            var retorno = gestaoFornecedores.SalvarFornecedor(fornecedor);
            MessageBox.Show(retorno);
            RecarregarGrid();
        }

        private void btnRemoverFornecedor_Click(object sender, EventArgs e)
        {
            fornecedor.RazaoSocial = textRazaoSocialFornecedor.Text;
            fornecedor.NomeFantasia = textNomeFantasiaFornecedor.Text;
            fornecedor.CNPJ = textCnpjFornecedor.Text;
            fornecedor.Numeracao = Convert.ToInt32(textNumeroFornecedor.Text);
            fornecedor.Telefone = textTelefoneFornecedor.Text;
            fornecedor.Bairro = textBairroFornecedor.Text;
            fornecedor.Cep = textCepFornecedor.Text;
            fornecedor.Cidade = textCidadeFornecedor.Text;
            fornecedor.Rua = textRuaFornecedor.Text;
            var retorno = gestaoFornecedores.RemoverFornecedor(fornecedor);
            MessageBox.Show(retorno);
            RecarregarGrid();
        }
    }
}
