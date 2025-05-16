namespace App___PI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbl_usuario = new Label();
            label2 = new Label();
            txt_usuario = new TextBox();
            txt_senha = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Location = new Point(357, 124);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(59, 20);
            lbl_usuario.TabIndex = 0;
            lbl_usuario.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(366, 238);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // txt_usuario
            // 
            txt_usuario.BackColor = Color.Honeydew;
            txt_usuario.ForeColor = SystemColors.WindowText;
            txt_usuario.Location = new Point(260, 158);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(256, 27);
            txt_usuario.TabIndex = 2;
            // 
            // txt_senha
            // 
            txt_senha.BackColor = Color.Honeydew;
            txt_senha.BorderStyle = BorderStyle.FixedSingle;
            txt_senha.ForeColor = SystemColors.WindowText;
            txt_senha.Location = new Point(260, 283);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(256, 27);
            txt_senha.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.ImageAlign = ContentAlignment.BottomCenter;
            button1.Location = new Point(317, 344);
            button1.Name = "button1";
            button1.Size = new Size(139, 48);
            button1.TabIndex = 4;
            button1.Text = "Logar";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(341, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(txt_senha);
            Controls.Add(txt_usuario);
            Controls.Add(label2);
            Controls.Add(lbl_usuario);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_usuario;
        private Label label2;
        private TextBox txt_usuario;
        private TextBox txt_senha;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
