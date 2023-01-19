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
    public partial class FrmGerenciarVendasParceladas : Form
    {
        private GestaoVendas gestaoVendas = new();
        private GestaoVendasParceladas gestaoVendasParceladas = new();
        private VendaParcelada vendaParcelada = new();
        private Venda venda = new();
        public FrmGerenciarVendasParceladas()
        {
            InitializeComponent();
            CarregarRegistroVendaParcelda();
            CarregarInfoParcelas();
        }
        private void CarregarInfoParcelas()
        {
            try
            {
                dGVInfoParcela.EditMode = DataGridViewEditMode.EditProgrammatically;
                dGVInfoParcela.MultiSelect = false;
                dGVInfoParcela.ColumnCount = 12;
                dGVInfoParcela.Columns[0].HeaderText = "Id";
                dGVInfoParcela.Columns[0].DataPropertyName = "Id";
                dGVInfoParcela.Columns[0].Name = "Id";
                dGVInfoParcela.Columns[0].Visible = false;
                dGVInfoParcela.Columns[1].HeaderText = "Quantidade de Parcelas";
                dGVInfoParcela.Columns[1].DataPropertyName = "QuantidadeParcelas";
                dGVInfoParcela.Columns[1].Name = "QuantidadeParcelas";
                dGVInfoParcela.Columns[2].HeaderText = "Quantidade de Parcelas restantes";
                dGVInfoParcela.Columns[2].DataPropertyName = "ParcelasRestantes";
                dGVInfoParcela.Columns[2].Name = "ParcelasRestantes";
                dGVInfoParcela.Columns[3].HeaderText = "Valor das parcelas";
                dGVInfoParcela.Columns[3].DataPropertyName = "ValorDaParcela";
                dGVInfoParcela.Columns[3].Name = "ValorDaParcela";
                dGVInfoParcela.Columns[4].HeaderText = "Valor restante a ser pago";
                dGVInfoParcela.Columns[4].DataPropertyName = "ValorRestante";
                dGVInfoParcela.Columns[4].Name = "ValorRestante";
                dGVInfoParcela.Columns[5].HeaderText = "Valor total da venda";
                dGVInfoParcela.Columns[5].DataPropertyName = "ValorTotal";
                dGVInfoParcela.Columns[5].Name = "ValorTotal";
                dGVInfoParcela.Columns[6].HeaderText = "Mês de realizacão da venda";
                dGVInfoParcela.Columns[6].DataPropertyName = "MesInicial";
                dGVInfoParcela.Columns[6].Name = "MesInicial";
                dGVInfoParcela.Columns[7].HeaderText = "Mês final de pagamento";
                dGVInfoParcela.Columns[7].DataPropertyName = "MesFinal";
                dGVInfoParcela.Columns[7].Name = "MesFinal";
                dGVInfoParcela.Columns[8].HeaderText = "Data do primeiro pagamento";
                dGVInfoParcela.Columns[8].DataPropertyName = "DataPagamentoInicial";
                dGVInfoParcela.Columns[8].Name = "DataPagamentoInicial";
                dGVInfoParcela.Columns[9].HeaderText = "VendaId";
                dGVInfoParcela.Columns[9].DataPropertyName = "VendaId";
                dGVInfoParcela.Columns[9].Name = "VendaId";
                dGVInfoParcela.Columns[9].Visible = false;
                dGVInfoParcela.Columns[10].HeaderText = "venda";
                dGVInfoParcela.Columns[10].DataPropertyName = "venda";
                dGVInfoParcela.Columns[10].Name = "venda";
                dGVInfoParcela.Columns[10].Visible = false;
                dGVInfoParcela.Columns[11].HeaderText = "Valor Pago";
                dGVInfoParcela.Columns[11].DataPropertyName = "ValorPago";
                dGVInfoParcela.Columns[11].Name = "ValorPago";
            }catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void CarregarRegistroVendaParcelda()
        {
            try
            {
                dGVRegistrosVendasParceladas.EditMode = DataGridViewEditMode.EditProgrammatically;
                dGVRegistrosVendasParceladas.MultiSelect = false;
                dGVRegistrosVendasParceladas.ColumnCount = 13;
                dGVRegistrosVendasParceladas.Columns[0].HeaderText = "Id";
                dGVRegistrosVendasParceladas.Columns[0].DataPropertyName = "Id";
                dGVRegistrosVendasParceladas.Columns[0].Name = "Id";
                dGVRegistrosVendasParceladas.Columns[0].Visible = false;
                dGVRegistrosVendasParceladas.Columns[1].HeaderText = "Tipo de Pagamento";
                dGVRegistrosVendasParceladas.Columns[1].DataPropertyName = "TipoDePagamento";
                dGVRegistrosVendasParceladas.Columns[1].Name = "TipoDePagamento";
                dGVRegistrosVendasParceladas.Columns[1].Width = 150;
                dGVRegistrosVendasParceladas.Columns[2].HeaderText = "Quantidade de Produtos vendidos";
                dGVRegistrosVendasParceladas.Columns[2].DataPropertyName = "QuantidadeVendidos";
                dGVRegistrosVendasParceladas.Columns[2].Name = "QuantidadeVendidos";
                dGVRegistrosVendasParceladas.Columns[2].Width = 150;
                dGVRegistrosVendasParceladas.Columns[3].HeaderText = "Data da venda";
                dGVRegistrosVendasParceladas.Columns[3].DataPropertyName = "DataDaVenda";
                dGVRegistrosVendasParceladas.Columns[3].Name = "DataDaVenda";
                dGVRegistrosVendasParceladas.Columns[3].Width = 150;
                dGVRegistrosVendasParceladas.Columns[4].HeaderText = "Pagamento Realizado";
                dGVRegistrosVendasParceladas.Columns[4].DataPropertyName = "PagamentoRealizado";
                dGVRegistrosVendasParceladas.Columns[4].Name = "PagamentoRealizado";
                dGVRegistrosVendasParceladas.Columns[4].Width = 150;
                dGVRegistrosVendasParceladas.Columns[5].HeaderText = "Valor total da venda";
                dGVRegistrosVendasParceladas.Columns[5].DataPropertyName = "ValorTotal";
                dGVRegistrosVendasParceladas.Columns[5].Name = "ValorTotal";
                dGVRegistrosVendasParceladas.Columns[6].HeaderText = "ClienteId";
                dGVRegistrosVendasParceladas.Columns[6].DataPropertyName = "ClienteId";
                dGVRegistrosVendasParceladas.Columns[6].Name = "ClienteId";
                dGVRegistrosVendasParceladas.Columns[6].Visible = false;
                dGVRegistrosVendasParceladas.Columns[7].HeaderText = "Nome do Cliente";
                dGVRegistrosVendasParceladas.Columns[7].DataPropertyName = "NomeCliente";
                dGVRegistrosVendasParceladas.Columns[7].Name = "NomeCliente";
                dGVRegistrosVendasParceladas.Columns[8].HeaderText = "FuncionarioId";
                dGVRegistrosVendasParceladas.Columns[8].DataPropertyName = "FuncionarioId";
                dGVRegistrosVendasParceladas.Columns[8].Name = "FuncionarioId";
                dGVRegistrosVendasParceladas.Columns[8].Visible = false;
                dGVRegistrosVendasParceladas.Columns[9].HeaderText = "Nome do Funcionario";
                dGVRegistrosVendasParceladas.Columns[9].DataPropertyName = "NomeFuncionario";
                dGVRegistrosVendasParceladas.Columns[9].Name = "NomeFuncionario";
                dGVRegistrosVendasParceladas.Columns[10].HeaderText = "cliente";
                dGVRegistrosVendasParceladas.Columns[10].DataPropertyName = "cliente";
                dGVRegistrosVendasParceladas.Columns[10].Name = "cliente";
                dGVRegistrosVendasParceladas.Columns[10].Visible = false;
                dGVRegistrosVendasParceladas.Columns[11].HeaderText = "funcionario";
                dGVRegistrosVendasParceladas.Columns[11].DataPropertyName = "funcionario";
                dGVRegistrosVendasParceladas.Columns[11].Name = "funcionario";
                dGVRegistrosVendasParceladas.Columns[11].Visible = false;
                dGVRegistrosVendasParceladas.Columns[12].HeaderText = "Valor Pago";
                dGVRegistrosVendasParceladas.Columns[12].DataPropertyName = "ValorPago";
                dGVRegistrosVendasParceladas.Columns[12].Name = "ValorPago";
                RecarregarGridVendasParceladas();
            }catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void RecarregarGridVendasParceladas()
        {
            try
            {
                dGVRegistrosVendasParceladas.DataSource = gestaoVendas.ObterVendas().Result.Where(x => x.TipoDePagamento == "Venda Parcelada" && x.PagamentoRealizado == false && x.ValorPago == x.ValorTotal).ToList();
            }catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }  
        }
        private async void dGVRegistrosVendasParceladas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dGVRegistrosVendasParceladas.SelectedRows.Count > 0)
                {
                    List<VendaParcelada> infoVenda = new();
                    var line = dGVRegistrosVendasParceladas.SelectedRows[0];
                    if (line.Cells["Id"].Value != null)
                    {
                        var Id = Convert.ToInt32(line.Cells["Id"].Value.ToString());
                        vendaParcelada = await gestaoVendasParceladas.BuscarVendaParcelada(x => x.VendaId == Id);
                        infoVenda.Add(vendaParcelada);
                        dGVInfoParcela.DataSource = infoVenda.ToList();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione o registro de venda!");
                }
            }catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private async void btnPagarParcela_Click(object sender, EventArgs e)
        {
            if (dGVInfoParcela.SelectedRows.Count > 0)
            {
                vendaParcelada.ValorRestante = vendaParcelada.ValorRestante - vendaParcelada.ValorDaParcela;
                vendaParcelada.ValorPago += vendaParcelada.ValorDaParcela;
                vendaParcelada.ParcelasRestantes = vendaParcelada.ParcelasRestantes - 1;
                //var retorno = gestaoVendasParceladas.SalvarVendaParcelada(vendaParcelada);
                //MessageBox.Show(retorno);
                if(vendaParcelada.ParcelasRestantes == 0)
                {
                    venda = await gestaoVendas.BuscarVendaPor(x => x.Id == vendaParcelada.VendaId);
                    venda.ValorPago += vendaParcelada.ValorDaParcela;
                    venda.PagamentoRealizado = true;
                    //gestaoVendas.SalvarVenda(venda);
                }
            }
            else
            {
                MessageBox.Show("Selecione o registro da parcela");
            }
        }
        private async void btnAbaterRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                if (dGVInfoParcela.SelectedRows.Count > 0)
                {
                    vendaParcelada.ValorRestante = vendaParcelada.ValorRestante - vendaParcelada.ValorRestante;
                    vendaParcelada.ParcelasRestantes = vendaParcelada.ParcelasRestantes - vendaParcelada.ParcelasRestantes;
                    vendaParcelada.ValorPago = vendaParcelada.ValorTotal;
                    var retorno = gestaoVendasParceladas.SalvarVendaParcelada(vendaParcelada);
                    MessageBox.Show(retorno);
                    venda = await gestaoVendas.BuscarVendaPor(x => x.Id == vendaParcelada.VendaId);
                    venda.ValorPago = vendaParcelada.ValorTotal;
                    venda.PagamentoRealizado = true;
                    gestaoVendas.SalvarVenda(venda);
                }
                else
                {
                    MessageBox.Show("Selecione o registro da parcela");
                }
            }catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private async void btnRemoverRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                if (dGVInfoParcela.SelectedRows.Count > 0)
                {
                    var retorno = gestaoVendasParceladas.ExcluirVendaParcelada(vendaParcelada);
                    MessageBox.Show(retorno);
                    venda = await gestaoVendas.BuscarVendaPor(x => x.Id == vendaParcelada.VendaId);
                    venda.PagamentoRealizado = true;
                    gestaoVendas.ExcluirVenda(venda);
                }
                else
                {
                    MessageBox.Show("Selecione o registro da parcela");
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
        }
        private async void dGVInfoParcela_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dGVInfoParcela.SelectedRows.Count > 0)
                {

                    var line = dGVRegistrosVendasParceladas.SelectedRows[0];
                    var Id = Convert.ToInt32(line.Cells["Id"].Value.ToString());
                    vendaParcelada = await gestaoVendasParceladas.BuscarVendaParcelada(x => x.VendaId == Id);
                }
            }catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
