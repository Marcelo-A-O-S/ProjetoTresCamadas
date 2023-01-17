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
    public partial class FrmRegistroVendas : Form
    {
        private GestaoProdutosVendidos gestaoProdutosVendidos = new();
        private GestaoVendas gestaoVendas = new();
        public FrmRegistroVendas()
        {
            InitializeComponent();
            CarregarRegistroVenda();
            CarregarHeaderProdutos();
        }


        private void FrmRegistroVendas_Load(object sender, EventArgs e)
        {
            
        }

        private void CarregarHeaderProdutos()
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
        private void CarregarRegistroVenda()
        {
            dGVRegistrosVendas.EditMode = DataGridViewEditMode.EditProgrammatically;
            dGVRegistrosVendas.MultiSelect = false;
            dGVRegistrosVendas.ColumnCount = 12;
            dGVRegistrosVendas.Columns[0].HeaderText = "Id";
            dGVRegistrosVendas.Columns[0].DataPropertyName = "Id";
            dGVRegistrosVendas.Columns[0].Name = "Id";
            dGVRegistrosVendas.Columns[0].Visible = false;
            dGVRegistrosVendas.Columns[1].HeaderText = "Tipo de Pagamento";
            dGVRegistrosVendas.Columns[1].DataPropertyName = "TipoDePagamento";
            dGVRegistrosVendas.Columns[1].Name = "TipoDePagamento";
            dGVRegistrosVendas.Columns[1].Width = 150;
            dGVRegistrosVendas.Columns[2].HeaderText = "Quantidade de Produtos vendidos";
            dGVRegistrosVendas.Columns[2].DataPropertyName = "QuantidadeVendidos";
            dGVRegistrosVendas.Columns[2].Name = "QuantidadeVendidos";
            dGVRegistrosVendas.Columns[2].Width = 150;
            dGVRegistrosVendas.Columns[3].HeaderText = "Data da venda";
            dGVRegistrosVendas.Columns[3].DataPropertyName = "DataDaVenda";
            dGVRegistrosVendas.Columns[3].Name = "DataDaVenda";
            dGVRegistrosVendas.Columns[3].Width = 150;
            dGVRegistrosVendas.Columns[4].HeaderText = "Pagamento Realizado";
            dGVRegistrosVendas.Columns[4].DataPropertyName = "PagamentoRealizado";
            dGVRegistrosVendas.Columns[4].Name = "PagamentoRealizado";
            dGVRegistrosVendas.Columns[4].Width = 150;
            dGVRegistrosVendas.Columns[5].HeaderText = "Valor total da venda";
            dGVRegistrosVendas.Columns[5].DataPropertyName = "ValorTotal";
            dGVRegistrosVendas.Columns[5].Name = "ValorTotal";
            dGVRegistrosVendas.Columns[6].HeaderText = "ClienteId";
            dGVRegistrosVendas.Columns[6].DataPropertyName = "ClienteId";
            dGVRegistrosVendas.Columns[6].Name = "ClienteId";
            dGVRegistrosVendas.Columns[6].Visible = false;
            dGVRegistrosVendas.Columns[7].HeaderText = "Nome do Cliente";
            dGVRegistrosVendas.Columns[7].DataPropertyName = "NomeCliente";
            dGVRegistrosVendas.Columns[7].Name = "NomeCliente";
            dGVRegistrosVendas.Columns[8].HeaderText = "FuncionarioId";
            dGVRegistrosVendas.Columns[8].DataPropertyName = "FuncionarioId";
            dGVRegistrosVendas.Columns[8].Name = "FuncionarioId";
            dGVRegistrosVendas.Columns[8].Visible = false;
            dGVRegistrosVendas.Columns[9].HeaderText = "Nome do Funcionario";
            dGVRegistrosVendas.Columns[9].DataPropertyName = "NomeFuncionario";
            dGVRegistrosVendas.Columns[9].Name = "NomeFuncionario";
            dGVRegistrosVendas.Columns[10].HeaderText = "cliente";
            dGVRegistrosVendas.Columns[10].DataPropertyName = "cliente";
            dGVRegistrosVendas.Columns[10].Name = "cliente";
            dGVRegistrosVendas.Columns[10].Visible = false;
            dGVRegistrosVendas.Columns[11].HeaderText = "funcionario";
            dGVRegistrosVendas.Columns[11].DataPropertyName = "funcionario";
            dGVRegistrosVendas.Columns[11].Name = "funcionario";
            dGVRegistrosVendas.Columns[11].Visible = false;
            RecarregarGridVendas();
        }
        private async void RecarregarGridVendas()
        {
            dGVRegistrosVendas.DataSource = await gestaoVendas.ObterVendas();
        }

        private async void dGVRegistrosVendas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dGVRegistrosVendas.SelectedRows.Count > 0)
            {
                var line = dGVRegistrosVendas.SelectedRows[0];
                var id = Convert.ToInt32(line.Cells["Id"].Value);
                var produtosVendidos = gestaoProdutosVendidos.ObterProdutosVendidos().Result.Where(x => x.VendaId == id).ToList();
                dGVProdutosVendas.DataSource = produtosVendidos;
            }
        }
    }
}
