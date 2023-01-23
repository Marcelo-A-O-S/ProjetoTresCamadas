using DTO.Entidades;
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
    public partial class FrmBuscarCompraFornecedor : Form
    {
        private GestaoCategorias gestaoCategorias = new();
        private GestaoFornecedores gestaoFornecedores = new();
        private GestaoProdutoComprado gestaoProdutoComprado = new();
        private GestaoCompra gestaoCompra = new();
        private GestaoProdutos gestaoProdutos = new();
        private GestaoCompraParcelada gestaoCompraParcelada = new();
        private List<Categoria> categorias = new();
        private List<Compra> compras = new();
        private List<Fornecedor> fornecedores = new();
        private List<ProdutoComprado> produtosComprados = new();
        private List<Produto> produtos = new();
        private CompraParcelada compraParcelada = new();
        private ProdutoComprado produtoComprado = new();
        private Compra compra = new();
        private Fornecedor fornecedor = new();
        private Categoria categoria = new();
        private Produto produto = new();
        public FrmBuscarCompraFornecedor()
        {
            InitializeComponent();
            CarregarDados();
            CarregarDgvCompras();
            CarregarDgvProdutos();
            CarregarComboBoxFornecedor();
        }
        private void CarregarDados()
        {
            categorias = gestaoCategorias.ObterCategorias().Result.ToList();
            compras = gestaoCompra.ObterCompras().Result.ToList();
            fornecedores = gestaoFornecedores.ObterFornecedores().Result.ToList();
            produtosComprados = gestaoProdutoComprado.ObterProdutosComprados().Result.ToList();
            produtos = gestaoProdutos.ObterProdutos().Result.ToList();

        }
        private void CarregarComboBoxFornecedor()
        {
            try
            {
                var retornoFornecedor = fornecedores.Select(x => x.NomeFantasia).ToList();
                var retornoCategoria = categorias.Select(x => x.TipoCategoria).ToList();
                comboBoxCategoria.DataSource = retornoCategoria;
                comboBoxCategoria.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBoxFornecedor.DataSource = retornoFornecedor;
                comboBoxFornecedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void CarregarDgvProdutos()
        {
            try
            {
                dGVProdutos.EditMode = DataGridViewEditMode.EditProgrammatically;
                dGVProdutos.MultiSelect = false;
                dGVProdutos.ColumnCount = 13;
                dGVProdutos.Columns[0].HeaderText = "Id";
                dGVProdutos.Columns[0].DataPropertyName = "Id";
                dGVProdutos.Columns[0].Name = "Id";
                dGVProdutos.Columns[0].Visible = false;
                dGVProdutos.Columns[1].HeaderText = "Nome do Produto";
                dGVProdutos.Columns[1].DataPropertyName = "NomeProduto";
                dGVProdutos.Columns[1].Name = "NomeProduto";
                dGVProdutos.Columns[1].Width = 250;
                dGVProdutos.Columns[2].HeaderText = "Valor do Produto";
                dGVProdutos.Columns[2].DataPropertyName = "ValorProduto";
                dGVProdutos.Columns[2].Name = "ValorProduto";
                dGVProdutos.Columns[2].Width = 250;
                dGVProdutos.Columns[3].HeaderText = "Valor total do produto";
                dGVProdutos.Columns[3].DataPropertyName = "ValorTotalProduto";
                dGVProdutos.Columns[3].Name = "ValorTotalProduto";
                dGVProdutos.Columns[3].Width = 250;
                dGVProdutos.Columns[4].HeaderText = "Quantidade de Produtos";
                dGVProdutos.Columns[4].DataPropertyName = "QuantidadeProdutos";
                dGVProdutos.Columns[4].Name = "QuantidadeProdutos";
                dGVProdutos.Columns[4].Width = 250;
                dGVProdutos.Columns[5].HeaderText = "FornecedorId";
                dGVProdutos.Columns[5].DataPropertyName = "FornecedorId";
                dGVProdutos.Columns[5].Name = "FornecedorId";
                dGVProdutos.Columns[5].Visible = false;
                dGVProdutos.Columns[6].HeaderText = "Nome do Fornecedor";
                dGVProdutos.Columns[6].DataPropertyName = "NomeFornecedor";
                dGVProdutos.Columns[6].Name = "NomeFornecedor";
                dGVProdutos.Columns[6].Width = 210;
                dGVProdutos.Columns[7].HeaderText = "CompraId";
                dGVProdutos.Columns[7].DataPropertyName = "CompraId";
                dGVProdutos.Columns[7].Name = "CompraId";
                dGVProdutos.Columns[7].Visible = false;
                dGVProdutos.Columns[8].HeaderText = "compra";
                dGVProdutos.Columns[8].DataPropertyName = "compra";
                dGVProdutos.Columns[8].Name = "compra";
                dGVProdutos.Columns[8].Visible = false;
                dGVProdutos.Columns[9].HeaderText = "CategoriaId";
                dGVProdutos.Columns[9].DataPropertyName = "CategoriaId";
                dGVProdutos.Columns[9].Name = "CategoriaId";
                dGVProdutos.Columns[9].Visible = false;
                dGVProdutos.Columns[10].HeaderText = "Categoria";
                dGVProdutos.Columns[10].DataPropertyName = "CategoriaNome";
                dGVProdutos.Columns[10].Name = "CategoriaNome";
                dGVProdutos.Columns[10].Width = 250;
                dGVProdutos.Columns[11].HeaderText = "categoria";
                dGVProdutos.Columns[11].DataPropertyName = "categoria";
                dGVProdutos.Columns[11].Name = "categoria";
                dGVProdutos.Columns[11].Visible = false;
                dGVProdutos.Columns[12].HeaderText = "fornecedor";
                dGVProdutos.Columns[12].DataPropertyName = "fornecedor";
                dGVProdutos.Columns[12].Name = "fornecedor";
                dGVProdutos.Columns[12].Visible = false;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void CarregarDgvCompras()
        {
            try
            {
                dGVCompras.EditMode = DataGridViewEditMode.EditProgrammatically;
                dGVCompras.MultiSelect = false;
                dGVCompras.ColumnCount = 13;
                dGVCompras.Columns[0].HeaderText = "Id";
                dGVCompras.Columns[0].DataPropertyName = "Id";
                dGVCompras.Columns[0].Name = "Id";
                dGVCompras.Columns[0].Visible = false;
                dGVCompras.Columns[1].HeaderText = "Tipo de Pagamento";
                dGVCompras.Columns[1].DataPropertyName = "TipoDePagamento";
                dGVCompras.Columns[1].Name = "TipoDePagamento";
                dGVCompras.Columns[1].Width = 150;
                dGVCompras.Columns[2].HeaderText = "Quantidade de Produtos comprados";
                dGVCompras.Columns[2].DataPropertyName = "QuantidadeComprados";
                dGVCompras.Columns[2].Name = "QuantidadeComprados";
                dGVCompras.Columns[2].Width = 250;
                dGVCompras.Columns[3].HeaderText = "Data da Compra";
                dGVCompras.Columns[3].DataPropertyName = "DataDaCompra";
                dGVCompras.Columns[3].Name = "DataDaCompra";
                dGVCompras.Columns[3].Width = 180;
                dGVCompras.Columns[4].HeaderText = "Pagamento Realizado";
                dGVCompras.Columns[4].DataPropertyName = "PagamentoRealizado";
                dGVCompras.Columns[4].Name = "PagamentoRealizado";
                dGVCompras.Columns[4].Width = 220;
                dGVCompras.Columns[5].HeaderText = "Valor total da venda";
                dGVCompras.Columns[5].DataPropertyName = "ValorTotal";
                dGVCompras.Columns[5].Name = "ValorTotal";
                dGVCompras.Columns[5].Width = 180;
                dGVCompras.Columns[6].HeaderText = "FornecedorId";
                dGVCompras.Columns[6].DataPropertyName = "FornecedorId";
                dGVCompras.Columns[6].Name = "FornecedorId";
                dGVCompras.Columns[6].Visible = false;
                dGVCompras.Columns[7].HeaderText = "Nome Fantasia";
                dGVCompras.Columns[7].DataPropertyName = "NomeFantasiaFornecedor";
                dGVCompras.Columns[7].Name = "NomeFantasiaFornecedor";
                dGVCompras.Columns[7].Width = 180;
                dGVCompras.Columns[8].HeaderText = "FuncionarioId";
                dGVCompras.Columns[8].DataPropertyName = "FuncionarioId";
                dGVCompras.Columns[8].Name = "FuncionarioId";
                dGVCompras.Columns[8].Visible = false;
                dGVCompras.Columns[9].HeaderText = "Nome do Funcionario";
                dGVCompras.Columns[9].DataPropertyName = "NomeFuncionario";
                dGVCompras.Columns[9].Name = "NomeFuncionario";
                dGVCompras.Columns[9].Width = 180;
                dGVCompras.Columns[10].HeaderText = "fornecedor";
                dGVCompras.Columns[10].DataPropertyName = "fornecedor";
                dGVCompras.Columns[10].Name = "fornecedor";
                dGVCompras.Columns[10].Visible = false;
                dGVCompras.Columns[11].HeaderText = "funcionario";
                dGVCompras.Columns[11].DataPropertyName = "funcionario";
                dGVCompras.Columns[11].Name = "funcionario";
                dGVCompras.Columns[11].Visible = false;
                dGVCompras.Columns[12].HeaderText = "Valor Pago";
                dGVCompras.Columns[12].DataPropertyName = "ValorPago";
                dGVCompras.Columns[12].Name = "ValorPago";
                
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void btnBuscarCompras_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxFornecedor.Text == String.Empty)
                {
                    MessageBox.Show("Preencha o campo Cliente!");
                }
                else
                {
                    dGVCompras.DataSource = gestaoCompra.ObterCompras().Result.Where(x => x.NomeFantasiaFornecedor == comboBoxFornecedor.Text).ToList();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void dGVCompras_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dGVCompras.SelectedCells.Count == 1)
                {
                    MessageBox.Show("Selecione pelo indice da tabela!");
                }
                if (dGVCompras.SelectedRows.Count > 0)
                {
                    var line = dGVCompras.SelectedRows[0];
                    if (line.Cells["Id"].Value != null)
                    {
                        var id = Convert.ToInt32(line.Cells["Id"].Value.ToString());
                        dGVProdutos.DataSource = gestaoProdutoComprado.ObterProdutosComprados().Result.Where(x => x.CompraId == id).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Busque as informacões referentes ao cliente antes de continuar!");
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private async void dGVProdutos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dGVProdutos.SelectedCells.Count == 1)
                {
                    MessageBox.Show("Selecione o indice da tabela!");
                }
                if (dGVProdutos.SelectedRows.Count > 0)
                {
                    var line = dGVProdutos.SelectedRows[0];
                    if (line.Cells["Id"].Value != null)
                    {
                        var id = Convert.ToInt32(line.Cells["Id"].Value.ToString());
                        produtoComprado = await gestaoProdutoComprado.BuscarProdutoCompradoPor(x => x.Id == id);
                    }
                    else
                    {
                        MessageBox.Show("Selecione a venda antes de prosseguir!");
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private async void btnRemoverCompra_Click(object sender, EventArgs e)
        {
            try
            {
                if (dGVProdutos.SelectedRows.Count > 0)
                {
                    var line = dGVProdutos.SelectedRows[0];
                    var id = Convert.ToInt32(line.Cells["Id"].Value.ToString());
                    produtoComprado = await gestaoProdutoComprado.BuscarProdutoCompradoPor(x => x.Id == id);
                    var produto = produtos.Where(x => x.Nome == produtoComprado.NomeProduto && x.CategoriaId == produtoComprado.CategoriaId).FirstOrDefault();
                    compra =  gestaoCompra.BuscarCompraPor(x => x.Id == produtoComprado.CompraId);
                    produto.Estoque += produtoComprado.QuantidadeProdutos;
                    compra.ValorTotal = compra.ValorTotal - produtoComprado.ValorTotalProduto;
                    compra.QuantidadeComprados = compra.QuantidadeComprados - 1;
                    compra.ValorPago = compra.ValorPago - produtoComprado.ValorTotalProduto;
                    gestaoProdutos.SalvarProduto(produto);
                    var retorno = gestaoProdutoComprado.ExcluirProdutoComprado(produtoComprado);
                    MessageBox.Show(retorno);
                    if (compra.QuantidadeComprados > 0)
                    {
                        if (compra.TipoDePagamento == "Compra Parcelada")
                        {
                            compraParcelada = gestaoCompraParcelada.BuscarCompraParceladaPor(x => x.CompraId == compra.Id);
                            compraParcelada.ValorPago = compra.ValorPago;
                            compraParcelada.ValorTotal = compra.ValorTotal;
                            compraParcelada.ValorRestante = compraParcelada.ValorRestante + produtoComprado.ValorTotalProduto;
                            compraParcelada.ValorRestante = compraParcelada.ValorRestante - compraParcelada.ValorPago;
                            gestaoCompraParcelada.SalvarCompraParcelada(compraParcelada);
                        }
                        gestaoCompra.SalvarCompra(compra);
                    }
                    else
                    {
                        if (compra.TipoDePagamento == "Compra Parcelada")
                        {
                            compraParcelada = gestaoCompraParcelada.BuscarCompraParceladaPor(x => x.CompraId == compra.Id);
                            gestaoCompraParcelada.ExcluirCompraParcelada(compraParcelada);
                        }
                        gestaoCompra.ExcluirCompra(compra);
                    }
                    CarregarDados();
                }
                else
                {
                    MessageBox.Show("Selecione um registro de produto antes de prosseguir");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var retornoCategoria = categorias.Where(x => x.TipoCategoria == comboBoxCategoria.Text).FirstOrDefault();
                var retornoProduto = produtos.Where(x => x.CategoriaId == retornoCategoria.Id).Select(x => x.Nome).ToList();
                comboBoxProduto.Text = string.Empty;
                comboBoxProduto.DataSource = retornoProduto;
                comboBoxProduto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private async void btnDesfazerCompra_Click(object sender, EventArgs e)
        {
            try
            {
                if (dGVCompras.SelectedRows.Count > 0)
                {
                    var line = dGVCompras.SelectedRows[0];
                    var id = Convert.ToInt32(line.Cells["Id"].Value.ToString());
                    compra = compras.Where(x => x.Id == id).FirstOrDefault();
                    var ListaProdutos = produtosComprados.Where(x => x.CompraId == compra.Id).ToList();
                    foreach (var _produtos in ListaProdutos)
                    {
                        var produto = produtos.Where(x => x.Nome == _produtos.NomeProduto && x.CategoriaId == _produtos.CategoriaId).FirstOrDefault();
                        produto.Estoque += _produtos.QuantidadeProdutos;

                        gestaoProdutos.SalvarProduto(produto);
                        gestaoProdutoComprado.ExcluirProdutoComprado(_produtos);
                    }
                    if (compra.TipoDePagamento == "Compra Parcelada")
                    {
                        compraParcelada =  gestaoCompraParcelada.BuscarCompraParceladaPor(x => x.CompraId == compra.Id);
                        gestaoCompraParcelada.ExcluirCompraParcelada(compraParcelada);
                    }
                    var retorno = gestaoCompra.ExcluirCompra(compra);
                    MessageBox.Show(retorno);
                    CarregarDados();

                }
                else
                {
                    MessageBox.Show("Selecione um registro de produto antes de prosseguir");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCategoria.Text != string.Empty && comboBoxProduto.Text != string.Empty && textBoxQuantidade.Text != string.Empty && comboBoxFornecedor.Text != string.Empty)
                {
                    if (dGVCompras.SelectedRows.Count > 0)
                    {
                        var line = dGVCompras.SelectedRows[0];
                        var id = Convert.ToInt32(line.Cells["Id"].Value.ToString());
                        var NomeFornecedor = comboBoxFornecedor.Text;
                        var NomeCategoria = comboBoxCategoria.Text;
                        var NomeProduto = comboBoxProduto.Text;
                        var ValorPago = Convert.ToDecimal(textBoxValorPago.Text);
                        var quantidadeProdutos = Convert.ToInt32(textBoxQuantidade.Text);
                        fornecedor = fornecedores.Where(x => x.NomeFantasia == NomeFornecedor).FirstOrDefault();
                        compra = compras.Where(x => x.Id == id).FirstOrDefault();
                        categoria = categorias.Where(x => x.TipoCategoria == NomeCategoria).FirstOrDefault();
                        produto = produtos.Where(x => x.Nome == NomeProduto && x.CategoriaId == categoria.Id).FirstOrDefault();
                        produtoComprado.Id = 0;
                        produtoComprado.NomeFornecedor = fornecedor.NomeFantasia;
                        produtoComprado.FornecedorId = fornecedor.Id;
                        produtoComprado.CompraId = compra.Id;
                        produtoComprado.CategoriaId = categoria.Id;
                        produtoComprado.CategoriaNome = categoria.TipoCategoria;
                        produtoComprado.NomeProduto = produto.Nome;
                        produtoComprado.QuantidadeProdutos = quantidadeProdutos;
                        produtoComprado.ValorProduto = produto.Preco;
                        produtoComprado.ValorTotalProduto = produtoComprado.ValorProduto * produtoComprado.QuantidadeProdutos;
                        gestaoProdutoComprado.SalvarProdutoComprado(produtoComprado);
                        compra.QuantidadeComprados = compra.QuantidadeComprados + 1;
                        compra.ValorPago += ValorPago;
                        compra.ValorTotal += produtoComprado.ValorTotalProduto;
                        produto.Estoque += quantidadeProdutos;
                        if (compra.TipoDePagamento == "Compra Parcelada")
                        {
                            compraParcelada =  gestaoCompraParcelada.BuscarCompraParceladaPor(x => x.CompraId == compra.Id);
                            compraParcelada.ValorPago = compra.ValorPago;
                            compraParcelada.ValorTotal = compra.ValorTotal;
                            compraParcelada.ValorRestante = compra.ValorTotal - compra.ValorPago;
                            
                            gestaoCompraParcelada.SalvarCompraParcelada(compraParcelada);
                        }
                        var retorno = gestaoCompra.SalvarCompra(compra);
                        MessageBox.Show(retorno);
                        CarregarDados();
                    }
                    else
                    {
                        MessageBox.Show("Selecione um registro de produto antes de prosseguir");
                    }
                }
                else
                {
                    MessageBox.Show("Informe os dados para poder adicionar ao registro");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void textBoxQuantidade_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxQuantidade.Text != string.Empty)
                {
                    var quantidade = Convert.ToInt32(textBoxQuantidade.Text);
                    produto = produtos.Where(x => x.Nome == comboBoxProduto.Text).FirstOrDefault();
                    var valorTotal = produto.Preco * quantidade;
                    LabelValor.Text = valorTotal.ToString();
                }
                else
                {
                    LabelValor.Text = "";
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
