namespace App___PI
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            pictureBox1 = new PictureBox();
            txt_nomeConta = new TextBox();
            txt_categoriaConta = new TextBox();
            txt_valor = new TextBox();
            dateTime_DataConta = new DateTimePicker();
            btn_salvarConta = new Button();
            lbl_nomeConta = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox_DespesaReceita = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(18, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 74);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // txt_nomeConta
            // 
            txt_nomeConta.Location = new Point(18, 118);
            txt_nomeConta.Margin = new Padding(3, 2, 3, 2);
            txt_nomeConta.Name = "txt_nomeConta";
            txt_nomeConta.Size = new Size(110, 23);
            txt_nomeConta.TabIndex = 17;
            // 
            // txt_categoriaConta
            // 
            txt_categoriaConta.Location = new Point(18, 171);
            txt_categoriaConta.Margin = new Padding(3, 2, 3, 2);
            txt_categoriaConta.Name = "txt_categoriaConta";
            txt_categoriaConta.Size = new Size(110, 23);
            txt_categoriaConta.TabIndex = 18;
            // 
            // txt_valor
            // 
            txt_valor.Location = new Point(18, 308);
            txt_valor.Margin = new Padding(3, 2, 3, 2);
            txt_valor.Name = "txt_valor";
            txt_valor.Size = new Size(110, 23);
            txt_valor.TabIndex = 19;
            // 
            // dateTime_DataConta
            // 
            dateTime_DataConta.Location = new Point(18, 265);
            dateTime_DataConta.Margin = new Padding(3, 2, 3, 2);
            dateTime_DataConta.Name = "dateTime_DataConta";
            dateTime_DataConta.Size = new Size(178, 23);
            dateTime_DataConta.TabIndex = 21;
            // 
            // btn_salvarConta
            // 
            btn_salvarConta.BackColor = Color.LimeGreen;
            btn_salvarConta.ImageAlign = ContentAlignment.BottomCenter;
            btn_salvarConta.Location = new Point(308, 288);
            btn_salvarConta.Margin = new Padding(3, 2, 3, 2);
            btn_salvarConta.Name = "btn_salvarConta";
            btn_salvarConta.Size = new Size(122, 31);
            btn_salvarConta.TabIndex = 22;
            btn_salvarConta.Text = "Salvar ";
            btn_salvarConta.UseVisualStyleBackColor = false;
            btn_salvarConta.Click += btn_salvarConta_Click;
            // 
            // lbl_nomeConta
            // 
            lbl_nomeConta.AutoSize = true;
            lbl_nomeConta.Location = new Point(18, 100);
            lbl_nomeConta.Name = "lbl_nomeConta";
            lbl_nomeConta.Size = new Size(40, 15);
            lbl_nomeConta.TabIndex = 23;
            lbl_nomeConta.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 154);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 24;
            label2.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 201);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 25;
            label3.Text = "Despesa / Receita";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 248);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 26;
            label4.Text = "data:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 291);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 27;
            label5.Text = "valor:";
            // 
            // comboBox_DespesaReceita
            // 
            comboBox_DespesaReceita.FormattingEnabled = true;
            comboBox_DespesaReceita.Items.AddRange(new object[] { "Despesa", "Receita" });
            comboBox_DespesaReceita.Location = new Point(18, 224);
            comboBox_DespesaReceita.Margin = new Padding(3, 2, 3, 2);
            comboBox_DespesaReceita.Name = "comboBox_DespesaReceita";
            comboBox_DespesaReceita.Size = new Size(112, 23);
            comboBox_DespesaReceita.TabIndex = 28;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 338);
            Controls.Add(comboBox_DespesaReceita);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbl_nomeConta);
            Controls.Add(btn_salvarConta);
            Controls.Add(dateTime_DataConta);
            Controls.Add(txt_valor);
            Controls.Add(txt_categoriaConta);
            Controls.Add(txt_nomeConta);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form3";
            Text = "Adicionar Conta";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txt_nomeConta;
        private TextBox txt_categoriaConta;
        private TextBox txt_valor;
        private DateTimePicker dateTime_DataConta;
        private Button btn_salvarConta;
        private Label lbl_nomeConta;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox_DespesaReceita;
    }
}