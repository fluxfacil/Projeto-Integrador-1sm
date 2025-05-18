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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btn_salvarConta = new Button();
            lbl_nomeConta = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(21, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 157);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(21, 228);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(21, 411);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(21, 353);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(203, 27);
            dateTimePicker1.TabIndex = 21;
            // 
            // btn_salvarConta
            // 
            btn_salvarConta.BackColor = Color.LimeGreen;
            btn_salvarConta.ImageAlign = ContentAlignment.BottomCenter;
            btn_salvarConta.Location = new Point(352, 384);
            btn_salvarConta.Name = "btn_salvarConta";
            btn_salvarConta.Size = new Size(139, 41);
            btn_salvarConta.TabIndex = 22;
            btn_salvarConta.Text = "Salvar ";
            btn_salvarConta.UseVisualStyleBackColor = false;
            // 
            // lbl_nomeConta
            // 
            lbl_nomeConta.AutoSize = true;
            lbl_nomeConta.Location = new Point(21, 134);
            lbl_nomeConta.Name = "lbl_nomeConta";
            lbl_nomeConta.Size = new Size(50, 20);
            lbl_nomeConta.TabIndex = 23;
            lbl_nomeConta.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 205);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 24;
            label2.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 268);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 25;
            label3.Text = "Despesa / Receita";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 330);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 26;
            label4.Text = "data:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 388);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 27;
            label5.Text = "valor:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Despesa", "Receita" });
            comboBox2.Location = new Point(21, 299);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(128, 28);
            comboBox2.TabIndex = 28;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 450);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbl_nomeConta);
            Controls.Add(btn_salvarConta);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private Button btn_salvarConta;
        private Label lbl_nomeConta;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox2;
    }
}