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
