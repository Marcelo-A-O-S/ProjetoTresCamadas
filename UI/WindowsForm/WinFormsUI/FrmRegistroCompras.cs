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
    public partial class FrmRegistroCompras : Form
    {
        private GestaoProdutoComprado gestaoProdutoComprado = new();
        private GestaoCompra gestaoCompra = new();
        public FrmRegistroCompras()
        {
            InitializeComponent();
            CarregarDgvCompras();
            CarregarDgvProdutos();
        }
        private void CarregarDgvProdutos()
        {
            try
            {
                dGVProdutosCompras.EditMode = DataGridViewEditMode.EditProgrammatically;
                dGVProdutosCompras.MultiSelect = false;
                dGVProdutosCompras.ColumnCount = 13;
                dGVProdutosCompras.Columns[0].HeaderText = "Id";
                dGVProdutosCompras.Columns[0].DataPropertyName = "Id";
                dGVProdutosCompras.Columns[0].Name = "Id";
                dGVProdutosCompras.Columns[0].Visible = false;
                dGVProdutosCompras.Columns[1].HeaderText = "Nome do Produto";
                dGVProdutosCompras.Columns[1].DataPropertyName = "NomeProduto";
                dGVProdutosCompras.Columns[1].Name = "NomeProduto";
                dGVProdutosCompras.Columns[1].Width = 250;
                dGVProdutosCompras.Columns[2].HeaderText = "Valor do Produto";
                dGVProdutosCompras.Columns[2].DataPropertyName = "ValorProduto";
                dGVProdutosCompras.Columns[2].Name = "ValorProduto";
                dGVProdutosCompras.Columns[2].Width = 250;
                dGVProdutosCompras.Columns[3].HeaderText = "Valor total do produto";
                dGVProdutosCompras.Columns[3].DataPropertyName = "ValorTotalProduto";
                dGVProdutosCompras.Columns[3].Name = "ValorTotalProduto";
                dGVProdutosCompras.Columns[3].Width = 250;
                dGVProdutosCompras.Columns[4].HeaderText = "Quantidade de Produtos";
                dGVProdutosCompras.Columns[4].DataPropertyName = "QuantidadeProdutos";
                dGVProdutosCompras.Columns[4].Name = "QuantidadeProdutos";
                dGVProdutosCompras.Columns[4].Width = 250;
                dGVProdutosCompras.Columns[5].HeaderText = "FornecedorId";
                dGVProdutosCompras.Columns[5].DataPropertyName = "FornecedorId";
                dGVProdutosCompras.Columns[5].Name = "FornecedorId";
                dGVProdutosCompras.Columns[5].Visible = false;
                dGVProdutosCompras.Columns[6].HeaderText = "Nome do Fornecedor";
                dGVProdutosCompras.Columns[6].DataPropertyName = "NomeFornecedor";
                dGVProdutosCompras.Columns[6].Name = "NomeFornecedor";
                dGVProdutosCompras.Columns[6].Width = 250;
                dGVProdutosCompras.Columns[7].HeaderText = "CompraId";
                dGVProdutosCompras.Columns[7].DataPropertyName = "CompraId";
                dGVProdutosCompras.Columns[7].Name = "CompraId";
                dGVProdutosCompras.Columns[7].Visible = false;
                dGVProdutosCompras.Columns[8].HeaderText = "compra";
                dGVProdutosCompras.Columns[8].DataPropertyName = "compra";
                dGVProdutosCompras.Columns[8].Name = "compra";
                dGVProdutosCompras.Columns[8].Visible = false;
                dGVProdutosCompras.Columns[9].HeaderText = "CategoriaId";
                dGVProdutosCompras.Columns[9].DataPropertyName = "CategoriaId";
                dGVProdutosCompras.Columns[9].Name = "CategoriaId";
                dGVProdutosCompras.Columns[9].Visible = false;
                dGVProdutosCompras.Columns[10].HeaderText = "Categoria";
                dGVProdutosCompras.Columns[10].DataPropertyName = "CategoriaNome";
                dGVProdutosCompras.Columns[10].Name = "CategoriaNome";
                dGVProdutosCompras.Columns[10].Width = 250;
                dGVProdutosCompras.Columns[11].HeaderText = "categoria";
                dGVProdutosCompras.Columns[11].DataPropertyName = "categoria";
                dGVProdutosCompras.Columns[11].Name = "categoria";
                dGVProdutosCompras.Columns[11].Visible = false;
                dGVProdutosCompras.Columns[12].HeaderText = "fornecedor";
                dGVProdutosCompras.Columns[12].DataPropertyName = "fornecedor";
                dGVProdutosCompras.Columns[12].Name = "fornecedor";
                dGVProdutosCompras.Columns[12].Visible = false;
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void CarregarDgvCompras()
        {
            try
            {
                dGVRegistrosCompras.EditMode = DataGridViewEditMode.EditProgrammatically;
                dGVRegistrosCompras.MultiSelect = false;
                dGVRegistrosCompras.ColumnCount = 13;
                dGVRegistrosCompras.Columns[0].HeaderText = "Id";
                dGVRegistrosCompras.Columns[0].DataPropertyName = "Id";
                dGVRegistrosCompras.Columns[0].Name = "Id";
                dGVRegistrosCompras.Columns[0].Visible = false;
                dGVRegistrosCompras.Columns[1].HeaderText = "Tipo de Pagamento";
                dGVRegistrosCompras.Columns[1].DataPropertyName = "TipoDePagamento";
                dGVRegistrosCompras.Columns[1].Name = "TipoDePagamento";
                dGVRegistrosCompras.Columns[1].Width = 150;
                dGVRegistrosCompras.Columns[2].HeaderText = "Quantidade de Produtos comprados";
                dGVRegistrosCompras.Columns[2].DataPropertyName = "QuantidadeComprados";
                dGVRegistrosCompras.Columns[2].Name = "QuantidadeComprados";
                dGVRegistrosCompras.Columns[2].Width = 250;
                dGVRegistrosCompras.Columns[3].HeaderText = "Data da Compra";
                dGVRegistrosCompras.Columns[3].DataPropertyName = "DataDaCompra";
                dGVRegistrosCompras.Columns[3].Name = "DataDaCompra";
                dGVRegistrosCompras.Columns[3].Width = 180;
                dGVRegistrosCompras.Columns[4].HeaderText = "Pagamento Realizado";
                dGVRegistrosCompras.Columns[4].DataPropertyName = "PagamentoRealizado";
                dGVRegistrosCompras.Columns[4].Name = "PagamentoRealizado";
                dGVRegistrosCompras.Columns[4].Width = 220;
                dGVRegistrosCompras.Columns[5].HeaderText = "Valor total da venda";
                dGVRegistrosCompras.Columns[5].DataPropertyName = "ValorTotal";
                dGVRegistrosCompras.Columns[5].Name = "ValorTotal";
                dGVRegistrosCompras.Columns[5].Width = 180;
                dGVRegistrosCompras.Columns[6].HeaderText = "FornecedorId";
                dGVRegistrosCompras.Columns[6].DataPropertyName = "FornecedorId";
                dGVRegistrosCompras.Columns[6].Name = "FornecedorId";
                dGVRegistrosCompras.Columns[6].Visible = false;
                dGVRegistrosCompras.Columns[7].HeaderText = "Nome Fantasia";
                dGVRegistrosCompras.Columns[7].DataPropertyName = "NomeFantasiaFornecedor";
                dGVRegistrosCompras.Columns[7].Name = "NomeFantasiaFornecedor";
                dGVRegistrosCompras.Columns[7].Width = 180;
                dGVRegistrosCompras.Columns[8].HeaderText = "FuncionarioId";
                dGVRegistrosCompras.Columns[8].DataPropertyName = "FuncionarioId";
                dGVRegistrosCompras.Columns[8].Name = "FuncionarioId";
                dGVRegistrosCompras.Columns[8].Visible = false;
                dGVRegistrosCompras.Columns[9].HeaderText = "Nome do Funcionario";
                dGVRegistrosCompras.Columns[9].DataPropertyName = "NomeFuncionario";
                dGVRegistrosCompras.Columns[9].Name = "NomeFuncionario";
                dGVRegistrosCompras.Columns[9].Width = 190;
                dGVRegistrosCompras.Columns[10].HeaderText = "fornecedor";
                dGVRegistrosCompras.Columns[10].DataPropertyName = "fornecedor";
                dGVRegistrosCompras.Columns[10].Name = "fornecedor";
                dGVRegistrosCompras.Columns[10].Visible = false;
                dGVRegistrosCompras.Columns[11].HeaderText = "funcionario";
                dGVRegistrosCompras.Columns[11].DataPropertyName = "funcionario";
                dGVRegistrosCompras.Columns[11].Name = "funcionario";
                dGVRegistrosCompras.Columns[11].Visible = false;
                dGVRegistrosCompras.Columns[12].HeaderText = "Valor Pago";
                dGVRegistrosCompras.Columns[12].DataPropertyName = "ValorPago";
                dGVRegistrosCompras.Columns[12].Name = "ValorPago";
                RecarregarGridCompra();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void RecarregarGridCompra()
        {
            try
            {
                dGVRegistrosCompras.DataSource = gestaoCompra.ObterCompras().Result.ToList();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void dGVRegistrosCompras_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dGVRegistrosCompras.SelectedRows.Count > 0)
                {
                    var line = dGVRegistrosCompras.SelectedRows[0];
                    if (line.Cells["Id"].Value != null)
                    {
                        var id = Convert.ToInt32(line.Cells["Id"].Value);
                        var produtosComprados = gestaoProdutoComprado.ObterProdutosComprados().Result.Where(x => x.CompraId == id).ToList();
                        dGVProdutosCompras.DataSource = produtosComprados;
                    }
                    else
                    {
                        MessageBox.Show("Selecione um registro!");
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
