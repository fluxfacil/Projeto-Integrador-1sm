
namespace App___PI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            comboBox_Filtro = new ComboBox();
            dataGridView1 = new DataGridView();
            btn_adicionarConta = new Button();
            lbl_saldo = new Label();
            lbl_user = new Label();
            pictureBox1 = new PictureBox();
            lbl_saldoTotalConta = new Label();
            btn_excluirConta = new Button();
            label2 = new Label();
            comboBoxTipo = new ComboBox();
            btn_editarConta = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 139);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 22;
            label1.Text = "Filtrar Categoria";
            // 
            // comboBox_Filtro
            // 
            comboBox_Filtro.FormattingEnabled = true;
            comboBox_Filtro.Location = new Point(39, 156);
            comboBox_Filtro.Margin = new Padding(3, 2, 3, 2);
            comboBox_Filtro.Name = "comboBox_Filtro";
            comboBox_Filtro.Size = new Size(133, 23);
            comboBox_Filtro.TabIndex = 21;
            comboBox_Filtro.SelectedIndexChanged += comboBox_Filtro_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 182);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(783, 227);
            dataGridView1.TabIndex = 20;
            // 
            // btn_adicionarConta
            // 
            btn_adicionarConta.BackColor = Color.LimeGreen;
            btn_adicionarConta.ImageAlign = ContentAlignment.BottomCenter;
            btn_adicionarConta.Location = new Point(39, 105);
            btn_adicionarConta.Margin = new Padding(3, 2, 3, 2);
            btn_adicionarConta.Name = "btn_adicionarConta";
            btn_adicionarConta.Size = new Size(164, 31);
            btn_adicionarConta.TabIndex = 19;
            btn_adicionarConta.Text = "Adicionar Conta";
            btn_adicionarConta.UseVisualStyleBackColor = false;
            btn_adicionarConta.Click += btn_adicionarConta_Click;
            // 
            // lbl_saldo
            // 
            lbl_saldo.AutoSize = true;
            lbl_saldo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_saldo.Location = new Point(599, 30);
            lbl_saldo.Name = "lbl_saldo";
            lbl_saldo.Size = new Size(80, 32);
            lbl_saldo.TabIndex = 18;
            lbl_saldo.Text = "Saldo:";
            // 
            // lbl_user
            // 
            lbl_user.AutoSize = true;
            lbl_user.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_user.Location = new Point(150, 28);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new Size(57, 32);
            lbl_user.TabIndex = 16;
            lbl_user.Text = "Olá:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(39, 28);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // lbl_saldoTotalConta
            // 
            lbl_saldoTotalConta.AutoSize = true;
            lbl_saldoTotalConta.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_saldoTotalConta.Location = new Point(693, 30);
            lbl_saldoTotalConta.Name = "lbl_saldoTotalConta";
            lbl_saldoTotalConta.Size = new Size(27, 32);
            lbl_saldoTotalConta.TabIndex = 23;
            lbl_saldoTotalConta.Text = "0";
            // 
            // btn_excluirConta
            // 
            btn_excluirConta.BackColor = Color.Red;
            btn_excluirConta.ImageAlign = ContentAlignment.BottomCenter;
            btn_excluirConta.Location = new Point(719, 139);
            btn_excluirConta.Margin = new Padding(3, 2, 3, 2);
            btn_excluirConta.Name = "btn_excluirConta";
            btn_excluirConta.Size = new Size(103, 31);
            btn_excluirConta.TabIndex = 24;
            btn_excluirConta.Text = "Excluir conta";
            btn_excluirConta.UseVisualStyleBackColor = false;
            btn_excluirConta.Click += btn_excluirConta_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 138);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 26;
            label2.Text = "Filtrar Tipo";
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Todos", "Receita", "Despesa" });
            comboBoxTipo.Location = new Point(182, 155);
            comboBoxTipo.Margin = new Padding(3, 2, 3, 2);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(133, 23);
            comboBoxTipo.TabIndex = 25;
            comboBoxTipo.SelectedIndexChanged += comboBoxTipo_SelectedIndexChanged_1;
            // 
            // btn_editarConta
            // 
            btn_editarConta.BackColor = Color.Yellow;
            btn_editarConta.ImageAlign = ContentAlignment.BottomCenter;
            btn_editarConta.Location = new Point(610, 138);
            btn_editarConta.Margin = new Padding(3, 2, 3, 2);
            btn_editarConta.Name = "btn_editarConta";
            btn_editarConta.Size = new Size(103, 31);
            btn_editarConta.TabIndex = 27;
            btn_editarConta.Text = "Editar conta";
            btn_editarConta.UseVisualStyleBackColor = false;
            btn_editarConta.Click += btn_editarConta_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 443);
            Controls.Add(btn_editarConta);
            Controls.Add(label2);
            Controls.Add(comboBoxTipo);
            Controls.Add(btn_excluirConta);
            Controls.Add(lbl_saldoTotalConta);
            Controls.Add(label1);
            Controls.Add(comboBox_Filtro);
            Controls.Add(dataGridView1);
            Controls.Add(btn_adicionarConta);
            Controls.Add(lbl_saldo);
            Controls.Add(lbl_user);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Form2";
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox_Filtro;
        private DataGridView dataGridView1;
        private Button btn_adicionarConta;
        private Label lbl_saldo;
        private Label lbl_user;
        private PictureBox pictureBox1;
        private Label lbl_saldoTotalConta;
        private Button btn_excluirConta;
        private Label label2;
        private ComboBox comboBoxTipo;
        private Button btn_editarConta;
    }
}