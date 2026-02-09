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
            lblSalarioLiquido = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            cboInsalubridade = new ComboBox();
            btnAdicionais = new Button();
            txtAddNoturno = new TextBox();
            txtPLR = new TextBox();
            txtPericulosidade = new TextBox();
            txtExtra = new TextBox();
            lblAdicionais = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
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
            groupBox1.Location = new Point(12, 12);
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
            groupBox2.Controls.Add(lblSalarioLiquido);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Century Gothic", 9F);
            groupBox2.Location = new Point(225, 12);
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
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtVR
            // 
            txtVR.Location = new Point(31, 177);
            txtVR.Name = "txtVR";
            txtVR.PlaceholderText = "VR";
            txtVR.ReadOnly = true;
            txtVR.Size = new Size(136, 22);
            txtVR.TabIndex = 5;
            // 
            // txtVT
            // 
            txtVT.Location = new Point(31, 148);
            txtVT.Name = "txtVT";
            txtVT.PlaceholderText = "VT";
            txtVT.ReadOnly = true;
            txtVT.Size = new Size(136, 22);
            txtVT.TabIndex = 6;
            // 
            // txtIRRF
            // 
            txtIRRF.Location = new Point(31, 119);
            txtIRRF.Name = "txtIRRF";
            txtIRRF.PlaceholderText = "IRRF";
            txtIRRF.ReadOnly = true;
            txtIRRF.Size = new Size(136, 22);
            txtIRRF.TabIndex = 7;
            // 
            // txtINSS
            // 
            txtINSS.Location = new Point(31, 90);
            txtINSS.Name = "txtINSS";
            txtINSS.PlaceholderText = "INSS";
            txtINSS.ReadOnly = true;
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
            txtSalarioBruto.TextChanged += txtSalarioBruto_TextChanged;
            // 
            // lblSalarioLiquido
            // 
            lblSalarioLiquido.AutoSize = true;
            lblSalarioLiquido.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalarioLiquido.Location = new Point(31, 216);
            lblSalarioLiquido.Name = "lblSalarioLiquido";
            lblSalarioLiquido.Size = new Size(32, 23);
            lblSalarioLiquido.TabIndex = 4;
            lblSalarioLiquido.Text = "R$";
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
            // groupBox3
            // 
            groupBox3.Controls.Add(cboInsalubridade);
            groupBox3.Controls.Add(btnAdicionais);
            groupBox3.Controls.Add(txtAddNoturno);
            groupBox3.Controls.Add(txtPLR);
            groupBox3.Controls.Add(txtPericulosidade);
            groupBox3.Controls.Add(txtExtra);
            groupBox3.Controls.Add(lblAdicionais);
            groupBox3.Controls.Add(label4);
            groupBox3.Font = new Font("Century Gothic", 9F);
            groupBox3.Location = new Point(438, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(207, 313);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Extra";
            // 
            // cboInsalubridade
            // 
            cboInsalubridade.FormattingEnabled = true;
            cboInsalubridade.Items.AddRange(new object[] { "Minimo", "Médio", "Máximo" });
            cboInsalubridade.Location = new Point(31, 90);
            cboInsalubridade.Name = "cboInsalubridade";
            cboInsalubridade.Size = new Size(136, 25);
            cboInsalubridade.TabIndex = 12;
            // 
            // btnAdicionais
            // 
            btnAdicionais.BackColor = Color.DarkGreen;
            btnAdicionais.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionais.ForeColor = Color.White;
            btnAdicionais.Location = new Point(31, 258);
            btnAdicionais.Name = "btnAdicionais";
            btnAdicionais.Size = new Size(136, 42);
            btnAdicionais.TabIndex = 11;
            btnAdicionais.Text = "Calcular";
            btnAdicionais.UseVisualStyleBackColor = false;
            btnAdicionais.Click += btnAdicionais_Click;
            // 
            // txtAddNoturno
            // 
            txtAddNoturno.Location = new Point(31, 177);
            txtAddNoturno.Name = "txtAddNoturno";
            txtAddNoturno.PlaceholderText = "Adicional Nortuno";
            txtAddNoturno.ReadOnly = true;
            txtAddNoturno.Size = new Size(136, 22);
            txtAddNoturno.TabIndex = 5;
            // 
            // txtPLR
            // 
            txtPLR.Location = new Point(31, 148);
            txtPLR.Name = "txtPLR";
            txtPLR.PlaceholderText = "PLR";
            txtPLR.ReadOnly = true;
            txtPLR.Size = new Size(136, 22);
            txtPLR.TabIndex = 6;
            // 
            // txtPericulosidade
            // 
            txtPericulosidade.Location = new Point(31, 119);
            txtPericulosidade.Name = "txtPericulosidade";
            txtPericulosidade.PlaceholderText = "Periculosidade";
            txtPericulosidade.ReadOnly = true;
            txtPericulosidade.Size = new Size(136, 22);
            txtPericulosidade.TabIndex = 7;
            // 
            // txtExtra
            // 
            txtExtra.Location = new Point(31, 61);
            txtExtra.Name = "txtExtra";
            txtExtra.PlaceholderText = "Horas Extra";
            txtExtra.Size = new Size(136, 22);
            txtExtra.TabIndex = 9;
            // 
            // lblAdicionais
            // 
            lblAdicionais.AutoSize = true;
            lblAdicionais.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdicionais.Location = new Point(31, 216);
            lblAdicionais.Name = "lblAdicionais";
            lblAdicionais.Size = new Size(32, 23);
            lblAdicionais.TabIndex = 4;
            lblAdicionais.Text = "R$";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 31);
            label4.Name = "label4";
            label4.Size = new Size(108, 23);
            label4.TabIndex = 4;
            label4.Text = "Adicionais";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 337);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
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
        private Label lblSalarioLiquido;
        private Button btnCalcular;
        private GroupBox groupBox3;
        private Button btnAdicionais;
        private TextBox txtAddNoturno;
        private TextBox txtPLR;
        private TextBox txtPericulosidade;
        private TextBox txtExtra;
        private Label lblAdicionais;
        private Label label4;
        private ComboBox cboInsalubridade;
    }
}