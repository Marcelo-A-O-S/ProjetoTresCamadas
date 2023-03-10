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
        private List<Cliente> clientes = new();
        private List<Produto> Produtos = new();
        private List<Categoria> categorias = new();
        private ProdutoVendido produtoVendidoAcesso = new();
        private Produto produto = new();
        private Cliente cliente = new();
        private Funcionario funcionario;
        private Venda venda = new();
        private Categoria categoria = new();
        public FrmGerenciarVendas(Funcionario funcionario)
        {
            InitializeComponent();
            this.funcionario = funcionario;
        }
        private void FrmGerenciarVendas_Load(object sender, EventArgs e)
        {
            carregarDados();
            carregarComboBoxCategoria();
            carregarComboBoxProduto();
            carregarComboBoxCliente();
            carregarDgvVendaHeader();
        }
        private void carregarDados()
        {
            clientes = gestaoClientes.ObterClientes().Result.ToList();
            Produtos = gestaoProdutos.ObterProdutos().Result.ToList();
            categorias = gestaoCategorias.ObterCategorias().Result.ToList();
        }
        private void carregarDgvVendaHeader()
        {
            dataGridViewVendas.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewVendas.MultiSelect = false;
            dataGridViewVendas.ColumnCount = 13;
            dataGridViewVendas.Columns[0].HeaderText = "Id";
            dataGridViewVendas.Columns[0].DataPropertyName = "Id";
            dataGridViewVendas.Columns[0].Name = "Id";
            dataGridViewVendas.Columns[0].Visible = false;
            dataGridViewVendas.Columns[1].HeaderText = "Nome do Produto";
            dataGridViewVendas.Columns[1].DataPropertyName = "NomeProduto";
            dataGridViewVendas.Columns[1].Name = "NomeProduto";
            dataGridViewVendas.Columns[1].Width = 250;
            dataGridViewVendas.Columns[2].HeaderText = "ValorProduto";
            dataGridViewVendas.Columns[2].DataPropertyName = "ValorProduto";
            dataGridViewVendas.Columns[2].Name = "ValorProduto";
            dataGridViewVendas.Columns[2].Width = 250;
            dataGridViewVendas.Columns[3].HeaderText = "Categoria";
            dataGridViewVendas.Columns[3].DataPropertyName = "CategoriaId";
            dataGridViewVendas.Columns[3].Name = "CategoriaId";
            dataGridViewVendas.Columns[3].Visible = false;
            dataGridViewVendas.Columns[4].HeaderText = "Nome da Categoria";
            dataGridViewVendas.Columns[4].DataPropertyName = "CategoriaNome";
            dataGridViewVendas.Columns[4].Name = "CategoriaNome";
            dataGridViewVendas.Columns[4].Width = 250;
            dataGridViewVendas.Columns[5].HeaderText = "Quantidade de Produtos";
            dataGridViewVendas.Columns[5].DataPropertyName = "QuantidadeProdutos";
            dataGridViewVendas.Columns[5].Name = "QuantidadeProdutos";
            dataGridViewVendas.Columns[5].Width = 250;
            dataGridViewVendas.Columns[6].HeaderText = "ClienteId";
            dataGridViewVendas.Columns[6].DataPropertyName = "ClienteId";
            dataGridViewVendas.Columns[6].Name = "ClienteId";
            dataGridViewVendas.Columns[6].Visible = false;
            dataGridViewVendas.Columns[7].HeaderText = "Nome do Cliente";
            dataGridViewVendas.Columns[7].DataPropertyName = "NomeCliente";
            dataGridViewVendas.Columns[7].Name = "NomeCliente";
            dataGridViewVendas.Columns[7].Width = 245;
            dataGridViewVendas.Columns[8].HeaderText = "Valor total do produto";
            dataGridViewVendas.Columns[8].DataPropertyName = "ValorTotalProduto";
            dataGridViewVendas.Columns[8].Name = "ValorTotalProduto";
            dataGridViewVendas.Columns[8].Width = 245;
            dataGridViewVendas.Columns[9].HeaderText = "cliente";
            dataGridViewVendas.Columns[9].DataPropertyName = "cliente";
            dataGridViewVendas.Columns[9].Name = "cliente";
            dataGridViewVendas.Columns[9].Visible = false;
            dataGridViewVendas.Columns[10].HeaderText = "venda";
            dataGridViewVendas.Columns[10].DataPropertyName = "venda";
            dataGridViewVendas.Columns[10].Name = "venda";
            dataGridViewVendas.Columns[10].Visible = false;
            dataGridViewVendas.Columns[11].HeaderText = "categoria";
            dataGridViewVendas.Columns[11].DataPropertyName = "categoria";
            dataGridViewVendas.Columns[11].Name = "categoria";
            dataGridViewVendas.Columns[11].Visible = false;
            dataGridViewVendas.Columns[12].HeaderText = "VendaId";
            dataGridViewVendas.Columns[12].DataPropertyName = "VendaId";
            dataGridViewVendas.Columns[12].Name = "VendaId";
            dataGridViewVendas.Columns[12].Visible = false;

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
            comboBoxCliente.DataSource = clientes.Select(x => x.Nome).ToList();
            comboBoxCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }
        private async void carregarComboBoxProduto()
        {
            var retornoCategoria = Produtos.Select(x => x.Nome).ToList();
            comboBoxProduto.DataSource = retornoCategoria;
            comboBoxCategoria.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }
        private async void carregarComboBoxCategoria()
        {
            comboBoxCategoria.DataSource = categorias.Select(x => x.TipoCategoria).ToList();
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
            if(comboBoxCategoria.Text != string.Empty && comboBoxProduto.Text != string.Empty && comboBoxCliente.Text != string.Empty  && textBoxQuantidade.Text != string.Empty)
            {
                ProdutoVendido produtoVendido = new();
                categoria = await gestaoCategorias.BuscarCategoriaPor(x => x.TipoCategoria == comboBoxCategoria.Text);
                produto = await gestaoProdutos.BuscarProdutoPor(x => x.Nome == comboBoxProduto.Text);
                cliente = await gestaoClientes.BuscarCliente(x => x.Nome == comboBoxCliente.Text);
                var quantidadeProdutos = Convert.ToInt32(textBoxQuantidade.Text);
                if(quantidadeProdutos <= produto.Estoque)
                {
                    produtoVendido.Id = venda.QuantidadeVendidos;
                    produtoVendido.NomeProduto = produto.Nome;
                    produtoVendido.ValorProduto = produto.Preco;
                    produtoVendido.QuantidadeProdutos = quantidadeProdutos;
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
                    MessageBox.Show("O produto está em falta, encomende com urgencia com um fornecedor!");
                }
                
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
                    foreach (var _produto in produtos)
                    {
                        _produto.Id = 0;
                        _produto.VendaId = venda.Id;
                        gestaoProdutosVendidos.SalvarProdutoVendido(_produto);
                        produto =  gestaoProdutos.ObterProdutos().Result.Where(x => x.Nome == _produto.NomeProduto && x.CategoriaId == _produto.CategoriaId).FirstOrDefault();
                        produto.Estoque = produto.Estoque - 1;
                        gestaoProdutos.SalvarProduto(produto);
                    }

                    if (venda.TipoDePagamento == "Venda Parcelada")
                    {
                        var vendaParcelada = new VendaParcelada();
                        vendaParcelada.VendaId = venda.Id;
                        vendaParcelada.QuantidadeParcelas = Convert.ToInt32(textBoxParcelas.Text) ;
                        vendaParcelada.ParcelasRestantes = vendaParcelada.QuantidadeParcelas - 1;
                        vendaParcelada.ValorDaParcela = venda.ValorTotal / (vendaParcelada.QuantidadeParcelas );
                        vendaParcelada.ValorTotal = venda.ValorTotal;
                        vendaParcelada.ValorRestante = venda.ValorPago - vendaParcelada.ValorTotal;
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
        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var retornoCategoria = categorias.Where(x => x.TipoCategoria == comboBoxCategoria.Text).FirstOrDefault();
                var retornoProduto = Produtos.Where(x => x.CategoriaId == retornoCategoria.Id).Select(x => x.Nome).ToList();
                comboBoxProduto.Text = string.Empty;
                comboBoxProduto.DataSource = retornoProduto;
                comboBoxProduto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
