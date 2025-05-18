namespace App___PI
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            txt_senhaCadastrar = new TextBox();
            txt_usuarioCadastrar = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btn_Cadastrar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_senhaCadastrar
            // 
            txt_senhaCadastrar.Location = new Point(25, 227);
            txt_senhaCadastrar.Name = "txt_senhaCadastrar";
            txt_senhaCadastrar.Size = new Size(319, 27);
            txt_senhaCadastrar.TabIndex = 20;
            txt_senhaCadastrar.TextChanged += txt_senhaCadastrar_TextChanged;
            // 
            // txt_usuarioCadastrar
            // 
            txt_usuarioCadastrar.Location = new Point(25, 149);
            txt_usuarioCadastrar.Name = "txt_usuarioCadastrar";
            txt_usuarioCadastrar.Size = new Size(319, 27);
            txt_usuarioCadastrar.TabIndex = 19;
            txt_usuarioCadastrar.TextChanged += txt_usuarioCadastrar_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 193);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 18;
            label2.Text = "SENHA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 126);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 17;
            label1.Text = "USUÁRIO";
            // 
            // btn_Cadastrar
            // 
            btn_Cadastrar.BackColor = Color.LimeGreen;
            btn_Cadastrar.ImageAlign = ContentAlignment.BottomCenter;
            btn_Cadastrar.Location = new Point(105, 269);
            btn_Cadastrar.Name = "btn_Cadastrar";
            btn_Cadastrar.Size = new Size(139, 41);
            btn_Cadastrar.TabIndex = 16;
            btn_Cadastrar.Text = "Cadastrar";
            btn_Cadastrar.UseVisualStyleBackColor = false;
            btn_Cadastrar.Click += btn_Cadastrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(128, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 321);
            Controls.Add(txt_senhaCadastrar);
            Controls.Add(txt_usuarioCadastrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Cadastrar);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form5";
            Text = "Cadastro";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_senhaCadastrar;
        private TextBox txt_usuarioCadastrar;
        private Label label2;
        private Label label1;
        private Button btn_Cadastrar;
        private PictureBox pictureBox1;
    }
}