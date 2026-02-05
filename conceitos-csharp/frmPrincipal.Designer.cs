namespace conceitos_csharp
{
    partial class frmPrincipal
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
            groupBox1 = new GroupBox();
            btnCadastrar = new Button();
            dtpNasc = new DateTimePicker();
            txtTelefone = new TextBox();
            txtCPF = new TextBox();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnCalcular = new Button();
            txtVR = new TextBox();
            txtVT = new TextBox();
            txtIRRF = new TextBox();
            txtINSS = new TextBox();
            txtSalarioBruto = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCadastrar);
            groupBox1.Controls.Add(dtpNasc);
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(txtCPF);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Century Gothic", 9F);
            groupBox1.Location = new Point(12, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(207, 313);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.DarkGreen;
            btnCadastrar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(31, 258);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(136, 42);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // dtpNasc
            // 
            dtpNasc.Location = new Point(31, 191);
            dtpNasc.Name = "dtpNasc";
            dtpNasc.Size = new Size(136, 22);
            dtpNasc.TabIndex = 10;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(31, 220);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "Telefone";
            txtTelefone.Size = new Size(136, 22);
            txtTelefone.TabIndex = 5;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(31, 162);
            txtCPF.Name = "txtCPF";
            txtCPF.PlaceholderText = "CPF";
            txtCPF.Size = new Size(136, 22);
            txtCPF.TabIndex = 6;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(31, 133);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(136, 22);
            txtSenha.TabIndex = 7;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(31, 104);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(136, 22);
            txtEmail.TabIndex = 8;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(31, 75);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(136, 22);
            txtNome.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1, 31);
            label1.Name = "label1";
            label1.Size = new Size(199, 23);
            label1.TabIndex = 4;
            label1.Text = "Cadastro de Usuário";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCalcular);
            groupBox2.Controls.Add(txtVR);
            groupBox2.Controls.Add(txtVT);
            groupBox2.Controls.Add(txtIRRF);
            groupBox2.Controls.Add(txtINSS);
            groupBox2.Controls.Add(txtSalarioBruto);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Century Gothic", 9F);
            groupBox2.Location = new Point(225, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(207, 313);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Salário";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.DarkGreen;
            btnCalcular.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(31, 258);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(136, 42);
            btnCalcular.TabIndex = 11;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            // 
            // txtVR
            // 
            txtVR.Location = new Point(31, 177);
            txtVR.Name = "txtVR";
            txtVR.PlaceholderText = "VR";
            txtVR.Size = new Size(136, 22);
            txtVR.TabIndex = 5;
            // 
            // txtVT
            // 
            txtVT.Location = new Point(31, 148);
            txtVT.Name = "txtVT";
            txtVT.PlaceholderText = "VT";
            txtVT.Size = new Size(136, 22);
            txtVT.TabIndex = 6;
            // 
            // txtIRRF
            // 
            txtIRRF.Location = new Point(31, 119);
            txtIRRF.Name = "txtIRRF";
            txtIRRF.PlaceholderText = "IRRF";
            txtIRRF.Size = new Size(136, 22);
            txtIRRF.TabIndex = 7;
            // 
            // txtINSS
            // 
            txtINSS.Location = new Point(31, 90);
            txtINSS.Name = "txtINSS";
            txtINSS.PlaceholderText = "INSS";
            txtINSS.Size = new Size(136, 22);
            txtINSS.TabIndex = 8;
            // 
            // txtSalarioBruto
            // 
            txtSalarioBruto.Location = new Point(31, 61);
            txtSalarioBruto.Name = "txtSalarioBruto";
            txtSalarioBruto.PlaceholderText = "Salário Bruto";
            txtSalarioBruto.Size = new Size(136, 22);
            txtSalarioBruto.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 216);
            label3.Name = "label3";
            label3.Size = new Size(32, 23);
            label3.TabIndex = 4;
            label3.Text = "R$";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 31);
            label2.Name = "label2";
            label2.Size = new Size(182, 23);
            label2.TabIndex = 4;
            label2.Text = "Cálculo de Salário";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCadastrar;
        private DateTimePicker dtpNasc;
        private TextBox txtTelefone;
        private TextBox txtCPF;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private TextBox txtNome;
        private Label label1;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePicker1;
        private TextBox txtVR;
        private TextBox txtVT;
        private TextBox txtIRRF;
        private TextBox txtINSS;
        private TextBox txtSalarioBruto;
        private Label label2;
        private Label label3;
        private Button btnCalcular;
    }
}