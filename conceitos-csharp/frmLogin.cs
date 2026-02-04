using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace conceitos_csharp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        string usuario = "admin";
        string senha = "1234";

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == usuario && txtSenha.Text == senha) 
            {
                MessageBox.Show("Login efetuado com sucesso", "Sucesso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form1 telaPrincipal = new();
                telaPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Usuário ou senha inválidos", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
