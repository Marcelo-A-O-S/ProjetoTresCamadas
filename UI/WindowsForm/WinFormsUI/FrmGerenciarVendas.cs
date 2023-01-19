using DTO.Entidades;
using Microsoft.IdentityModel.Tokens;
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
    public partial class FrmGerenciarVendas : Form
    {
        private GestaoProdutos gestaoProdutos = new();
        private GestaoFuncionarios gestaoFuncionarios = new();
        private GestaoProdutosVendidos gestaoProdutosVendidos = new();
        private GestaoCategorias gestaoCategorias = new();
        private GestaoClientes gestaoClientes = new();
        private GestaoVendasParceladas gestaoVendasParceladas = new();
        private GestaoVendas gestaoVendas = new();
        private List<Venda> vendas = new();
        private List<ProdutoVendido> produtos = new();
        private ProdutoVendido produtoVendidoAcesso = new();
        private Produto produto = new();
        private Cliente cliente = new();
        private Funcionario funcionario = new();
        private Venda venda = new();
        private Categoria categoria = new();
        public FrmGerenciarVendas()
        {
            InitializeComponent();
        }

        private void FrmGerenciarVendas_Load(object sender, EventArgs e)
        {

            carregarComboBoxCategoria();
            carregarComboBoxFuncionario();
            carregarComboBoxProduto();
            carregarComboBoxCliente();
            carregarDgvVendaHeader();
        }
        private void carregarDgvVendaHeader()
        {
            dataGridViewVendas.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewVendas.MultiSelect = false;
            dataGridViewVendas.ColumnCount = 9;
            dataGridViewVendas.Columns[0].HeaderText = "Id";
            dataGridViewVendas.Columns[0].DataPropertyName = "Id";
            dataGridViewVendas.Columns[0].Name = "Id";
            dataGridViewVendas.Columns[0].Visible = false;
            dataGridViewVendas.Columns[1].HeaderText = "Nome do Produto";
            dataGridViewVendas.Columns[1].DataPropertyName = "NomeProduto";
            dataGridViewVendas.Columns[1].Name = "NomeProduto";
            dataGridViewVendas.Columns[1].Width = 180;
            dataGridViewVendas.Columns[2].HeaderText = "ValorProduto";
            dataGridViewVendas.Columns[2].DataPropertyName = "ValorProduto";
            dataGridViewVendas.Columns[2].Name = "ValorProduto";
            dataGridViewVendas.Columns[2].Width = 180;
            dataGridViewVendas.Columns[3].HeaderText = "Categoria";
            dataGridViewVendas.Columns[3].DataPropertyName = "CategoriaId";
            dataGridViewVendas.Columns[3].Name = "CategoriaId";
            dataGridViewVendas.Columns[3].Visible = false;
            dataGridViewVendas.Columns[4].HeaderText = "Nome da Categoria";
            dataGridViewVendas.Columns[4].DataPropertyName = "CategoriaNome";
            dataGridViewVendas.Columns[4].Name = "CategoriaNome";
            dataGridViewVendas.Columns[5].HeaderText = "Quantidade de Produtos";
            dataGridViewVendas.Columns[5].DataPropertyName = "QuantidadeProdutos";
            dataGridViewVendas.Columns[5].Name = "QuantidadeProdutos";
            dataGridViewVendas.Columns[6].HeaderText = "ClienteId";
            dataGridViewVendas.Columns[6].DataPropertyName = "ClienteId";
            dataGridViewVendas.Columns[6].Name = "ClienteId";
            dataGridViewVendas.Columns[6].Visible = false;
            dataGridViewVendas.Columns[7].HeaderText = "Nome do Cliente";
            dataGridViewVendas.Columns[7].DataPropertyName = "NomeCliente";
            dataGridViewVendas.Columns[7].Name = "NomeCliente";
            dataGridViewVendas.Columns[8].HeaderText = "Valor total do produto";
            dataGridViewVendas.Columns[8].DataPropertyName = "ValorTotalProduto";
            dataGridViewVendas.Columns[8].Name = "ValorTotalProduto";
           
        }
        private void dataGridViewVendas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dataGridViewVendas.SelectedRows.Count > 0)
                {
                    DataGridViewRow lines = dataGridViewVendas.SelectedRows[0];
                    comboBoxProduto.Text = lines.Cells["NomeProduto"].Value.ToString();
                    comboBoxCategoria.Text = lines.Cells["CategoriaNome"].Value.ToString();
                    comboBoxCliente.Text = lines.Cells["NomeCliente"].Value.ToString();
                    textBoxQuantidade.Text = lines.Cells["QuantidadeProdutos"].Value.ToString();
                    produtoVendidoAcesso.NomeCliente = lines.Cells["NomeCliente"].Value.ToString();
                    produtoVendidoAcesso.QuantidadeProdutos = Convert.ToInt32(lines.Cells["QuantidadeProdutos"].Value);
                    produtoVendidoAcesso.NomeProduto = lines.Cells["NomeProduto"].Value.ToString();
                    produtoVendidoAcesso.CategoriaNome = lines.Cells["CategoriaNome"].Value.ToString();
                    produtoVendidoAcesso.Id = (int)lines.Cells["Id"].Value;
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            
        }
        private void btnRemoverVenda_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewVendas.SelectedRows.Count > 0)
                {
                    produtoVendidoAcesso = produtos.Find(x => x.Id == produtoVendidoAcesso.Id);
                    venda.ValorTotal = venda.ValorTotal - produtoVendidoAcesso.ValorTotalProduto;
                    labelValorTotal.Text = venda.ValorTotal.ToString();
                    produtos.Remove(produtoVendidoAcesso);
                    venda.QuantidadeVendidos = produtos.Count;
                    RecarregarDgvVendas();
                }
                else
                {
                    MessageBox.Show("Selecione o indice para prosseguir");
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            } 
        }
        private async void carregarComboBoxCliente()
        {
            comboBoxCliente.DataSource = gestaoClientes.ObterClientes().Result.Select(x => x.Nome).ToList();
            comboBoxCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }
        private async void carregarComboBoxProduto()
        {
            comboBoxProduto.DataSource = gestaoProdutos.ObterProdutos().Result.Select(x=> x.Nome).ToList();
        }
        private async void carregarComboBoxFuncionario()
        {
            comboBoxFuncionario.DataSource = gestaoFuncionarios.ObterFuncionarios().Result.Select(x => x.Nome).ToList();
        }
        private async void carregarComboBoxCategoria()
        {
            comboBoxCategoria.DataSource = gestaoCategorias.ObterCategorias().Result.Select(x => x.TipoCategoria).ToList();
        }
        private void comboBoxCliente_TextUpdate(object sender, EventArgs e)
        {

        }
        private void comboBoxCliente_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBoxPagamento_TextChanged(object sender, EventArgs e)
        {
            if(comboBoxPagamento.Text == "Venda Parcelada")
            {
                textBoxParcelas.ReadOnly = false;
            }
            if (comboBoxPagamento.Text != "Venda Parcelada")
            {
                textBoxParcelas.ReadOnly = true;
            }
        }
        private async void btnAdicionarVenda_Click(object sender, EventArgs e)
        {
            if(comboBoxCategoria.Text != string.Empty && comboBoxProduto.Text != string.Empty && comboBoxCliente.Text != string.Empty && comboBoxFuncionario.Text != string.Empty && textBoxQuantidade.Text != string.Empty)
            {
                ProdutoVendido produtoVendido = new();
                categoria = await gestaoCategorias.BuscarCategoriaPor(x => x.TipoCategoria == comboBoxCategoria.Text);
                produto = await gestaoProdutos.BuscarProdutoPor(x => x.Nome == comboBoxProduto.Text);
                cliente = await gestaoClientes.BuscarCliente(x => x.Nome == comboBoxCliente.Text);
                funcionario = await gestaoFuncionarios.BuscarFuncionarioPor(x => x.Nome == comboBoxFuncionario.Text);
                produtoVendido.Id = venda.QuantidadeVendidos;
                produtoVendido.NomeProduto = produto.Nome;
                produtoVendido.ValorProduto = produto.Preco;
                produtoVendido.QuantidadeProdutos = Convert.ToInt32(textBoxQuantidade.Text);
                produtoVendido.ValorTotalProduto = produtoVendido.QuantidadeProdutos * produtoVendido.ValorProduto;
                produtoVendido.ClienteId = cliente.Id;
                produtoVendido.NomeCliente = cliente.Nome;
                produtoVendido.CategoriaId = categoria.Id;
                produtoVendido.CategoriaNome = categoria.TipoCategoria;
                venda.ValorTotal += produtoVendido.ValorTotalProduto;
                produtos.Add(produtoVendido);
                venda.QuantidadeVendidos = produtos.Count;
                labelValorTotal.Text = venda.ValorTotal.ToString();
                RecarregarDgvVendas();
            }
            else
            {
                MessageBox.Show("Prencha os campos corretamente!");
            }
               
        }
        private void RecarregarDgvVendas()
        {
            dataGridViewVendas.DataSource = produtos.ToList();
        }
        private void btnLimparVendas_Click(object sender, EventArgs e)
        {
            LimparCampoVenda();
            
        }
        private void LimparCampoVenda()
        {
            produtos.Clear();
            venda.ValorTotal = venda.ValorTotal - venda.ValorTotal;
            venda.QuantidadeVendidos = produtos.Count;
            labelValorTotal.Text = venda.ValorTotal.ToString();
            RecarregarDgvVendas();
        }
        private async void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            if(produtos.Count != 0)
            {
                if (comboBoxPagamento.Text != string.Empty)
                {
                    cliente = await gestaoClientes.BuscarCliente(x => x.Nome == comboBoxCliente.Text);
                    funcionario = await gestaoFuncionarios.BuscarFuncionarioPor(x => x.Nome == comboBoxFuncionario.Text);
                    venda.Id = 0;
                    venda.QuantidadeVendidos = produtos.Count;
                    venda.FuncionarioId = funcionario.Id;
                    venda.NomeFuncionario = funcionario.Nome;
                    venda.ClienteId = cliente.Id;
                    venda.NomeCliente = cliente.Nome;
                    venda.DataDaVenda = DateTime.Now;
                    venda.TipoDePagamento = comboBoxPagamento.Text;
                    venda.ValorPago = Convert.ToDecimal(textBoxValorPago.Text);
                    var retorno = gestaoVendas.SalvarVenda(venda);
                    MessageBox.Show(retorno);
                    venda = await gestaoVendas.BuscarVendaPor(x => x.Id == venda.Id);
                    foreach (var produto in produtos)
                    {
                        produto.Id = 0;
                        produto.VendaId = venda.Id;
                        gestaoProdutosVendidos.SalvarProdutoVendido(produto);
                    }

                    if (venda.TipoDePagamento == "Venda Parcelada")
                    {
                        var vendaParcelada = new VendaParcelada();
                        vendaParcelada.VendaId = venda.Id;
                        vendaParcelada.QuantidadeParcelas = Convert.ToInt32(textBoxParcelas.Text) ;
                        vendaParcelada.ParcelasRestantes = vendaParcelada.QuantidadeParcelas - 1;
                        vendaParcelada.ValorDaParcela = venda.ValorTotal / (vendaParcelada.QuantidadeParcelas );
                        vendaParcelada.ValorTotal = venda.ValorTotal;
                        vendaParcelada.ValorRestante = vendaParcelada.ValorDaParcela - vendaParcelada.ValorTotal;
                        vendaParcelada.MesInicial = DateTime.Now.Month;
                        vendaParcelada.MesFinal = DateTime.Now.AddMonths(vendaParcelada.ParcelasRestantes).Month;
                        vendaParcelada.DataPagamentoInicial = venda.DataDaVenda;
                        vendaParcelada.ValorPago = venda.ValorPago;
                        retorno = gestaoVendasParceladas.SalvarVendaParcelada(vendaParcelada);
                        MessageBox.Show(retorno);
                        MessageBox.Show("Receba o valor inicial da primeira parcela antes de prosseguir!");
                        
                    }
                    else
                    {
                        venda.PagamentoRealizado = true;
                        gestaoVendas.SalvarVenda(venda);
                    }
                    LimparCampoVenda();
                }
                else
                {
                    MessageBox.Show("Preencha os campos que faltam corretamente");
                }
            }
            else
            {
                MessageBox.Show("A lista de produtos para vendas está vazia, adicione algum produto para prosseguir com a venda");
            }
            
            
        }
    }
}
