
using ProjetoTresCamadas.Bussines.Services;
using ProjetoTresCamadas.DTO.Entidades;

namespace WinFormsUI
{
    public partial class FrmGerenciarProdutos : Form
    {
        private GestaoCategorias gestaoCategorias = new();
        private GestaoProdutos gestaoProdutos = new();
        private Categoria categoria = new();
        private static IList<Categoria> categorias;
        private Produto produto = new();
        public FrmGerenciarProdutos()
        {
            InitializeComponent();
        }

        private void FrmGerenciarProdutos_Load(object sender, EventArgs e)
        {
            dataGridViewProdutos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewProdutos.MultiSelect = false;
            dataGridViewProdutos.ColumnCount = 7;
            dataGridViewProdutos.Columns[0].HeaderText = "Id";
            dataGridViewProdutos.Columns[0].DataPropertyName = "Id";
            dataGridViewProdutos.Columns[0].Name = "Id";
            dataGridViewProdutos.Columns[0].Visible = false;
            dataGridViewProdutos.Columns[1].HeaderText = "Nome do Produto";
            dataGridViewProdutos.Columns[1].DataPropertyName = "Nome";
            dataGridViewProdutos.Columns[1].Name = "Nome";
            dataGridViewProdutos.Columns[1].Width = 180;
            dataGridViewProdutos.Columns[2].HeaderText = "Descricao";
            dataGridViewProdutos.Columns[2].DataPropertyName = "Descricao";
            dataGridViewProdutos.Columns[2].Name = "Descricao";
            dataGridViewProdutos.Columns[2].Width = 270;
            dataGridViewProdutos.Columns[3].HeaderText = "Categoria";
            dataGridViewProdutos.Columns[3].DataPropertyName = "CategoriaId";
            dataGridViewProdutos.Columns[3].Name = "CategoriaId";
            dataGridViewProdutos.Columns[4].HeaderText = "Estoque";
            dataGridViewProdutos.Columns[4].DataPropertyName = "Estoque";
            dataGridViewProdutos.Columns[4].Name = "Estoque";
            dataGridViewProdutos.Columns[5].HeaderText = "Preco";
            dataGridViewProdutos.Columns[5].DataPropertyName = "Preco";
            dataGridViewProdutos.Columns[5].Name = "Preco";
            dataGridViewProdutos.Columns[5].Width = 180;
            dataGridViewProdutos.Columns[6].HeaderText = "categoria";
            dataGridViewProdutos.Columns[6].DataPropertyName = "categoria";
            dataGridViewProdutos.Columns[6].Name = "categoria";
            dataGridViewProdutos.Columns[6].Visible = false;
            RecarregarGrid();
            RecarregarComboBoxCategoria();
            
        }
        private async void RecarregarGrid()
        {
            dataGridViewProdutos.DataSource = await gestaoProdutos.ObterProdutos();
        }
        private async void RecarregarComboBoxCategoria()
        {
            categorias = await gestaoCategorias.ObterCategorias();
            foreach (var categoria in categorias)
            {
                comboBoxCategoriaProdutos.Items.Add(categoria.TipoCategoria);
            }
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            produto.Id = 0;
            produto.Nome = textNomeProduto.Text;
            produto.Preco = Convert.ToDecimal(textValorProduto.Text);
            produto.Descricao = textDescricaoProduto.Text;
            produto.Estoque = Convert.ToInt32(textEstoqueProduto.Text);
            produto.CategoriaId = categorias.FirstOrDefault(x => x.TipoCategoria == comboBoxCategoriaProdutos.Text).Id;
            var retorno = gestaoProdutos.SalvarProduto(produto);
            MessageBox.Show(retorno);
            RecarregarGrid();
        }

        private void btnEditarProduto_Click(object sender, EventArgs e)
        {
            produto.Nome = textNomeProduto.Text;
            produto.Preco = Convert.ToDecimal(textValorProduto.Text);
            produto.Descricao = textDescricaoProduto.Text;
            produto.Estoque = Convert.ToInt32(textEstoqueProduto.Text);
            produto.CategoriaId = categorias.FirstOrDefault(x => x.TipoCategoria == comboBoxCategoriaProdutos.Text).Id;
            var retorno = gestaoProdutos.SalvarProduto(produto);
            MessageBox.Show(retorno);
            RecarregarGrid();
        }

        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            produto.Nome = textNomeProduto.Text;
            produto.Preco = Convert.ToDecimal(textValorProduto.Text);
            produto.Descricao = textDescricaoProduto.Text;
            produto.Estoque = Convert.ToInt32(textEstoqueProduto.Text);
            produto.CategoriaId = categorias.FirstOrDefault(x => x.TipoCategoria == comboBoxCategoriaProdutos.Text).Id;
            var retorno = gestaoProdutos.ExcluirProduto(produto);
            MessageBox.Show(retorno);
            RecarregarGrid();
        }

        private void dataGridViewProdutos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dataGridViewProdutos.SelectedRows.Count > 0)
            {
                DataGridViewRow lines = dataGridViewProdutos.SelectedRows[0];
                textDescricaoProduto.Text = lines.Cells["Descricao"].Value.ToString();
                textEstoqueProduto.Text = lines.Cells["Estoque"].Value.ToString();
                textNomeProduto.Text = lines.Cells["Nome"].Value.ToString();
                textValorProduto.Text = lines.Cells["Preco"].Value.ToString();
                comboBoxCategoriaProdutos.Text = categorias.FirstOrDefault(x => x.Id == (int)lines.Cells["CategoriaId"].Value).TipoCategoria;
                produto.Id = (int)lines.Cells["Id"].Value;
            }
        }
    }
}
