using ProjetoTresCamadas.Bussines.Services;
using ProjetoTresCamadas.DTO.Entidades;

namespace WinFormsUI
{
    public partial class FrmGerenciarCategoria : Form
    {
        private GestaoCategorias gestaoCategorias = new();
        private Categoria categoria = new();
        public FrmGerenciarCategoria()
        {
            InitializeComponent();
        }

        private void btnCadastrarCategoria_Click(object sender, EventArgs e)
        {
            categoria.Id = 0;
            categoria.TipoCategoria = textCategoriasProdutos.Text;
            var result = gestaoCategorias.SalvarCategoria(categoria);
            MessageBox.Show(result);
            RecarregarGrid();
        }

        private void FrmGerenciarCategoria_Load(object sender, EventArgs e)
        {
            dataGridViewCategorias.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewCategorias.MultiSelect = false;
            dataGridViewCategorias.ColumnCount = 2;
            dataGridViewCategorias.Columns[0].HeaderText = "Id";
            dataGridViewCategorias.Columns[0].DataPropertyName = "Id";
            dataGridViewCategorias.Columns[0].Name = "Id";
            dataGridViewCategorias.Columns[0].Width = 210;
            dataGridViewCategorias.Columns[1].HeaderText = "Nome da Categoria";
            dataGridViewCategorias.Columns[1].DataPropertyName = "TipoCategoria";
            dataGridViewCategorias.Columns[1].Name = "TipoCategoria";
            dataGridViewCategorias.Columns[1].Width = 250;
            RecarregarGrid();
        }
        private async void RecarregarGrid()
        {
           
            dataGridViewCategorias.DataSource = await gestaoCategorias.ObterCategorias();
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            categoria.TipoCategoria = textCategoriasProdutos.Text;
            var result = gestaoCategorias.SalvarCategoria(categoria);
            MessageBox.Show(result);
            RecarregarGrid();
        }

        private void btnRemoverCategoria_Click(object sender, EventArgs e)
        {
            categoria.TipoCategoria = textCategoriasProdutos.Text;
            var result = gestaoCategorias.ExcluirCategoria(categoria);
            MessageBox.Show(result);
            RecarregarGrid();
        }

        private void dataGridViewCategorias_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dataGridViewCategorias.SelectedRows.Count > 0)
            {
                DataGridViewRow lines = dataGridViewCategorias.SelectedRows[0];
                textCategoriasProdutos.Text = lines.Cells["TipoCategoria"].Value.ToString();
                categoria.Id = (int)lines.Cells["Id"].Value;
            }
        }

        private void panelGerenciarCategoria_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
