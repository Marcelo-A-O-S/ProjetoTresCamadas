using DTO.Entidades;
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
    public partial class FrmBuscarVendaCliente : Form
    {
        private GestaoClientes gestaoClientes = new();
        private GestaoVendas gestaoVendas = new();
        private GestaoProdutosVendidos gestaoProdutos = new();
        private Venda venda = new();
        private ProdutoVendido produtoVendido = new();

        public FrmBuscarVendaCliente()
        {
            InitializeComponent();
            CarregarComboxCliente();
            CarregarDgvVendas();
            CarregarDgvProdutos();
        }

        private void CarregarDgvProdutos()
        {
            dGVProdutosVendas.EditMode = DataGridViewEditMode.EditProgrammatically;
            dGVProdutosVendas.MultiSelect = false;
            dGVProdutosVendas.ColumnCount = 12;
            dGVProdutosVendas.Columns[0].HeaderText = "Id";
            dGVProdutosVendas.Columns[0].DataPropertyName = "Id";
            dGVProdutosVendas.Columns[0].Name = "Id";
            dGVProdutosVendas.Columns[0].Visible = false;
            dGVProdutosVendas.Columns[1].HeaderText = "Nome do Produto";
            dGVProdutosVendas.Columns[1].DataPropertyName = "NomeProduto";
            dGVProdutosVendas.Columns[1].Name = "NomeProduto";
            dGVProdutosVendas.Columns[1].Width = 150;
            dGVProdutosVendas.Columns[2].HeaderText = "Valor do Produto";
            dGVProdutosVendas.Columns[2].DataPropertyName = "ValorProduto";
            dGVProdutosVendas.Columns[2].Name = "ValorProduto";
            dGVProdutosVendas.Columns[2].Width = 150;
            dGVProdutosVendas.Columns[3].HeaderText = "Valor total do produto";
            dGVProdutosVendas.Columns[3].DataPropertyName = "ValorTotalProduto";
            dGVProdutosVendas.Columns[3].Name = "ValorTotalProduto";
            dGVProdutosVendas.Columns[3].Width = 150;
            dGVProdutosVendas.Columns[4].HeaderText = "Quantidade de Produtos";
            dGVProdutosVendas.Columns[4].DataPropertyName = "QuantidadeProdutos";
            dGVProdutosVendas.Columns[4].Name = "QuantidadeProdutos";
            dGVProdutosVendas.Columns[4].Width = 150;
            dGVProdutosVendas.Columns[5].HeaderText = "ClienteId";
            dGVProdutosVendas.Columns[5].DataPropertyName = "ClienteId";
            dGVProdutosVendas.Columns[5].Name = "ClienteId";
            dGVProdutosVendas.Columns[5].Visible = false;
            dGVProdutosVendas.Columns[6].HeaderText = "Nome do Cliente";
            dGVProdutosVendas.Columns[6].DataPropertyName = "NomeCliente";
            dGVProdutosVendas.Columns[6].Name = "NomeCliente";
            dGVProdutosVendas.Columns[6].Width = 150;
            dGVProdutosVendas.Columns[7].HeaderText = "VendaId";
            dGVProdutosVendas.Columns[7].DataPropertyName = "VendaId";
            dGVProdutosVendas.Columns[7].Name = "VendaId";
            dGVProdutosVendas.Columns[7].Visible = false;
            dGVProdutosVendas.Columns[8].HeaderText = "venda";
            dGVProdutosVendas.Columns[8].DataPropertyName = "venda";
            dGVProdutosVendas.Columns[8].Name = "venda";
            dGVProdutosVendas.Columns[8].Visible = false;
            dGVProdutosVendas.Columns[9].HeaderText = "CategoriaId";
            dGVProdutosVendas.Columns[9].DataPropertyName = "CategoriaId";
            dGVProdutosVendas.Columns[9].Name = "CategoriaId";
            dGVProdutosVendas.Columns[9].Visible = false;
            dGVProdutosVendas.Columns[10].HeaderText = "Categoria";
            dGVProdutosVendas.Columns[10].DataPropertyName = "CategoriaNome";
            dGVProdutosVendas.Columns[10].Name = "CategoriaNome";
            dGVProdutosVendas.Columns[10].Width = 150;
            dGVProdutosVendas.Columns[11].HeaderText = "categoria";
            dGVProdutosVendas.Columns[11].DataPropertyName = "categoria";
            dGVProdutosVendas.Columns[11].Name = "categoria";
            dGVProdutosVendas.Columns[11].Visible = false;
        }

        private void CarregarDgvVendas()
        {
            dGVVendas.EditMode = DataGridViewEditMode.EditProgrammatically;
            dGVVendas.MultiSelect = false;
            dGVVendas.ColumnCount = 12;
            dGVVendas.Columns[0].HeaderText = "Id";
            dGVVendas.Columns[0].DataPropertyName = "Id";
            dGVVendas.Columns[0].Name = "Id";
            dGVVendas.Columns[0].Visible = false;
            dGVVendas.Columns[1].HeaderText = "Tipo de Pagamento";
            dGVVendas.Columns[1].DataPropertyName = "TipoDePagamento";
            dGVVendas.Columns[1].Name = "TipoDePagamento";
            dGVVendas.Columns[1].Width = 150;
            dGVVendas.Columns[2].HeaderText = "Quantidade de Produtos vendidos";
            dGVVendas.Columns[2].DataPropertyName = "QuantidadeVendidos";
            dGVVendas.Columns[2].Name = "QuantidadeVendidos";
            dGVVendas.Columns[2].Width = 150;
            dGVVendas.Columns[3].HeaderText = "Data da venda";
            dGVVendas.Columns[3].DataPropertyName = "DataDaVenda";
            dGVVendas.Columns[3].Name = "DataDaVenda";
            dGVVendas.Columns[3].Width = 150;
            dGVVendas.Columns[4].HeaderText = "Pagamento Realizado";
            dGVVendas.Columns[4].DataPropertyName = "PagamentoRealizado";
            dGVVendas.Columns[4].Name = "PagamentoRealizado";
            dGVVendas.Columns[4].Width = 150;
            dGVVendas.Columns[5].HeaderText = "Valor total da venda";
            dGVVendas.Columns[5].DataPropertyName = "ValorTotal";
            dGVVendas.Columns[5].Name = "ValorTotal";
            dGVVendas.Columns[6].HeaderText = "ClienteId";
            dGVVendas.Columns[6].DataPropertyName = "ClienteId";
            dGVVendas.Columns[6].Name = "ClienteId";
            dGVVendas.Columns[6].Visible = false;
            dGVVendas.Columns[7].HeaderText = "Nome do Cliente";
            dGVVendas.Columns[7].DataPropertyName = "NomeCliente";
            dGVVendas.Columns[7].Name = "NomeCliente";
            dGVVendas.Columns[8].HeaderText = "FuncionarioId";
            dGVVendas.Columns[8].DataPropertyName = "FuncionarioId";
            dGVVendas.Columns[8].Name = "FuncionarioId";
            dGVVendas.Columns[8].Visible = false;
            dGVVendas.Columns[9].HeaderText = "Nome do Funcionario";
            dGVVendas.Columns[9].DataPropertyName = "NomeFuncionario";
            dGVVendas.Columns[9].Name = "NomeFuncionario";
            dGVVendas.Columns[10].HeaderText = "cliente";
            dGVVendas.Columns[10].DataPropertyName = "cliente";
            dGVVendas.Columns[10].Name = "cliente";
            dGVVendas.Columns[10].Visible = false;
            dGVVendas.Columns[11].HeaderText = "funcionario";
            dGVVendas.Columns[11].DataPropertyName = "funcionario";
            dGVVendas.Columns[11].Name = "funcionario";
            dGVVendas.Columns[11].Visible = false;
        }

        private async void CarregarComboxCliente()
        {
            var retorno = gestaoClientes.ObterClientes().Result.Select(x => x.Nome).ToList();
            comboBoxClienteVenda.DataSource = retorno;
            comboBoxClienteVenda.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void btnBuscarVendas_Click(object sender, EventArgs e)
        {
            if(comboBoxClienteVenda.Text == String.Empty)
            {
                MessageBox.Show("Preencha o campo Cliente!");
            }
            else
            {
                dGVVendas.DataSource = gestaoVendas.ObterVendas().Result.Where(x => x.NomeCliente == comboBoxClienteVenda.Text).ToList();
            }
        }

        private async void dGVVendas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dGVVendas.SelectedCells.Count == 1)
            {
                MessageBox.Show("Selecione pelo indice da tabela!");
            }
            if(dGVVendas.SelectedRows.Count > 0)
            {
                var line = dGVVendas.SelectedRows[0];
                var id = Convert.ToInt32(line.Cells["Id"].Value.ToString());
                dGVProdutosVendas.DataSource = gestaoProdutos.ObterProdutosVendidos().Result.Where(x => x.VendaId == id).ToList();
            }
        }

        private async void dGVProdutosVendas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dGVProdutosVendas.SelectedCells.Count == 1)
            {
                MessageBox.Show("Selecione o indice da tabela!");
            }
            if(dGVProdutosVendas.SelectedRows.Count > 0)
            {
                var line = dGVProdutosVendas.SelectedRows[0];
                var id = Convert.ToInt32(line.Cells["Id"].Value.ToString());
                produtoVendido = await gestaoProdutos.BuscarProdutoVendidoPor(x => x.Id == id);
            }
        }

        private async void btnRemoverVenda_Click(object sender, EventArgs e)
        {
            try
            {
                if (dGVProdutosVendas.SelectedRows.Count > 0)
                {
                    var line = dGVProdutosVendas.SelectedRows[0];
                    var id = Convert.ToInt32(line.Cells["Id"].Value.ToString());
                    produtoVendido = await gestaoProdutos.BuscarProdutoVendidoPor(x => x.Id == id);
                    var retorno = gestaoProdutos.ExcluirProdutoVendido(produtoVendido);
                    MessageBox.Show(retorno);
                    venda = await gestaoVendas.BuscarVendaPor(x=> x.Id == produtoVendido.VendaId);
                    venda.QuantidadeVendidos = venda.QuantidadeVendidos - 1;
                    gestaoVendas.SalvarVenda(venda);
                }
                else
                {
                    MessageBox.Show("Selecione um registro de produto antes de prosseguir");
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            
        }

        
    }
}
