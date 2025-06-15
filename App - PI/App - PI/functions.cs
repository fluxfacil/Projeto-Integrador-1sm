using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App___PI
{
    public static class functions
    {
        public static string CaminhoFluxoFacilDatabase = @"C:\Users\Public\Documents\fluxofacildatabase.csv";
        public static string CaminhoFluxoFaciluser = @"C:\Users\Public\Documents\fluxofaciluser.csv";
        public static string CaminhoUsuarioLogado = @"C:\Users\Public\Documents\usuariologado.txt";

        // ========== GERENCIAMENTO DE USUÁRIOS ==========

        public static void CadastrarUsuario(string nome, string senha)
        {
            CriarArquivosSeNaoExistir();

            var linhas = File.ReadAllLines(CaminhoFluxoFaciluser).ToList();
            bool existe = linhas.Skip(1).Any(l => l.Split(',')[0].Trim().Equals(nome.Trim(), StringComparison.OrdinalIgnoreCase));

            if (existe)
            {
                MessageBox.Show("Usuário já cadastrado.");
                return;
            }

            using (StreamWriter sw = new StreamWriter(CaminhoFluxoFaciluser, true))
            {
                sw.WriteLine($"{nome},{senha},0.00");
            }

            MessageBox.Show("Usuário cadastrado com sucesso!");
        }

        public static bool FazerLogin(string nome, string senha)
        {
            if (!File.Exists(CaminhoFluxoFaciluser)) return false;

            var linhas = File.ReadAllLines(CaminhoFluxoFaciluser);

            foreach (var linha in linhas.Skip(1)) // Pula o cabeçalho
            {
                var partes = linha.Split(',');
                if (partes.Length >= 2 &&
                    partes[0].Trim().Equals(nome.Trim(), StringComparison.OrdinalIgnoreCase) &&
                    partes[1].Trim() == senha.Trim())
                {
                    // Salva o usuário logado em arquivo
                    File.WriteAllText(CaminhoUsuarioLogado, nome.Trim());
                    return true;
                }
            }
            return false;
        }

        public static string ObterUsuarioLogado()
        {
            if (File.Exists(CaminhoUsuarioLogado))
            {
                return File.ReadAllText(CaminhoUsuarioLogado).Trim();
            }
            return "";
        }

        public static void Logout()
        {
            if (File.Exists(CaminhoUsuarioLogado))
            {
                File.Delete(CaminhoUsuarioLogado);
            }
        }

        public static decimal ObterSaldoUsuario(string nomeUsuario)
        {
            if (!File.Exists(CaminhoFluxoFaciluser)) return 0;

            var linhas = File.ReadAllLines(CaminhoFluxoFaciluser);

            foreach (var linha in linhas.Skip(1)) // Pula o cabeçalho
            {
                var partes = linha.Split(',');
                if (partes.Length >= 3 && partes[0].Trim().Equals(nomeUsuario.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    if (decimal.TryParse(partes[2], System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture, out decimal saldo))
                    {
                        return saldo;
                    }
                }
            }
            return 0;
        }

        // ========== GERENCIAMENTO DE TRANSAÇÕES ==========

        public static void AdicionarConta(string nome, string categoria, string tipo, string data, string valor, string usuario)
        {
            CriarArquivosSeNaoExistir();

            using (StreamWriter sw = new StreamWriter(CaminhoFluxoFacilDatabase, true))
            {
                sw.WriteLine($"{nome},{categoria},{tipo},{data},{valor},{usuario}");
            }

            // Atualiza automaticamente o saldo do usuário
            if (decimal.TryParse(valor.Replace("R$", "").Replace(",", "."),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out decimal valorDecimal))
            {
                bool isReceita = tipo.Trim().ToLower() == "receita";
                AtualizarSaldoUsuario(usuario, valorDecimal, isReceita);
            }
        }

        public static DataTable LerDatabase()
        {
            DataTable dt = new DataTable();

            if (!File.Exists(CaminhoFluxoFacilDatabase)) return dt;

            using (StreamReader sr = new StreamReader(CaminhoFluxoFacilDatabase))
            {
                string linha;
                bool primeiraLinha = true;

                while ((linha = sr.ReadLine()) != null)
                {
                    string[] campos = linha.Split(',');

                    if (primeiraLinha)
                    {
                        foreach (string col in campos)
                            dt.Columns.Add(col);
                        primeiraLinha = false;
                    }
                    else
                    {
                        dt.Rows.Add(campos);
                    }
                }
            }

            return dt;
        }

        public static DataTable LerDatabasePorUsuario(string usuario)
        {
            DataTable dtCompleta = LerDatabase();
            DataTable dtFiltrada = dtCompleta.Clone(); // Cria estrutura igual

            foreach (DataRow row in dtCompleta.Rows)
            {
                // Verifica se a linha tem a coluna de usuário e se é do usuário correto
                if (dtCompleta.Columns.Count > 5 &&
                    row[5].ToString().Trim().Equals(usuario.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    dtFiltrada.ImportRow(row);
                }
            }

            return dtFiltrada;
        }

        // ========== CÁLCULO DE SALDOS ==========

        public static void AtualizarSaldoUsuario(string nomeUsuario, decimal valor, bool isReceita)
        {
            if (!File.Exists(CaminhoFluxoFaciluser)) return;

            var linhas = File.ReadAllLines(CaminhoFluxoFaciluser).ToList();

            for (int i = 1; i < linhas.Count; i++) // Começa no 1 para pular cabeçalho
            {
                string[] campos = linhas[i].Split(',');
                if (campos.Length < 3) continue;

                if (campos[0].Trim().Equals(nomeUsuario.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    if (!decimal.TryParse(campos[2], System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture, out decimal valorAtual))
                        valorAtual = 0;

                    decimal novoValor = isReceita ? valorAtual + valor : valorAtual - valor;
                    campos[2] = novoValor.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);

                    linhas[i] = string.Join(",", campos);
                    break;
                }
            }

            File.WriteAllLines(CaminhoFluxoFaciluser, linhas);
        }

        public static decimal CalcularSaldoTotalUsuario(string usuario)
        {
            decimal saldoTotal = 0;
            DataTable dt = LerDatabasePorUsuario(usuario);

            foreach (DataRow row in dt.Rows)
            {
                string tipo = row["Tipo"].ToString().Trim().ToLower();
                string valorStr = row["valor"].ToString().Trim().Replace("R$", "").Replace(",", ".");

                if (decimal.TryParse(valorStr, System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out decimal valor))
                {
                    if (tipo == "receita")
                        saldoTotal += valor;
                    else if (tipo == "despesa")
                        saldoTotal -= valor;
                }
            }

            return saldoTotal;
        }

        public static void RecalcularSaldoUsuario(string usuario)
        {
            decimal saldoCalculado = CalcularSaldoTotalUsuario(usuario);

            if (!File.Exists(CaminhoFluxoFaciluser)) return;

            var linhas = File.ReadAllLines(CaminhoFluxoFaciluser).ToList();

            for (int i = 1; i < linhas.Count; i++) // Começa no 1 para pular cabeçalho
            {
                string[] campos = linhas[i].Split(',');
                if (campos.Length < 3) continue;

                if (campos[0].Trim().Equals(usuario.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    campos[2] = saldoCalculado.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
                    linhas[i] = string.Join(",", campos);
                    break;
                }
            }

            File.WriteAllLines(CaminhoFluxoFaciluser, linhas);
        }

        // ========== UTILITÁRIOS ==========

        public static void CriarArquivosSeNaoExistir()
        {
            string pastaDestino = @"C:\Users\Public\Documents";

            if (!Directory.Exists(pastaDestino))
            {
                Directory.CreateDirectory(pastaDestino);
            }

            // Cria arquivo de usuários se não existir
            if (!File.Exists(CaminhoFluxoFaciluser))
            {
                using (StreamWriter sw = new StreamWriter(CaminhoFluxoFaciluser))
                {
                    sw.WriteLine("Nome,Senha,Saldo");
                }
            }

            // Cria arquivo de database se não existir
            if (!File.Exists(CaminhoFluxoFacilDatabase))
            {
                using (StreamWriter sw = new StreamWriter(CaminhoFluxoFacilDatabase))
                {
                    sw.WriteLine("Nome,Categoria,Tipo,data,valor,Usuario");
                }
            }
        }

        // Método para adicionar saldo diretamente (como depósito)
        public static void AdicionarSaldo(string nomeUsuario, decimal valorAdicionar)
        {
            AtualizarSaldoUsuario(nomeUsuario, valorAdicionar, true);
            MessageBox.Show($"Saldo de R$ {valorAdicionar:F2} adicionado com sucesso!");
        }

        public static void RemoverTransacao(string nome, string categoria, string tipo, string data, string valor, string usuario)
        {
            string tempPath = CaminhoFluxoFacilDatabase + ".tmp";
            using (StreamReader sr = new StreamReader(CaminhoFluxoFacilDatabase))
            using (StreamWriter sw = new StreamWriter(tempPath))
            {
                string linha;
                bool cabecalho = true;

                while ((linha = sr.ReadLine()) != null)
                {
                    if (cabecalho)
                    {
                        sw.WriteLine(linha);
                        cabecalho = false;
                        continue;
                    }

                    string[] partes = linha.Split(',');
                    if (partes.Length >= 6 &&
                        partes[0] == nome &&
                        partes[1] == categoria &&
                        partes[2] == tipo &&
                        partes[3] == data &&
                        partes[4] == valor &&
                        partes[5] == usuario)
                    {
                        // Ignora essa linha (remoção)
                        continue;
                    }

                    sw.WriteLine(linha);
                }
            }

            File.Delete(CaminhoFluxoFacilDatabase);
            File.Move(tempPath, CaminhoFluxoFacilDatabase);
        }

        public static void AtualizarTransacao(
        string nomeAntigo, string categoriaAntiga, string tipoAntigo, string dataAntiga, string valorAntigo,
        string nomeNovo, string categoriaNova, string tipoNova, string dataNova, string valorNova,
        string usuario)
            {
                // Remove a transação original
                RemoverTransacao(nomeAntigo, categoriaAntiga, tipoAntigo, dataAntiga, valorAntigo, usuario);

                // Adiciona a nova transação
                AdicionarConta(nomeNovo, categoriaNova, tipoNova, dataNova, valorNova, usuario);

                // Recalcula o saldo
                RecalcularSaldoUsuario(usuario);
            }


    }
}