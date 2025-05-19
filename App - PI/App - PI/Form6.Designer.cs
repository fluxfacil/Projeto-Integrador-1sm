namespace App___PI
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            btn_atualizar_Conta = new Button();
            dateTime_Data_atualizar = new DateTimePicker();
            txt_valor_atualizar = new TextBox();
            txt_nome_atualizar = new TextBox();
            txt_categoria_atualizar = new TextBox();
            lbl_nomeConta = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox_DR_atualizar = new ComboBox();
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
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 291);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 38;
            label5.Text = "Valor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 246);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 37;
            label4.Text = "Data";
            // 
            // btn_atualizar_Conta
            // 
            btn_atualizar_Conta.BackColor = Color.LimeGreen;
            btn_atualizar_Conta.ImageAlign = ContentAlignment.BottomCenter;
            btn_atualizar_Conta.Location = new Point(308, 288);
            btn_atualizar_Conta.Margin = new Padding(3, 2, 3, 2);
            btn_atualizar_Conta.Name = "btn_atualizar_Conta";
            btn_atualizar_Conta.Size = new Size(122, 31);
            btn_atualizar_Conta.TabIndex = 33;
            btn_atualizar_Conta.Text = "Salvar ";
            btn_atualizar_Conta.UseVisualStyleBackColor = false;
            btn_atualizar_Conta.Click += btn_atualizar_Conta_Click;
            // 
            // dateTime_Data_atualizar
            // 
            dateTime_Data_atualizar.Location = new Point(18, 263);
            dateTime_Data_atualizar.Margin = new Padding(3, 2, 3, 2);
            dateTime_Data_atualizar.Name = "dateTime_Data_atualizar";
            dateTime_Data_atualizar.Size = new Size(178, 23);
            dateTime_Data_atualizar.TabIndex = 32;
            dateTime_Data_atualizar.ValueChanged += dateTime_Data_atualizar_ValueChanged;
            // 
            // txt_valor_atualizar
            // 
            txt_valor_atualizar.Location = new Point(18, 308);
            txt_valor_atualizar.Margin = new Padding(3, 2, 3, 2);
            txt_valor_atualizar.Name = "txt_valor_atualizar";
            txt_valor_atualizar.Size = new Size(110, 23);
            txt_valor_atualizar.TabIndex = 31;
            txt_valor_atualizar.TextChanged += txt_valor_atualizar_TextChanged;
            // 
            // txt_nome_atualizar
            // 
            txt_nome_atualizar.Location = new Point(18, 118);
            txt_nome_atualizar.Margin = new Padding(3, 2, 3, 2);
            txt_nome_atualizar.Name = "txt_nome_atualizar";
            txt_nome_atualizar.Size = new Size(110, 23);
            txt_nome_atualizar.TabIndex = 29;
            txt_nome_atualizar.TextChanged += txt_nome_atualizar_TextChanged;
            // 
            // txt_categoria_atualizar
            // 
            txt_categoria_atualizar.Location = new Point(18, 167);
            txt_categoria_atualizar.Margin = new Padding(3, 2, 3, 2);
            txt_categoria_atualizar.Name = "txt_categoria_atualizar";
            txt_categoria_atualizar.Size = new Size(110, 23);
            txt_categoria_atualizar.TabIndex = 30;
            txt_categoria_atualizar.TextChanged += txt_categoria_atualizar_TextChanged;
            // 
            // lbl_nomeConta
            // 
            lbl_nomeConta.AutoSize = true;
            lbl_nomeConta.Location = new Point(18, 100);
            lbl_nomeConta.Name = "lbl_nomeConta";
            lbl_nomeConta.Size = new Size(40, 15);
            lbl_nomeConta.TabIndex = 34;
            lbl_nomeConta.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 150);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 35;
            label2.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 198);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 36;
            label3.Text = "Despesa / Receita";
            // 
            // comboBox_DR_atualizar
            // 
            comboBox_DR_atualizar.FormattingEnabled = true;
            comboBox_DR_atualizar.Items.AddRange(new object[] { "Despesa", "Receita" });
            comboBox_DR_atualizar.Location = new Point(18, 214);
            comboBox_DR_atualizar.Margin = new Padding(3, 2, 3, 2);
            comboBox_DR_atualizar.Name = "comboBox_DR_atualizar";
            comboBox_DR_atualizar.Size = new Size(112, 23);
            comboBox_DR_atualizar.TabIndex = 39;
            comboBox_DR_atualizar.SelectedIndexChanged += comboBox_DR_atualizar_SelectedIndexChanged;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 338);
            Controls.Add(comboBox_DR_atualizar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbl_nomeConta);
            Controls.Add(btn_atualizar_Conta);
            Controls.Add(dateTime_Data_atualizar);
            Controls.Add(txt_valor_atualizar);
            Controls.Add(txt_categoria_atualizar);
            Controls.Add(txt_nome_atualizar);
            Controls.Add(pictureBox1);
            Name = "Form6";
            Text = "Atualizar Conta";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Button btn_atualizar_Conta;
        private DateTimePicker dateTime_Data_atualizar;
        private TextBox txt_valor_atualizar;
        private TextBox txt_nome_atualizar;
        private TextBox txt_categoria_atualizar;
        private Label lbl_nomeConta;
        private Label label2;
        private Label label3;
        private ComboBox comboBox_DR_atualizar;
    }
}