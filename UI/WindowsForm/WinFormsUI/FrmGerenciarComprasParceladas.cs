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
    public partial class FrmGerenciarComprasParceladas : Form
    {
        private GestaoCompra gestaoCompra = new();
        private GestaoProdutoComprado gestaoProdutoComprado = new();
        private GestaoCompraParcelada gestaoCompraParcelada = new();
        private Compra compra = new();
        private CompraParcelada compraParcelada = new();
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
                dGVRegistrosComprasParceladas.DataSource = gestaoCompra.ObterCompras().Result.Where(x => x.TipoDePagamento == "Compra Parcelada" && x.PagamentoRealizado == false && x.ValorPago < x.ValorTotal).ToList();
            }catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private async void btnPagarParcelaCompra_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPagamento.Text != String.Empty)
                {
                    if (dGVInfoCompraParcela.SelectedRows.Count > 0)
                    {
                        var valorPago = Convert.ToDecimal(textBoxPagamento.Text);
                        compraParcelada.ValorRestante = compraParcelada.ValorRestante - valorPago;
                        compraParcelada.ValorPago += valorPago;
                        compraParcelada.ParcelasRestantes = compraParcelada.ParcelasRestantes - 1;
                        var retorno = gestaoCompraParcelada.SalvarCompraParcelada(compraParcelada);
                        MessageBox.Show(retorno);
                        if (compraParcelada.ValorPago >= compraParcelada.ValorTotal)
                        {
                            compra = gestaoCompra.BuscarCompraPor(x => x.Id == compraParcelada.CompraId);
                            compra.ValorPago = compraParcelada.ValorPago;
                            compra.PagamentoRealizado = true;
                            gestaoCompra.SalvarCompra(compra);
                            RecarregarGridCompraParceladas();
                        }
                        RecarregarGridCompraParceladas();

                    }
                    else
                    {
                        MessageBox.Show("Selecione o registro da parcela");
                    }
                }
                else
                {
                    MessageBox.Show("Informe o valor do pagamento");
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private async void dGVRegistrosComprasParceladas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dGVRegistrosComprasParceladas.SelectedRows.Count > 0)
                {
                    List<CompraParcelada> infoCompra = new();
                    var line = dGVRegistrosComprasParceladas.SelectedRows[0];
                    if (line.Cells["Id"].Value != null)
                    {
                        var Id = Convert.ToInt32(line.Cells["Id"].Value.ToString());
                        compraParcelada =  gestaoCompraParcelada.BuscarCompraParceladaPor(x => x.CompraId == Id);
                        infoCompra.Add(compraParcelada);
                        dGVInfoCompraParcela.DataSource = infoCompra.ToList();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione o registro de compra!");
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void btnAbaterRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                if (dGVInfoCompraParcela.SelectedRows.Count > 0)
                {
                    compraParcelada.ValorRestante = compraParcelada.ValorRestante - compraParcelada.ValorRestante;
                    compraParcelada.ParcelasRestantes = compraParcelada.ParcelasRestantes - compraParcelada.ParcelasRestantes;
                    compraParcelada.ValorPago = compraParcelada.ValorTotal;
                    var retorno = gestaoCompraParcelada.SalvarCompraParcelada(compraParcelada);
                    MessageBox.Show(retorno);
                    compra =  gestaoCompra.BuscarCompraPor(x => x.Id == compraParcelada.CompraId);
                    compra.ValorPago = compraParcelada.ValorTotal;
                    compra.PagamentoRealizado = true;
                    gestaoCompra.SalvarCompra(compra);
                    RecarregarGridCompraParceladas();
                }
                else
                {
                    MessageBox.Show("Selecione o registro da parcela");
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void btnRemoverRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                if (dGVInfoCompraParcela.SelectedRows.Count > 0)
                {
                    var retorno = gestaoCompraParcelada.ExcluirCompraParcelada(compraParcelada);
                    MessageBox.Show(retorno);
                    var produtos = gestaoProdutoComprado.ObterProdutosComprados().Result.Where(x => x.CompraId == compraParcelada.CompraId).ToList();
                    foreach (var produto in produtos)
                    {
                        gestaoProdutoComprado.ExcluirProdutoComprado(produto);
                    }
                    compra = gestaoCompra.BuscarCompraPor(x => x.Id == compraParcelada.CompraId);
                    //venda.PagamentoRealizado = true;
                    gestaoCompra.ExcluirCompra(compra);
                    RecarregarGridCompraParceladas();
                }
                else
                {
                    MessageBox.Show("Selecione o registro da parcela");
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void dGVInfoCompraParcela_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dGVInfoCompraParcela.SelectedRows.Count > 0)
                {

                    var line = dGVRegistrosComprasParceladas.SelectedRows[0];
                    var Id = Convert.ToInt32(line.Cells["Id"].Value.ToString());
                    compraParcelada = gestaoCompraParcelada.BuscarCompraParceladaPor(x => x.CompraId == Id);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
