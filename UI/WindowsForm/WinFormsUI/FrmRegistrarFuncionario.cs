
using ProjetoTresCamadas.Bussines.Services;
using ProjetoTresCamadas.DTO.Entidades;

namespace WinFormsUI
{
    public partial class FrmRegistrarFuncionario : Form
    {
        private GestaoFuncionarios gestaoFuncionarios = new();
        private Funcionario funcionario = new();
        public FrmRegistrarFuncionario()
        {
            InitializeComponent();
        }
        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            funcionario.Id = 0;
            funcionario.Nome = textNomeFuncionario.Text;
            funcionario.Senha = textSenhaFuncionario.Text;
            funcionario.Cep = textCepFuncionario.Text;
            funcionario.CPF = textCpfFuncionario.Text;
            funcionario.Bairro = textBairroFuncionario.Text;
            funcionario.Rua = textRuaFuncionario.Text;
            funcionario.Numeracao = Convert.ToInt32(textNumeroFuncionario.Text);
            funcionario.Cidade = textCidadeFuncionario.Text;
            funcionario.Telefone = textTelefoneFuncionario.Text;
            var retorno = gestaoFuncionarios.SalvarFuncionario(funcionario);
            MessageBox.Show(retorno);
            RecarregarGrid();
        }

        private void FrmRegistrarFuncionario_Load(object sender, EventArgs e)
        {
            dataGridViewFuncionario.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewFuncionario.MultiSelect = false;
            dataGridViewFuncionario.ColumnCount = 10;
            dataGridViewFuncionario.Columns[0].HeaderText = "Id";
            dataGridViewFuncionario.Columns[0].DataPropertyName = "Id";
            dataGridViewFuncionario.Columns[0].Name = "Id";
            dataGridViewFuncionario.Columns[0].Visible= false;
            dataGridViewFuncionario.Columns[1].HeaderText = "Nome";
            dataGridViewFuncionario.Columns[1].DataPropertyName = "Nome";
            dataGridViewFuncionario.Columns[1].Name = "Nome";
            dataGridViewFuncionario.Columns[1].Width = 210;
            dataGridViewFuncionario.Columns[2].HeaderText = "CPF";
            dataGridViewFuncionario.Columns[2].DataPropertyName = "CPF";
            dataGridViewFuncionario.Columns[2].Name = "CPF";
            dataGridViewFuncionario.Columns[3].HeaderText = "Telefone";
            dataGridViewFuncionario.Columns[3].DataPropertyName = "Telefone";
            dataGridViewFuncionario.Columns[3].Name = "Telefone";
            dataGridViewFuncionario.Columns[4].HeaderText = "Cidade";
            dataGridViewFuncionario.Columns[4].DataPropertyName = "Cidade";
            dataGridViewFuncionario.Columns[4].Name = "Cidade";
            dataGridViewFuncionario.Columns[4].Width = 220;
            dataGridViewFuncionario.Columns[5].HeaderText = "Rua";
            dataGridViewFuncionario.Columns[5].DataPropertyName = "Rua";
            dataGridViewFuncionario.Columns[5].Name = "Rua";
            dataGridViewFuncionario.Columns[5].Width = 220;
            dataGridViewFuncionario.Columns[6].HeaderText = "Bairro";
            dataGridViewFuncionario.Columns[6].DataPropertyName = "Bairro";
            dataGridViewFuncionario.Columns[6].Name = "Bairro";
            dataGridViewFuncionario.Columns[6].Width = 210;
            dataGridViewFuncionario.Columns[7].HeaderText = "Numero da Casa";
            dataGridViewFuncionario.Columns[7].DataPropertyName = "Numeracao";
            dataGridViewFuncionario.Columns[7].Name = "Numero da Casa";
            dataGridViewFuncionario.Columns[8].HeaderText = "CEP";
            dataGridViewFuncionario.Columns[8].DataPropertyName = "CEP";
            dataGridViewFuncionario.Columns[8].Name = "CEP";
            dataGridViewFuncionario.Columns[9].HeaderText = "Senha";
            dataGridViewFuncionario.Columns[9].DataPropertyName = "Senha";
            dataGridViewFuncionario.Columns[9].Name = "Senha";
            RecarregarGrid();
            
        }

        private async void RecarregarGrid()
        {
            dataGridViewFuncionario.DataSource = await gestaoFuncionarios.ObterFuncionarios();
        }

        private void dataGridViewFuncionario_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewFuncionario.SelectedRows.Count > 0)
            {
                DataGridViewRow lines = dataGridViewFuncionario.SelectedRows[0];
                textSenhaFuncionario.Text = (string)lines.Cells["Senha"].Value;
                textNomeFuncionario.Text = (string)lines.Cells["Nome"].Value;
                textCpfFuncionario.Text = (string)lines.Cells["CPF"].Value;
                textTelefoneFuncionario.Text = (string)lines.Cells["Telefone"].Value; ;
                textBairroFuncionario.Text = (string)lines.Cells["Bairro"].Value;
                textCepFuncionario.Text = (string)lines.Cells["CEP"].Value;
                textCidadeFuncionario.Text = (string)lines.Cells["Cidade"].Value;
                textNumeroFuncionario.Text = lines.Cells["Numero da Casa"].Value.ToString();
                textRuaFuncionario.Text = (string)lines.Cells["Rua"].Value;
                funcionario.Id = (int)lines.Cells["Id"].Value;
            }
        }
    }
}
