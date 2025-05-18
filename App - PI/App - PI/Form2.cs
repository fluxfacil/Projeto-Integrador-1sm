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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //criação de arquvios csv na pasta do usuário publica
            string pastaDestino = @"C:\Users\Public\Documents";
            string caminhoFluxoFacilDatabase = Path.Combine(pastaDestino, "fluxofacildatabase.csv");
            // Cria a pasta se não existir
            if (!Directory.Exists(pastaDestino))
            {
                Directory.CreateDirectory(pastaDestino);
            }
            if (!File.Exists(caminhoFluxoFacilDatabase))
            {
                using (StreamWriter csvCalculadora = new StreamWriter(caminhoFluxoFacilDatabase))
                {
                    csvCalculadora.WriteLine("id,Nome,Categoria,Tipo,data,valor");
                }
            }
        }

        private void btn_adicionarConta_Click(object sender, EventArgs e)
        {
            Form3 addDespesa = new Form3();
            addDespesa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 AddSaldo = new Form4();
            AddSaldo.Show();
        }
    }
}
