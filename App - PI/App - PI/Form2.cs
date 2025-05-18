﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App___PI
{
    public partial class Form2 : Form
    {
        private string usuarioLogado;

        public Form2()
        {
            InitializeComponent();
        }

        private void AtualizarSaldoTotal()
        {
            usuarioLogado = functions.ObterUsuarioLogado();

            if (string.IsNullOrEmpty(usuarioLogado))
            {
                lbl_saldoTotalConta.Text = "R$ 0,00";
                return;
            }

            // Recalcula o saldo baseado nas transações
            functions.RecalcularSaldoUsuario(usuarioLogado);

            // Obtém o saldo atualizado
            decimal saldoAtual = functions.ObterSaldoUsuario(usuarioLogado);
            lbl_saldoTotalConta.Text = $"R$ {saldoAtual:F2}";
        }

        private void AtualizarDataGrid()
        {
            usuarioLogado = functions.ObterUsuarioLogado();

            if (string.IsNullOrEmpty(usuarioLogado))
            {
                dataGridView1.DataSource = null;
                return;
            }

            // Mostra apenas as transações do usuário logado
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = functions.LerDatabasePorUsuario(usuarioLogado);
        }
        private void PopularCategoriasFiltro()
        {
            comboBox_Filtro.Items.Clear();
            comboBox_Filtro.Items.Add("Todas");

            var dt = functions.LerDatabasePorUsuario(usuarioLogado);
            var categorias = dt.AsEnumerable()
                               .Select(row => row["Categoria"].ToString().Trim())
                               .Distinct()
                               .OrderBy(c => c)
                               .ToList();

            foreach (var cat in categorias)
                comboBox_Filtro.Items.Add(cat);

            comboBox_Filtro.SelectedIndex = 0;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            // Verifica se há usuário logado
            usuarioLogado = functions.ObterUsuarioLogado();
            AtualizarDataGrid();
            AtualizarSaldoTotal();

            if (string.IsNullOrEmpty(usuarioLogado))
            {
                MessageBox.Show("Nenhum usuário logado. Redirecionando para login...");
                this.Close();
                return;
            }

            lbl_user.Text = $"Olá:{usuarioLogado}";
            PopularCategoriasFiltro();




        }

        private void btn_adicionarConta_Click(object sender, EventArgs e)
        {
            usuarioLogado = functions.ObterUsuarioLogado();

            if (string.IsNullOrEmpty(usuarioLogado))
            {
                MessageBox.Show("Usuário não está logado!");
                return;
            }

            Form3 addDespesa = new Form3();
            addDespesa.ShowDialog(); // Usa ShowDialog para aguardar o fechamento

            // Atualiza a tela após adicionar conta
            AtualizarDataGrid();
            AtualizarSaldoTotal();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Atualiza automaticamente quando clica na grid
            AtualizarDataGrid();
            AtualizarSaldoTotal();
        }

        private void lbl_saldoTotalConta_Click(object sender, EventArgs e)
        {
            // Pode implementar uma funcionalidade aqui se desejar
        }

        // Método para logout (você pode adicionar um botão para isso)
        private void btn_logout_Click(object sender, EventArgs e)
        {
            functions.Logout();
            MessageBox.Show("Logout realizado com sucesso!");
            this.Close();
        }

        // Override do evento FormClosing para dar opção de logout
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Deseja fazer logout ao fechar?", "Sair",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else if (result == DialogResult.Yes)
            {
                functions.Logout();
            }

            base.OnFormClosing(e);
        }

        private void btn_editarSaldo_Click(object sender, EventArgs e)
        {
            usuarioLogado = functions.ObterUsuarioLogado();
            if (string.IsNullOrEmpty(usuarioLogado))
            {
                MessageBox.Show("Usuário não está logado!");
                return;
            }

            Form4 AddSaldo = new Form4(usuarioLogado);
            AddSaldo.ShowDialog(); // Usa ShowDialog para aguardar o fechamento

            // Atualiza o saldo após adicionar
            AtualizarSaldoTotal();
        }

        private void btn_excluirConta_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string nome = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string categoria = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string tipo = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string data = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string valor = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                DialogResult dr = MessageBox.Show("Deseja realmente remover este item?", "Confirmação", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    functions.RemoverTransacao(nome, categoria, tipo, data, valor, usuarioLogado);
                    functions.RecalcularSaldoUsuario(usuarioLogado);
                    MessageBox.Show("Removido com sucesso!");
                    AtualizarDataGrid();
                    AtualizarSaldoTotal();
                }
            }
            else
            {
                MessageBox.Show("Selecione um item para excluir.");
            }
        }


        private void comboBox_Filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoriaSelecionada = comboBox_Filtro.SelectedItem.ToString();
            usuarioLogado = functions.ObterUsuarioLogado();

            if (string.IsNullOrEmpty(usuarioLogado))
                return;

            DataTable dt = functions.LerDatabasePorUsuario(usuarioLogado);

            if (categoriaSelecionada != "Todas")
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"Categoria = '{categoriaSelecionada}'";
                dataGridView1.DataSource = dv;
            }
            else
            {
                dataGridView1.DataSource = dt;
            }
        }

    }
}