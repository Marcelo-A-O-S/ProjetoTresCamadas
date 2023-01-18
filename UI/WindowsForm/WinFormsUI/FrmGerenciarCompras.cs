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
    public partial class FrmGerenciarCompras : Form
    {
        private GestaoProdutos gestaoProdutos = new();
        private GestaoCategorias gestaoCategorias = new();
        private GestaoFornecedores gestaoFornecedores = new();
        private GestaoFuncionarios gestaoFuncionarios = new();
        private GestaoCompraParcelada gestaoCompraParcelada = new();
        private GestaoProdutoComprado gestaoProdutoComprado = new();
        private GestaoCompra gestaoCompra = new();
        private Funcionario funcionario = new();
        private Categoria categoria = new();
        private Fornecedor fornecedor = new();
        private Produto produto = new();
        private Compra compra = new();
        private Produto _produto = new();
        private ProdutoComprado produtoCompradoAcesso = new();
        private List<ProdutoComprado> produtos = new();
        public FrmGerenciarCompras()
        {
            InitializeComponent();
            CarregarComboBoxFuncionario();
            CarregarComboBoxFornecedor();
            CarregarComboBoxCategoria();
            CarregarComboBoxProduto();
            CarregarDgvCompras();
        }
        private void CarregarDgvCompras()
        {
            try
            {
                dataGridViewCompras.EditMode = DataGridViewEditMode.EditProgrammatically;
                dataGridViewCompras.MultiSelect = false;
                dataGridViewCompras.ColumnCount = 13;
                dataGridViewCompras.Columns[0].HeaderText = "Id";
                dataGridViewCompras.Columns[0].DataPropertyName = "Id";
                dataGridViewCompras.Columns[0].Name = "Id";
                dataGridViewCompras.Columns[0].Visible = false;
                dataGridViewCompras.Columns[1].HeaderText = "Nome do Produto";
                dataGridViewCompras.Columns[1].DataPropertyName = "NomeProduto";
                dataGridViewCompras.Columns[1].Name = "NomeProduto";
                dataGridViewCompras.Columns[1].Width = 180;
                dataGridViewCompras.Columns[2].HeaderText = "ValorProduto";
                dataGridViewCompras.Columns[2].DataPropertyName = "ValorProduto";
                dataGridViewCompras.Columns[2].Name = "ValorProduto";
                dataGridViewCompras.Columns[2].Width = 180;
                dataGridViewCompras.Columns[3].HeaderText = "Categoria";
                dataGridViewCompras.Columns[3].DataPropertyName = "CategoriaId";
                dataGridViewCompras.Columns[3].Name = "CategoriaId";
                dataGridViewCompras.Columns[3].Visible = false;
                dataGridViewCompras.Columns[4].HeaderText = "Nome da Categoria";
                dataGridViewCompras.Columns[4].DataPropertyName = "CategoriaNome";
                dataGridViewCompras.Columns[4].Name = "CategoriaNome";
                dataGridViewCompras.Columns[5].HeaderText = "Quantidade de Produtos";
                dataGridViewCompras.Columns[5].DataPropertyName = "QuantidadeProdutos";
                dataGridViewCompras.Columns[5].Name = "QuantidadeProdutos";
                dataGridViewCompras.Columns[6].HeaderText = "FornecedorId";
                dataGridViewCompras.Columns[6].DataPropertyName = "FornecedorId";
                dataGridViewCompras.Columns[6].Name = "FornecedorId";
                dataGridViewCompras.Columns[6].Visible = false;
                dataGridViewCompras.Columns[7].HeaderText = "fornecedor";
                dataGridViewCompras.Columns[7].DataPropertyName = "fornecedor";
                dataGridViewCompras.Columns[7].Name = "fornecedor";
                dataGridViewCompras.Columns[7].Visible = false;
                dataGridViewCompras.Columns[8].HeaderText = "CompraId";
                dataGridViewCompras.Columns[8].DataPropertyName = "CompraId";
                dataGridViewCompras.Columns[8].Name = "CompraId";
                dataGridViewCompras.Columns[8].Visible = false;
                dataGridViewCompras.Columns[9].HeaderText = "compra";
                dataGridViewCompras.Columns[9].DataPropertyName = "compra";
                dataGridViewCompras.Columns[9].Name = "compra";
                dataGridViewCompras.Columns[9].Visible = false;
                dataGridViewCompras.Columns[10].HeaderText = "categoria";
                dataGridViewCompras.Columns[10].DataPropertyName = "categoria";
                dataGridViewCompras.Columns[10].Name = "categoria";
                dataGridViewCompras.Columns[10].Visible = false;
                dataGridViewCompras.Columns[11].HeaderText = "Nome Fantasia";
                dataGridViewCompras.Columns[11].DataPropertyName = "NomeFornecedor";
                dataGridViewCompras.Columns[11].Name = "NomeFornecedor";
                dataGridViewCompras.Columns[11].Width = 150;
                dataGridViewCompras.Columns[12].HeaderText = "Valor total do produto";
                dataGridViewCompras.Columns[12].DataPropertyName = "ValorTotalProduto";
                dataGridViewCompras.Columns[12].Name = "ValorTotalProduto";
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void CarregarComboBoxProduto()
        {
            comboBoxProduto.DataSource = gestaoProdutos.ObterProdutos().Result.Select(x=> x.Nome).ToList();
            comboBoxProduto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }
        private void CarregarComboBoxCategoria()
        {
            comboBoxCategoria.DataSource = gestaoCategorias.ObterCategorias().Result.Select(x=> x.TipoCategoria).ToList();
            comboBoxCategoria.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }
        private void CarregarComboBoxFornecedor()
        {
            comboBoxFornecedor.DataSource = gestaoFornecedores.ObterFornecedores().Result.Select(x=> x.NomeFantasia).ToList();
            comboBoxFornecedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }
        private void CarregarComboBoxFuncionario()
        {
            comboBoxFuncionario.DataSource = gestaoFuncionarios.ObterFuncionarios().Result.Select(x=> x.Nome).ToList();
            comboBoxFuncionario.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }
        private async void btnAdicionarCompra_Click(object sender, EventArgs e)
        {
            if (comboBoxCategoria.Text != string.Empty && comboBoxProduto.Text != string.Empty && comboBoxFornecedor.Text != string.Empty && comboBoxFuncionario.Text != string.Empty && textBoxQuantidade.Text != string.Empty)
            {
                var produtoComprado = new ProdutoComprado();
                categoria = await gestaoCategorias.BuscarCategoriaPor(x => x.TipoCategoria == comboBoxCategoria.Text);
                produto = await gestaoProdutos.BuscarProdutoPor(x => x.Nome == comboBoxProduto.Text);
                fornecedor = await gestaoFornecedores.ObterFornecedorPor(x => x.NomeFantasia == comboBoxFornecedor.Text);
                funcionario = await gestaoFuncionarios.BuscarFuncionarioPor(x => x.Nome == comboBoxFuncionario.Text);
                produtoComprado.Id = compra.QuantidadeComprados;
                produtoComprado.NomeProduto = produto.Nome;
                produtoComprado.ValorProduto = produto.Preco;
                produtoComprado.QuantidadeProdutos = Convert.ToInt32(textBoxQuantidade.Text);
                produtoComprado.ValorTotalProduto = produtoComprado.QuantidadeProdutos * produtoComprado.ValorProduto;
                produtoComprado.FornecedorId = fornecedor.Id;
                produtoComprado.NomeFornecedor = fornecedor.NomeFantasia;
                produtoComprado.CategoriaId = categoria.Id;
                produtoComprado.CategoriaNome = categoria.TipoCategoria;
                compra.ValorTotal += produtoComprado.ValorTotalProduto;
                produtos.Add(produtoComprado);
                compra.QuantidadeComprados = produtos.Count;
                labelValorTotal.Text = compra.ValorTotal.ToString();
                RecarregarDgvCompras();
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente");
            }
            
        }
        private void RecarregarDgvCompras()
        {
            dataGridViewCompras.DataSource = produtos.ToList();
        }
        private void LimparCampoCompra()
        {
            produtos.Clear();
            compra.ValorTotal = compra.ValorTotal - compra.ValorTotal;
            compra.QuantidadeComprados = produtos.Count;
            labelValorTotal.Text = compra.ValorTotal.ToString();
            RecarregarDgvCompras();
        }
        private void dataGridViewCompras_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dataGridViewCompras.SelectedRows.Count > 0)
                {
                    DataGridViewRow lines = dataGridViewCompras.SelectedRows[0];
                    comboBoxProduto.Text = lines.Cells["NomeProduto"].Value.ToString();
                    comboBoxCategoria.Text = lines.Cells["CategoriaNome"].Value.ToString();
                    comboBoxFornecedor.Text = lines.Cells["NomeFornecedor"].Value.ToString();
                    textBoxQuantidade.Text = lines.Cells["QuantidadeProdutos"].Value.ToString();
                    produtoCompradoAcesso.NomeFornecedor = lines.Cells["NomeFornecedor"].Value.ToString();
                    produtoCompradoAcesso.QuantidadeProdutos = Convert.ToInt32(lines.Cells["QuantidadeProdutos"].Value);
                    produtoCompradoAcesso.NomeProduto = lines.Cells["NomeProduto"].Value.ToString();
                    produtoCompradoAcesso.CategoriaNome = lines.Cells["CategoriaNome"].Value.ToString();
                    produtoCompradoAcesso.Id = (int)lines.Cells["Id"].Value;
                }
                if(dataGridViewCompras.SelectedCells.Count == 1)
                {
                    MessageBox.Show("Selecione o indice!");
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }
        private void btnRemoverCompra_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewCompras.SelectedRows.Count > 0)
                {
                    produtoCompradoAcesso = produtos.Find(x => x.Id == produtoCompradoAcesso.Id);
                    compra.ValorTotal = compra.ValorTotal - produtoCompradoAcesso.ValorTotalProduto;
                    labelValorTotal.Text = compra.ValorTotal.ToString();
                    produtos.Remove(produtoCompradoAcesso);
                    compra.QuantidadeComprados = produtos.Count;
                    RecarregarDgvCompras();
                }
                else
                {
                    MessageBox.Show("Selecione o indice para prosseguir");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private async void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                if (produtos.Count != 0)
                {
                    if (comboBoxPagamento.Text != string.Empty)
                    {
                        fornecedor = await gestaoFornecedores.ObterFornecedorPor(x => x.NomeFantasia == comboBoxFornecedor.Text);
                        funcionario = await gestaoFuncionarios.BuscarFuncionarioPor(x => x.Nome == comboBoxFuncionario.Text);
                        compra.Id = 0;
                        compra.QuantidadeComprados = produtos.Count;
                        compra.FuncionarioId = funcionario.Id;
                        compra.NomeFuncionario = funcionario.Nome;
                        compra.FornecedorId = fornecedor.Id;
                        compra.NomeFantasiaFornecedor = fornecedor.NomeFantasia;
                        compra.DataDaCompra = DateTime.Now;
                        compra.TipoDePagamento = comboBoxPagamento.Text;
                        var retorno = gestaoCompra.SalvarCompra(compra);
                        MessageBox.Show(retorno);
                        compra = gestaoCompra.BuscarCompraPor(x => x.Id == compra.Id);
                        foreach (var produto in produtos)
                        {
                            produto.Id = 0;
                            produto.CompraId = compra.Id;
                            gestaoProdutoComprado.SalvarProdutoComprado(produto);
                            _produto = await gestaoProdutos.BuscarProdutoPor(x=> x.Nome == produto.NomeProduto && x.CategoriaId == produto.CategoriaId);
                            _produto.Estoque += produto.QuantidadeProdutos;
                            gestaoProdutos.SalvarProduto(_produto);
                        }

                        if (compra.TipoDePagamento == "Compra Parcelada")
                        {
                            var compraParcelada = new CompraParcelada();
                            compraParcelada.CompraId = compra.Id;
                            compraParcelada.QuantidadeParcelas = Convert.ToInt32(textBoxParcelas.Text);
                            compraParcelada.ParcelasRestantes = compraParcelada.QuantidadeParcelas - 1;
                            compraParcelada.ValorDaParcela = compra.ValorTotal / (compraParcelada.QuantidadeParcelas);
                            compraParcelada.ValorTotal = compra.ValorTotal;
                            compraParcelada.ValorRestante = compraParcelada.ValorDaParcela - compraParcelada.ValorTotal;
                            compraParcelada.MesInicial = DateTime.Now.Month;
                            compraParcelada.MesFinal = DateTime.Now.AddMonths(compraParcelada.ParcelasRestantes).Month;
                            compraParcelada.DataPagamentoInicial = compra.DataDaCompra;
                            retorno = gestaoCompraParcelada.SalvarCompraParcelada(compraParcelada);
                            MessageBox.Show(retorno);
                            MessageBox.Show("Receba o valor inicial da primeira parcela antes de prosseguir!");
                        }
                        else
                        {
                            compra.PagamentoRealizado = true;
                            gestaoCompra.SalvarCompra(compra);
                        }
                        LimparCampoCompra();
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
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void btnLimparCompras_Click(object sender, EventArgs e)
        {
            try
            {
                LimparCampoCompra();
            }catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
