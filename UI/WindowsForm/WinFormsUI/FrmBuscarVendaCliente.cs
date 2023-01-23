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
    public partial class FrmBuscarVendaCliente : Form
    {
        private GestaoVendasParceladas gestaoVendasParceladas = new();
        private GestaoClientes gestaoClientes = new();
        private GestaoVendas gestaoVendas = new();
        private GestaoCategorias gestaoCategorias = new();
        private GestaoProdutosVendidos gestaoProdutos = new();
        private GestaoProdutos produtos = new();
        private List<Cliente> clientes = new();
        private List<Categoria> categorias = new();
        private List<Venda> vendas = new();
        private List<ProdutoVendido> produtosVendidos = new();
        private List<Produto> Produtos = new();
        private Venda venda = new();
        private ProdutoVendido produtoVendido = new();
        private Cliente cliente = new();
        private Categoria categoria = new();
        private Produto produto = new();
        private VendaParcelada vendaParcelada = new();
        public FrmBuscarVendaCliente()
        {
            InitializeComponent();
            CarregarDados();
            CarregarCombox();
            CarregarDgvVendas();
            CarregarDgvProdutos();
        }
        private async void CarregarDados()
        {
            clientes = gestaoClientes.ObterClientes().Result.ToList();
            categorias = gestaoCategorias.ObterCategorias().Result.ToList();
            vendas = gestaoVendas.ObterVendas().Result.ToList();
            produtosVendidos = gestaoProdutos.ObterProdutosVendidos().Result.ToList();
            Produtos = produtos.ObterProdutos().Result.ToList();
        }
        private void CarregarDgvProdutos()
        {
            try
            {
                dGVProdutosVendas.EditMode = DataGridViewEditMode.EditProgrammatically;
                dGVProdutosVendas.MultiSelect = false;
                dGVProdutosVendas.ColumnCount = 13;
                dGVProdutosVendas.Columns[0].HeaderText = "Id";
                dGVProdutosVendas.Columns[0].DataPropertyName = "Id";
                dGVProdutosVendas.Columns[0].Name = "Id";
                dGVProdutosVendas.Columns[0].Visible = false;
                dGVProdutosVendas.Columns[1].HeaderText = "Nome do Produto";
                dGVProdutosVendas.Columns[1].DataPropertyName = "NomeProduto";
                dGVProdutosVendas.Columns[1].Name = "NomeProduto";
                dGVProdutosVendas.Columns[1].Width = 250;
                dGVProdutosVendas.Columns[2].HeaderText = "Valor do Produto";
                dGVProdutosVendas.Columns[2].DataPropertyName = "ValorProduto";
                dGVProdutosVendas.Columns[2].Name = "ValorProduto";
                dGVProdutosVendas.Columns[2].Width = 250;
                dGVProdutosVendas.Columns[3].HeaderText = "Valor total do produto";
                dGVProdutosVendas.Columns[3].DataPropertyName = "ValorTotalProduto";
                dGVProdutosVendas.Columns[3].Name = "ValorTotalProduto";
                dGVProdutosVendas.Columns[3].Width = 250;
                dGVProdutosVendas.Columns[4].HeaderText = "Quantidade de Produtos";
                dGVProdutosVendas.Columns[4].DataPropertyName = "QuantidadeProdutos";
                dGVProdutosVendas.Columns[4].Name = "QuantidadeProdutos";
                dGVProdutosVendas.Columns[4].Width = 250;
                dGVProdutosVendas.Columns[5].HeaderText = "ClienteId";
                dGVProdutosVendas.Columns[5].DataPropertyName = "ClienteId";
                dGVProdutosVendas.Columns[5].Name = "ClienteId";
                dGVProdutosVendas.Columns[5].Visible = false;
                dGVProdutosVendas.Columns[6].HeaderText = "Nome do Cliente";
                dGVProdutosVendas.Columns[6].DataPropertyName = "NomeCliente";
                dGVProdutosVendas.Columns[6].Name = "NomeCliente";
                dGVProdutosVendas.Columns[6].Width = 210;
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
                dGVProdutosVendas.Columns[10].Width = 250;
                dGVProdutosVendas.Columns[11].HeaderText = "categoria";
                dGVProdutosVendas.Columns[11].DataPropertyName = "categoria";
                dGVProdutosVendas.Columns[11].Name = "categoria";
                dGVProdutosVendas.Columns[11].Visible = false;
                dGVProdutosVendas.Columns[12].HeaderText = "cliente";
                dGVProdutosVendas.Columns[12].DataPropertyName = "cliente";
                dGVProdutosVendas.Columns[12].Name = "cliente";
                dGVProdutosVendas.Columns[12].Visible = false;
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void CarregarDgvVendas()
        {
            try
            {
                dGVVendas.EditMode = DataGridViewEditMode.EditProgrammatically;
                dGVVendas.MultiSelect = false;
                dGVVendas.ColumnCount = 13;
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
                dGVVendas.Columns[2].Width = 250;
                dGVVendas.Columns[3].HeaderText = "Data da venda";
                dGVVendas.Columns[3].DataPropertyName = "DataDaVenda";
                dGVVendas.Columns[3].Name = "DataDaVenda";
                dGVVendas.Columns[3].Width = 180;
                dGVVendas.Columns[4].HeaderText = "Pagamento Realizado";
                dGVVendas.Columns[4].DataPropertyName = "PagamentoRealizado";
                dGVVendas.Columns[4].Name = "PagamentoRealizado";
                dGVVendas.Columns[4].Width = 220;
                dGVVendas.Columns[5].HeaderText = "Valor total da venda";
                dGVVendas.Columns[5].DataPropertyName = "ValorTotal";
                dGVVendas.Columns[5].Name = "ValorTotal";
                dGVVendas.Columns[5].Width = 180;
                dGVVendas.Columns[6].HeaderText = "ClienteId";
                dGVVendas.Columns[6].DataPropertyName = "ClienteId";
                dGVVendas.Columns[6].Name = "ClienteId";
                dGVVendas.Columns[6].Visible = false;
                dGVVendas.Columns[7].HeaderText = "Nome do Cliente";
                dGVVendas.Columns[7].DataPropertyName = "NomeCliente";
                dGVVendas.Columns[7].Name = "NomeCliente";
                dGVVendas.Columns[7].Width = 180;
                dGVVendas.Columns[8].HeaderText = "FuncionarioId";
                dGVVendas.Columns[8].DataPropertyName = "FuncionarioId";
                dGVVendas.Columns[8].Name = "FuncionarioId";
                dGVVendas.Columns[8].Visible = false;
                dGVVendas.Columns[9].HeaderText = "Nome do Funcionario";
                dGVVendas.Columns[9].DataPropertyName = "NomeFuncionario";
                dGVVendas.Columns[9].Name = "NomeFuncionario";
                dGVVendas.Columns[9].Width = 180;
                dGVVendas.Columns[10].HeaderText = "cliente";
                dGVVendas.Columns[10].DataPropertyName = "cliente";
                dGVVendas.Columns[10].Name = "cliente";
                dGVVendas.Columns[10].Visible = false;
                dGVVendas.Columns[11].HeaderText = "funcionario";
                dGVVendas.Columns[11].DataPropertyName = "funcionario";
                dGVVendas.Columns[11].Name = "funcionario";
                dGVVendas.Columns[11].Visible = false;
                dGVVendas.Columns[12].HeaderText = "Valor Pago";
                dGVVendas.Columns[12].DataPropertyName = "ValorPago";
                dGVVendas.Columns[12].Name = "ValorPago";
            }catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private async void CarregarCombox()
        {
            try
            {
                var retornoCategoria = categorias.Select(x => x.TipoCategoria).ToList();
                var retornoCliente = clientes.Select(x => x.Nome).ToList();
                comboBoxClienteVenda.DataSource = retornoCliente;
                comboBoxClienteVenda.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBoxCategoria.DataSource = retornoCategoria;
                comboBoxCategoria.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            }catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void btnBuscarVendas_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxClienteVenda.Text == String.Empty)
                {
                    MessageBox.Show("Preencha o campo Cliente!");
                }
                else
                {
                    vendas = gestaoVendas.ObterVendas().Result.ToList();
                    dGVVendas.DataSource = vendas.Where(x => x.NomeCliente == comboBoxClienteVenda.Text).ToList();
                }
            }catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private async void dGVVendas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dGVVendas.SelectedCells.Count == 1)
                {
                    MessageBox.Show("Selecione pelo indice da tabela!");
                }
                if (dGVVendas.SelectedRows.Count > 0)
                {
                    var line = dGVVendas.SelectedRows[0];
                    if(line.Cells["Id"].Value != null){
                        var id = Convert.ToInt32(line.Cells["Id"].Value.ToString());
                        dGVProdutosVendas.DataSource = gestaoProdutos.ObterProdutosVendidos().Result.Where(x => x.VendaId == id).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Busque as informacões referentes ao cliente antes de continuar!");
                    }
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private async void dGVProdutosVendas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dGVProdutosVendas.SelectedCells.Count == 1)
                {
                    MessageBox.Show("Selecione o indice da tabela!");
                }
                if (dGVProdutosVendas.SelectedRows.Count > 0)
                {
                    var line = dGVProdutosVendas.SelectedRows[0];
                    if(line.Cells["Id"].Value != null)
                    {
                        var id = Convert.ToInt32(line.Cells["Id"].Value.ToString());
                        produtoVendido = await gestaoProdutos.BuscarProdutoVendidoPor(x => x.Id == id);
                    }
                    else
                    {
                        MessageBox.Show("Selecione a venda antes de prosseguir!");
                    }
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
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
                    venda = vendas.Where(x=> x.Id == produtoVendido.VendaId).FirstOrDefault();
                    venda.QuantidadeVendidos = venda.QuantidadeVendidos - 1;
                    gestaoVendas.SalvarVenda(venda);
                    CarregarDados();
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
        private async void btnDesfazerVenda_Click(object sender, EventArgs e)
        {
            try
            {
                if (dGVVendas.SelectedRows.Count > 0)
                {
                    var line = dGVVendas.SelectedRows[0];
                    var id = Convert.ToInt32(line.Cells["Id"].Value.ToString());
                    venda = vendas.Where(x => x.Id == id).FirstOrDefault();
                    
                    var ListaProdutos = produtosVendidos.Where(x => x.VendaId == venda.Id).ToList();
                    foreach (var _produtos in ListaProdutos)
                    {
                        var produto = Produtos.Where(x => x.Nome == _produtos.NomeProduto && x.CategoriaId == _produtos.CategoriaId).FirstOrDefault();
                        produto.Estoque += _produtos.QuantidadeProdutos;
                        
                        produtos.SalvarProduto(produto);
                        gestaoProdutos.ExcluirProdutoVendido(_produtos);
                    }
                    if(venda.TipoDePagamento == "Venda Parcelada")
                    {
                        vendaParcelada = await gestaoVendasParceladas.BuscarVendaParcelada(x => x.VendaId == venda.Id);
                        gestaoVendasParceladas.ExcluirVendaParcelada(vendaParcelada);
                    }
                    var retorno = gestaoVendas.ExcluirVenda(venda);
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
        private async void btnDesfazerProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dGVProdutosVendas.SelectedRows.Count > 0)
                {
                    var line = dGVProdutosVendas.SelectedRows[0];
                    var id = Convert.ToInt32(line.Cells["Id"].Value.ToString());
                    produtoVendido = await gestaoProdutos.BuscarProdutoVendidoPor(x => x.Id == id);
                    var produto = Produtos.Where(x => x.Nome == produtoVendido.NomeProduto && x.CategoriaId == produtoVendido.CategoriaId).FirstOrDefault();
                    venda = await gestaoVendas.BuscarVendaPor(x => x.Id == produtoVendido.VendaId);
                    produto.Estoque += produtoVendido.QuantidadeProdutos;
                    venda.ValorTotal = venda.ValorTotal - produtoVendido.ValorTotalProduto;
                    venda.QuantidadeVendidos = venda.QuantidadeVendidos - 1;
                    venda.ValorPago = venda.ValorPago - produtoVendido.ValorTotalProduto;
                    produtos.SalvarProduto(produto);
                    var retorno = gestaoProdutos.ExcluirProdutoVendido(produtoVendido);
                    MessageBox.Show(retorno);
                    if(venda.QuantidadeVendidos > 0)
                    {
                        if(venda.TipoDePagamento == "Venda Parcelada")
                        {
                            vendaParcelada = await gestaoVendasParceladas.BuscarVendaParcelada(x => x.VendaId == venda.Id);
                            vendaParcelada.ValorPago = venda.ValorPago;
                            vendaParcelada.ValorTotal = venda.ValorTotal;
                            vendaParcelada.ValorRestante = vendaParcelada.ValorTotal - vendaParcelada.ValorPago;
                            gestaoVendasParceladas.SalvarVendaParcelada(vendaParcelada);
                        }
                        gestaoVendas.SalvarVenda(venda);
                    }
                    else
                    {
                        if (venda.TipoDePagamento == "Venda Parcelada")
                        {
                            vendaParcelada = await gestaoVendasParceladas.BuscarVendaParcelada(x => x.VendaId == venda.Id);
                            gestaoVendasParceladas.ExcluirVendaParcelada(vendaParcelada);
                        }
                        gestaoVendas.ExcluirVenda(venda);
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
                var retornoProduto = Produtos.Where(x => x.CategoriaId == retornoCategoria.Id).Select(x => x.Nome).ToList();
                comboBoxProduto.Text = string.Empty;
                comboBoxProduto.DataSource = retornoProduto;
                comboBoxProduto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private async void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBoxCategoria.Text != string.Empty && comboBoxProduto.Text != string.Empty && textBoxQuantidade.Text != string.Empty && comboBoxClienteVenda.Text != string.Empty)
                {
                    if (dGVVendas.SelectedRows.Count > 0)
                    {
                        var line = dGVVendas.SelectedRows[0];
                        var id = Convert.ToInt32(line.Cells["Id"].Value.ToString());
                        var NomeCliente = comboBoxClienteVenda.Text;
                        var NomeCategoria = comboBoxCategoria.Text;
                        var NomeProduto = comboBoxProduto.Text;
                        var ValorPago = Convert.ToDecimal(textBoxValorPago.Text);
                        var quantidadeProdutos = Convert.ToInt32(textBoxQuantidade.Text);
                        cliente = clientes.Where(x => x.Nome == NomeCliente).FirstOrDefault();
                        venda = vendas.Where(x => x.Id == id).FirstOrDefault();
                        categoria = categorias.Where(x => x.TipoCategoria == NomeCategoria).FirstOrDefault();
                        produto = Produtos.Where(x => x.Nome == NomeProduto && x.CategoriaId == categoria.Id).FirstOrDefault();
                        produtoVendido.Id = 0;
                        produtoVendido.NomeCliente = cliente.Nome;
                        produtoVendido.ClienteId = cliente.Id;
                        produtoVendido.VendaId = venda.Id;
                        produtoVendido.CategoriaId = categoria.Id;
                        produtoVendido.CategoriaNome = categoria.TipoCategoria;
                        produtoVendido.NomeProduto = produto.Nome;
                        produtoVendido.QuantidadeProdutos = quantidadeProdutos;
                        produtoVendido.ValorProduto = produto.Preco;
                        produtoVendido.ValorTotalProduto = produtoVendido.ValorProduto * produtoVendido.QuantidadeProdutos;
                        //gestaoProdutos.SalvarProdutoVendido(produtoVendido);
                        venda.QuantidadeVendidos = venda.QuantidadeVendidos + 1;
                        venda.ValorPago += ValorPago;
                        venda.ValorTotal += produtoVendido.ValorTotalProduto;
                        produto.Estoque -= quantidadeProdutos;
                        if (venda.TipoDePagamento == "Venda Parcelada")
                        {
                            vendaParcelada = await gestaoVendasParceladas.BuscarVendaParcelada(x => x.VendaId == venda.Id);
                            vendaParcelada.ValorPago = venda.ValorPago;
                            vendaParcelada.ValorTotal = venda.ValorTotal;
                            vendaParcelada.ValorRestante = venda.ValorTotal - venda.ValorPago;
                            
                            //gestaoVendasParceladas.SalvarVendaParcelada(vendaParcelada);
                        }
                        
                        //var retorno = gestaoVendas.SalvarVenda(venda);
                        //MessageBox.Show(retorno);
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
                    produto = Produtos.Where(x => x.Nome == comboBoxProduto.Text).FirstOrDefault();
                    var valorTotal = produto.Preco * quantidade;
                    LabelValor.Text = valorTotal.ToString();
                }
                else
                {
                    LabelValor.Text = "";
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
