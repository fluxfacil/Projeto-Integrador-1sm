namespace App___PI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            btn_logar = new Button();
            label1 = new Label();
            label2 = new Label();
            txt_usuario = new TextBox();
            txt_senha = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(336, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btn_logar
            // 
            btn_logar.BackColor = Color.LimeGreen;
            btn_logar.ImageAlign = ContentAlignment.BottomCenter;
            btn_logar.Location = new Point(320, 360);
            btn_logar.Name = "btn_logar";
            btn_logar.Size = new Size(139, 41);
            btn_logar.TabIndex = 10;
            btn_logar.Text = "Logar";
            btn_logar.UseVisualStyleBackColor = false;
            btn_logar.Click += btn_logar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(354, 163);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 11;
            label1.Text = "USUÁRIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(354, 278);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 12;
            label2.Text = "SENHA";
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(233, 197);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(319, 27);
            txt_usuario.TabIndex = 13;
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(233, 312);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(319, 27);
            txt_senha.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_senha);
            Controls.Add(txt_usuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_logar);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_logar;
        private Label label1;
        private Label label2;
        private TextBox txt_usuario;
        private TextBox txt_senha;
    }
}