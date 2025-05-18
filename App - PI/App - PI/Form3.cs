using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App___PI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_salvarConta_Click(object sender, EventArgs e)
        {
            // Validações básicas
            if (string.IsNullOrWhiteSpace(txt_nomeConta.Text))
            {
                MessageBox.Show("Por favor, insira o nome da conta.");
                txt_nomeConta.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_categoriaConta.Text))
            {
                MessageBox.Show("Por favor, insira a categoria.");
                txt_categoriaConta.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(comboBox_DespesaReceita.Text))
            {
                MessageBox.Show("Por favor, selecione se é Receita ou Despesa.");
                comboBox_DespesaReceita.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_valor.Text))
            {
                MessageBox.Show("Por favor, insira o valor.");
                txt_valor.Focus();
                return;
            }

            // Valida o valor numérico
            string valorStr = txt_valor.Text.Trim().Replace("R$", "").Replace(",", ".");
            if (!decimal.TryParse(valorStr, System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out decimal valorDecimal) || valorDecimal <= 0)
            {
                MessageBox.Show("Por favor, insira um valor válido maior que zero.");
                txt_valor.Focus();
                return;
            }

            // Obtém o usuário logado
            string usuarioLogado = functions.ObterUsuarioLogado();
            if (string.IsNullOrEmpty(usuarioLogado))
            {
                MessageBox.Show("Usuário não está logado!");
                return;
            }

            // Coleta os dados do formulário
            string nomeConta = txt_nomeConta.Text.Trim();
            string categoriaConta = txt_categoriaConta.Text.Trim();
            string tipoConta = comboBox_DespesaReceita.Text.Trim();
            string dataConta = dateTime_DataConta.Value.ToString("dd/MM/yyyy");
            string valorConta = valorDecimal.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);

            try
            {
                // Adiciona a conta (isso já atualiza automaticamente o saldo do usuário)
                functions.AdicionarConta(nomeConta, categoriaConta, tipoConta, dataConta, valorConta, usuarioLogado);

                MessageBox.Show("Conta adicionada com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar a conta: {ex.Message}");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Configura o ComboBox se não estiver configurado no designer
            if (comboBox_DespesaReceita.Items.Count == 0)
            {
                comboBox_DespesaReceita.Items.Add("Receita");
                comboBox_DespesaReceita.Items.Add("Despesa");
            }

            // Define data atual como padrão
            dateTime_DataConta.Value = DateTime.Now;

            // Define foco no primeiro campo
            txt_nomeConta.Focus();
        }

        // Evento para formatar automaticamente o valor enquanto digita
        private void txt_valor_TextChanged(object sender, EventArgs e)
        {
            // Remove formatação anterior para evitar loops
            string texto = txt_valor.Text.Replace("R$", "").Replace(" ", "").Replace(",", ".");

            // Tenta converter para decimal e reformatar
            if (decimal.TryParse(texto, System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out decimal valor))
            {
                // Salva a posição do cursor
                int cursorPos = txt_valor.SelectionStart;

                // Formata o valor
                txt_valor.Text = $"R$ {valor:F2}".Replace(".", ",");

                // Restaura a posição do cursor (aproximadamente)
                txt_valor.SelectionStart = Math.Min(cursorPos, txt_valor.Text.Length);
            }
        }

        // Valida apenas números, vírgula e ponto no campo valor
        private void txt_valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números, backspace, vírgula e ponto
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permite apenas uma vírgula ou ponto
            if ((e.KeyChar == ',' || e.KeyChar == '.') &&
                (txt_valor.Text.Contains(',') || txt_valor.Text.Contains('.')))
            {
                e.Handled = true;
            }
        }
    }
}