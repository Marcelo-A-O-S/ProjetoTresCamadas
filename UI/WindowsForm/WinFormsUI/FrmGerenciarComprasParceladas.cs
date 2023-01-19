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
    public partial class FrmGerenciarComprasParceladas : Form
    {
        private GestaoCompra gestaoCompra = new();
        public FrmGerenciarComprasParceladas()
        {
            InitializeComponent();
            CarregarDgvCompraParcelada();
            CarregarDgvInfoCompraParcelada();
        }
        private void CarregarDgvInfoCompraParcelada()
        {
            try
            {
                dGVInfoCompraParcela.EditMode = DataGridViewEditMode.EditProgrammatically;
                dGVInfoCompraParcela.MultiSelect = false;
                dGVInfoCompraParcela.ColumnCount = 12;
                dGVInfoCompraParcela.Columns[0].HeaderText = "Id";
                dGVInfoCompraParcela.Columns[0].DataPropertyName = "Id";
                dGVInfoCompraParcela.Columns[0].Name = "Id";
                dGVInfoCompraParcela.Columns[0].Visible = false;
                dGVInfoCompraParcela.Columns[1].HeaderText = "Quantidade de Parcelas";
                dGVInfoCompraParcela.Columns[1].DataPropertyName = "QuantidadeParcelas";
                dGVInfoCompraParcela.Columns[1].Name = "QuantidadeParcelas";
                dGVInfoCompraParcela.Columns[2].HeaderText = "Quantidade de Parcelas restantes";
                dGVInfoCompraParcela.Columns[2].DataPropertyName = "ParcelasRestantes";
                dGVInfoCompraParcela.Columns[2].Name = "ParcelasRestantes";
                dGVInfoCompraParcela.Columns[3].HeaderText = "Valor das parcelas";
                dGVInfoCompraParcela.Columns[3].DataPropertyName = "ValorDaParcela";
                dGVInfoCompraParcela.Columns[3].Name = "ValorDaParcela";
                dGVInfoCompraParcela.Columns[4].HeaderText = "Valor restante a ser pago";
                dGVInfoCompraParcela.Columns[4].DataPropertyName = "ValorRestante";
                dGVInfoCompraParcela.Columns[4].Name = "ValorRestante";
                dGVInfoCompraParcela.Columns[5].HeaderText = "Valor total da compra";
                dGVInfoCompraParcela.Columns[5].DataPropertyName = "ValorTotal";
                dGVInfoCompraParcela.Columns[5].Name = "ValorTotal";
                dGVInfoCompraParcela.Columns[6].HeaderText = "Mês de realizacão da compra";
                dGVInfoCompraParcela.Columns[6].DataPropertyName = "MesInicial";
                dGVInfoCompraParcela.Columns[6].Name = "MesInicial";
                dGVInfoCompraParcela.Columns[7].HeaderText = "Mês final de pagamento";
                dGVInfoCompraParcela.Columns[7].DataPropertyName = "MesFinal";
                dGVInfoCompraParcela.Columns[7].Name = "MesFinal";
                dGVInfoCompraParcela.Columns[8].HeaderText = "Data do primeiro pagamento";
                dGVInfoCompraParcela.Columns[8].DataPropertyName = "DataPagamentoInicial";
                dGVInfoCompraParcela.Columns[8].Name = "DataPagamentoInicial";
                dGVInfoCompraParcela.Columns[9].HeaderText = "CompraId";
                dGVInfoCompraParcela.Columns[9].DataPropertyName = "CompraId";
                dGVInfoCompraParcela.Columns[9].Name = "CompraId";
                dGVInfoCompraParcela.Columns[9].Visible = false;
                dGVInfoCompraParcela.Columns[10].HeaderText = "compra";
                dGVInfoCompraParcela.Columns[10].DataPropertyName = "compra";
                dGVInfoCompraParcela.Columns[10].Name = "compra";
                dGVInfoCompraParcela.Columns[10].Visible = false;
                dGVInfoCompraParcela.Columns[11].HeaderText = "Valor Pago";
                dGVInfoCompraParcela.Columns[11].DataPropertyName = "ValorPago";
                dGVInfoCompraParcela.Columns[11].Name = "ValorPago";
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void CarregarDgvCompraParcelada()
        {
            try
            {
                dGVRegistrosComprasParceladas.EditMode = DataGridViewEditMode.EditProgrammatically;
                dGVRegistrosComprasParceladas.MultiSelect = false;
                dGVRegistrosComprasParceladas.ColumnCount = 13;
                dGVRegistrosComprasParceladas.Columns[0].HeaderText = "Id";
                dGVRegistrosComprasParceladas.Columns[0].DataPropertyName = "Id";
                dGVRegistrosComprasParceladas.Columns[0].Name = "Id";
                dGVRegistrosComprasParceladas.Columns[0].Visible = false;
                dGVRegistrosComprasParceladas.Columns[1].HeaderText = "Tipo de Pagamento";
                dGVRegistrosComprasParceladas.Columns[1].DataPropertyName = "TipoDePagamento";
                dGVRegistrosComprasParceladas.Columns[1].Name = "TipoDePagamento";
                dGVRegistrosComprasParceladas.Columns[1].Width = 150;
                dGVRegistrosComprasParceladas.Columns[2].HeaderText = "Quantidade de Produtos comprados";
                dGVRegistrosComprasParceladas.Columns[2].DataPropertyName = "QuantidadeComprados";
                dGVRegistrosComprasParceladas.Columns[2].Name = "QuantidadeComprados";
                dGVRegistrosComprasParceladas.Columns[2].Width = 150;
                dGVRegistrosComprasParceladas.Columns[3].HeaderText = "Data da Compra";
                dGVRegistrosComprasParceladas.Columns[3].DataPropertyName = "DataDaCompra";
                dGVRegistrosComprasParceladas.Columns[3].Name = "DataDaCompra";
                dGVRegistrosComprasParceladas.Columns[3].Width = 150;
                dGVRegistrosComprasParceladas.Columns[4].HeaderText = "Pagamento Realizado";
                dGVRegistrosComprasParceladas.Columns[4].DataPropertyName = "PagamentoRealizado";
                dGVRegistrosComprasParceladas.Columns[4].Name = "PagamentoRealizado";
                dGVRegistrosComprasParceladas.Columns[4].Width = 150;
                dGVRegistrosComprasParceladas.Columns[5].HeaderText = "Valor total da venda";
                dGVRegistrosComprasParceladas.Columns[5].DataPropertyName = "ValorTotal";
                dGVRegistrosComprasParceladas.Columns[5].Name = "ValorTotal";
                dGVRegistrosComprasParceladas.Columns[6].HeaderText = "FornecedorId";
                dGVRegistrosComprasParceladas.Columns[6].DataPropertyName = "FornecedorId";
                dGVRegistrosComprasParceladas.Columns[6].Name = "FornecedorId";
                dGVRegistrosComprasParceladas.Columns[6].Visible = false;
                dGVRegistrosComprasParceladas.Columns[7].HeaderText = "Nome Fantasia";
                dGVRegistrosComprasParceladas.Columns[7].DataPropertyName = "NomeFantasiaFornecedor";
                dGVRegistrosComprasParceladas.Columns[7].Name = "NomeFantasiaFornecedor";
                dGVRegistrosComprasParceladas.Columns[8].HeaderText = "FuncionarioId";
                dGVRegistrosComprasParceladas.Columns[8].DataPropertyName = "FuncionarioId";
                dGVRegistrosComprasParceladas.Columns[8].Name = "FuncionarioId";
                dGVRegistrosComprasParceladas.Columns[8].Visible = false;
                dGVRegistrosComprasParceladas.Columns[9].HeaderText = "Nome do Funcionario";
                dGVRegistrosComprasParceladas.Columns[9].DataPropertyName = "NomeFuncionario";
                dGVRegistrosComprasParceladas.Columns[9].Name = "NomeFuncionario";
                dGVRegistrosComprasParceladas.Columns[10].HeaderText = "fornecedor";
                dGVRegistrosComprasParceladas.Columns[10].DataPropertyName = "fornecedor";
                dGVRegistrosComprasParceladas.Columns[10].Name = "fornecedor";
                dGVRegistrosComprasParceladas.Columns[10].Visible = false;
                dGVRegistrosComprasParceladas.Columns[11].HeaderText = "funcionario";
                dGVRegistrosComprasParceladas.Columns[11].DataPropertyName = "funcionario";
                dGVRegistrosComprasParceladas.Columns[11].Name = "funcionario";
                dGVRegistrosComprasParceladas.Columns[11].Visible = false;
                dGVRegistrosComprasParceladas.Columns[12].HeaderText = "Valor Pago";
                dGVRegistrosComprasParceladas.Columns[12].DataPropertyName = "ValorPago";
                dGVRegistrosComprasParceladas.Columns[12].Name = "ValorPago";
                RecarregarGridCompraParceladas();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void RecarregarGridCompraParceladas()
        {
            try
            {
                dGVRegistrosComprasParceladas.DataSource = gestaoCompra.ObterCompras().Result.Where(x => x.TipoDePagamento == "Compra Parcelada" && x.PagamentoRealizado == false && x.ValorPago == x.ValorTotal).ToList();
            }catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
