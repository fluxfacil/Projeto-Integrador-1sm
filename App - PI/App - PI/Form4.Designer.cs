﻿namespace App___PI
{
    partial class Form4
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
            label1 = new Label();
            txt_adicionarSaldo = new TextBox();
            btn_salvarNovoSaldo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 28);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 0;
            label1.Text = "Adicionar Saldo:";
            // 
            // txt_adicionarSaldo
            // 
            txt_adicionarSaldo.Location = new Point(125, 70);
            txt_adicionarSaldo.Name = "txt_adicionarSaldo";
            txt_adicionarSaldo.Size = new Size(139, 27);
            txt_adicionarSaldo.TabIndex = 1;
            txt_adicionarSaldo.TextChanged += txt_adicionarSaldo_TextChanged;
            // 
            // btn_salvarNovoSaldo
            // 
            btn_salvarNovoSaldo.BackColor = Color.LimeGreen;
            btn_salvarNovoSaldo.ImageAlign = ContentAlignment.BottomCenter;
            btn_salvarNovoSaldo.Location = new Point(125, 132);
            btn_salvarNovoSaldo.Name = "btn_salvarNovoSaldo";
            btn_salvarNovoSaldo.Size = new Size(139, 41);
            btn_salvarNovoSaldo.TabIndex = 23;
            btn_salvarNovoSaldo.Text = "Salvar ";
            btn_salvarNovoSaldo.UseVisualStyleBackColor = false;
            btn_salvarNovoSaldo.Click += btn_salvarNovoSaldo_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 212);
            Controls.Add(btn_salvarNovoSaldo);
            Controls.Add(txt_adicionarSaldo);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_adicionarSaldo;
        private Button btn_salvarNovoSaldo;
    }
}