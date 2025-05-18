
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
            btn_atualizarConta = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 185);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 22;
            label1.Text = "Filtrar Por:";
            // 
            // comboBox_Filtro
            // 
            comboBox_Filtro.FormattingEnabled = true;
            comboBox_Filtro.Location = new Point(45, 208);
            comboBox_Filtro.Name = "comboBox_Filtro";
            comboBox_Filtro.Size = new Size(151, 28);
            comboBox_Filtro.TabIndex = 21;
            comboBox_Filtro.SelectedIndexChanged += comboBox_Filtro_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(45, 242);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(895, 303);
            dataGridView1.TabIndex = 20;
            // 
            // btn_adicionarConta
            // 
            btn_adicionarConta.BackColor = Color.LimeGreen;
            btn_adicionarConta.ImageAlign = ContentAlignment.BottomCenter;
            btn_adicionarConta.Location = new Point(45, 140);
            btn_adicionarConta.Name = "btn_adicionarConta";
            btn_adicionarConta.Size = new Size(188, 41);
            btn_adicionarConta.TabIndex = 19;
            btn_adicionarConta.Text = "Adicionar Conta";
            btn_adicionarConta.UseVisualStyleBackColor = false;
            btn_adicionarConta.Click += btn_adicionarConta_Click;
            // 
            // lbl_saldo
            // 
            lbl_saldo.AutoSize = true;
            lbl_saldo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_saldo.Location = new Point(685, 40);
            lbl_saldo.Name = "lbl_saldo";
            lbl_saldo.Size = new Size(101, 41);
            lbl_saldo.TabIndex = 18;
            lbl_saldo.Text = "Saldo:";
            // 
            // lbl_user
            // 
            lbl_user.AutoSize = true;
            lbl_user.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_user.Location = new Point(172, 37);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new Size(72, 41);
            lbl_user.TabIndex = 16;
            lbl_user.Text = "Olá:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(45, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // lbl_saldoTotalConta
            // 
            lbl_saldoTotalConta.AutoSize = true;
            lbl_saldoTotalConta.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_saldoTotalConta.Location = new Point(792, 40);
            lbl_saldoTotalConta.Name = "lbl_saldoTotalConta";
            lbl_saldoTotalConta.Size = new Size(35, 41);
            lbl_saldoTotalConta.TabIndex = 23;
            lbl_saldoTotalConta.Text = "0";
            // 
            // btn_excluirConta
            // 
            btn_excluirConta.BackColor = Color.Red;
            btn_excluirConta.ImageAlign = ContentAlignment.BottomCenter;
            btn_excluirConta.Location = new Point(822, 185);
            btn_excluirConta.Name = "btn_excluirConta";
            btn_excluirConta.Size = new Size(118, 41);
            btn_excluirConta.TabIndex = 24;
            btn_excluirConta.Text = "Excluir conta";
            btn_excluirConta.UseVisualStyleBackColor = false;
            btn_excluirConta.Click += btn_excluirConta_Click;
            // 
            // btn_atualizarConta
            // 
            btn_atualizarConta.BackColor = Color.Yellow;
            btn_atualizarConta.ImageAlign = ContentAlignment.BottomCenter;
            btn_atualizarConta.Location = new Point(685, 185);
            btn_atualizarConta.Name = "btn_atualizarConta";
            btn_atualizarConta.Size = new Size(131, 41);
            btn_atualizarConta.TabIndex = 25;
            btn_atualizarConta.Text = "Atualizar Conta";
            btn_atualizarConta.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 591);
            Controls.Add(btn_atualizarConta);
            Controls.Add(btn_excluirConta);
            Controls.Add(lbl_saldoTotalConta);
            Controls.Add(label1);
            Controls.Add(comboBox_Filtro);
            Controls.Add(dataGridView1);
            Controls.Add(btn_adicionarConta);
            Controls.Add(lbl_saldo);
            Controls.Add(lbl_user);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Form2";
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
        private Button btn_atualizarConta;
    }
}