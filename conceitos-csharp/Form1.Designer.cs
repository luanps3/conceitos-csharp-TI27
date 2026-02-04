namespace conceitos_csharp
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
            txtNumericos = new TextBox();
            txtTextuais = new TextBox();
            txtInferencia = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnExibeMensagem = new Button();
            SuspendLayout();
            // 
            // txtNumericos
            // 
            txtNumericos.Location = new Point(12, 62);
            txtNumericos.Name = "txtNumericos";
            txtNumericos.Size = new Size(100, 23);
            txtNumericos.TabIndex = 0;
            // 
            // txtTextuais
            // 
            txtTextuais.Location = new Point(174, 62);
            txtTextuais.Name = "txtTextuais";
            txtTextuais.Size = new Size(100, 23);
            txtTextuais.TabIndex = 1;
            // 
            // txtInferencia
            // 
            txtInferencia.Location = new Point(341, 62);
            txtInferencia.Name = "txtInferencia";
            txtInferencia.Size = new Size(100, 23);
            txtInferencia.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 28);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 2;
            label1.Text = "Númericos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 28);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 2;
            label2.Text = "Textuais";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(369, 28);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "Inferência";
            // 
            // btnExibeMensagem
            // 
            btnExibeMensagem.Location = new Point(143, 116);
            btnExibeMensagem.Name = "btnExibeMensagem";
            btnExibeMensagem.Size = new Size(162, 46);
            btnExibeMensagem.TabIndex = 3;
            btnExibeMensagem.Text = "Exibir Mensgaem";
            btnExibeMensagem.UseVisualStyleBackColor = true;
            btnExibeMensagem.Click += btnExibeMensagem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 200);
            Controls.Add(btnExibeMensagem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtInferencia);
            Controls.Add(txtTextuais);
            Controls.Add(txtNumericos);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumericos;
        private TextBox txtTextuais;
        private TextBox txtInferencia;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnExibeMensagem;
    }
}
