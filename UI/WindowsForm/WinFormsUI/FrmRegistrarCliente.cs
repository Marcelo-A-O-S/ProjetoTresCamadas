﻿using ProjetoTresCamadas.Bussines.Services;
using ProjetosTresCamadas.Data.Entidades;
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
    public partial class FrmRegistrarCliente : Form
    {
        private GestaoClientes GestaoClientes = new();
        private Cliente cliente = new();
        public FrmRegistrarCliente()
        {
            InitializeComponent();
        }

        private async void FrmRegistrarCliente_Load(object sender, EventArgs e)
        {
            dataGridViewClientes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewClientes.MultiSelect = false;
            dataGridViewClientes.ColumnCount = 8;
            dataGridViewClientes.Columns[0].HeaderText = "Id";
            dataGridViewClientes.Columns[0].DataPropertyName = "Id";
            dataGridViewClientes.Columns[0].Name = "Id";
            dataGridViewClientes.Columns[0].HeaderText = "Nome";
            dataGridViewClientes.Columns[0].DataPropertyName = "Nome";
            dataGridViewClientes.Columns[0].Name = "Nome";
            dataGridViewClientes.Columns[1].HeaderText = "CPF";
            dataGridViewClientes.Columns[1].DataPropertyName = "CPF";
            dataGridViewClientes.Columns[1].Name = "CPF";
            dataGridViewClientes.Columns[2].HeaderText = "Telefone";
            dataGridViewClientes.Columns[2].DataPropertyName = "Telefone";
            dataGridViewClientes.Columns[2].Name = "Telefone";
            dataGridViewClientes.Columns[3].HeaderText = "Cidade";
            dataGridViewClientes.Columns[3].DataPropertyName = "Cidade";
            dataGridViewClientes.Columns[3].Name = "Cidade";
            dataGridViewClientes.Columns[4].HeaderText = "Rua";
            dataGridViewClientes.Columns[4].DataPropertyName = "Rua";
            dataGridViewClientes.Columns[4].Name = "Rua";
            dataGridViewClientes.Columns[5].HeaderText = "Bairro";
            dataGridViewClientes.Columns[5].DataPropertyName = "Bairro";
            dataGridViewClientes.Columns[5].Name = "Bairro";
            dataGridViewClientes.Columns[6].HeaderText = "Numero da Casa";
            dataGridViewClientes.Columns[6].DataPropertyName = "Numeracao";
            dataGridViewClientes.Columns[6].Name = "Numero da Casa";
            dataGridViewClientes.Columns[7].HeaderText = "CEP";
            dataGridViewClientes.Columns[7].DataPropertyName = "CEP";
            dataGridViewClientes.Columns[7].Name = "CEP";
            RecarregarGrid();
           
        }

        private async void RecarregarGrid()
        {
            
           
            dataGridViewClientes.DataSource = await GestaoClientes.ObterClientes();
               //.Select(x => new { x.Nome, x.Telefone, x.Cep, x.Bairro, x.Cidade, x.Numeracao, x.CPF, x.Rua }).ToList();
        }

        private async void btnCadastrarCliente_Click_1(object sender, EventArgs e)
        {
            cliente.Id = 0;
            cliente.Nome = textNomeCliente.Text;
            cliente.Cep = textCepCliente.Text;
            cliente.Telefone = textTelefoneCliente.Text;
            cliente.Rua = textRuaCliente.Text;
            cliente.Bairro = textBairroCliente.Text;
            cliente.Cidade = textCidadeCliente.Text;
            cliente.CPF = textCpfCliente.Text;
            cliente.Numeracao = Convert.ToInt32(textNumeroCliente.Text);
            using(GestaoClientes gestao = new GestaoClientes())
            {
                var retorno2 = gestao.SalvarCliente(cliente);
                gestao.Dispose();
                MessageBox.Show(retorno2);
                RecarregarGrid();
            }
            LimparCampos();
            //var retorno = GestaoClientes.SalvarCliente(cliente);


        }
        private void LimparCampos()
        {
            textNomeCliente.Text = String.Empty;
            textCepCliente.Text = String.Empty;
            textTelefoneCliente.Text = String.Empty;
            textRuaCliente.Text = String.Empty;
            textBairroCliente.Text = String.Empty;
            textCidadeCliente.Text = String.Empty;
            textCpfCliente.Text = String.Empty;
            textNumeroCliente.Text = String.Empty; 
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            
            cliente.Nome = textNomeCliente.Text;
            cliente.Cep = textCepCliente.Text;
            cliente.Telefone = textTelefoneCliente.Text;
            cliente.Rua = textRuaCliente.Text;
            cliente.Bairro = textBairroCliente.Text;
            cliente.Cidade = textCidadeCliente.Text;
            cliente.CPF = textCpfCliente.Text;
            cliente.Numeracao = Convert.ToInt32(textNumeroCliente.Text);
            using (GestaoClientes gestao = new GestaoClientes())
            {
                var retorno2 = gestao.SalvarCliente(cliente);
                gestao.Dispose();
                MessageBox.Show(retorno2);
                RecarregarGrid();
            }
        }

        private void dataGridViewClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dataGridViewClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow lines = dataGridViewClientes.SelectedRows[0];
                textNomeCliente.Text = (string)lines.Cells["Nome"].Value;
                textCepCliente.Text = (string)lines.Cells["CEP"].Value; 
                textTelefoneCliente.Text = (string)lines.Cells["Telefone"].Value; 
                textRuaCliente.Text = (string)lines.Cells["Rua"].Value; ;
                textBairroCliente.Text = (string)lines.Cells["Bairro"].Value; 
                textCidadeCliente.Text = (string)lines.Cells["Cidade"].Value; 
                textCpfCliente.Text = (string)lines.Cells["CPF"].Value;
                textNumeroCliente.Text = lines.Cells["Numero da Casa"].Value.ToString();
                cliente.Id = (int)lines.Cells["Id"].Value;
            }
            
        }

        private void btnRemoverCliente_Click(object sender, EventArgs e)
        {
            cliente.Nome = textNomeCliente.Text;
            cliente.Cep = textCepCliente.Text;
            cliente.Telefone = textTelefoneCliente.Text;
            cliente.Rua = textRuaCliente.Text;
            cliente.Bairro = textBairroCliente.Text;
            cliente.Cidade = textCidadeCliente.Text;
            cliente.CPF = textCpfCliente.Text;
            cliente.Numeracao = Convert.ToInt32(textNumeroCliente.Text);
            using (GestaoClientes gestao = new GestaoClientes())
            {
                var retorno2 = gestao.RemoverCliente(cliente);
                gestao.Dispose();
                MessageBox.Show(retorno2);
                RecarregarGrid();
            }
        }
    }
}