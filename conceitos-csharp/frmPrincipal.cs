using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace conceitos_csharp
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Nome: {txtNome.Text}\n" +
                $"Email: {txtEmail.Text}\n" +
                $"Senha: {txtSenha.Text}\n" +
                $"CPF: {txtCPF.Text}\n" +
                $"Data de Nascimento Value: {dtpNasc.Value}\n" +
                $"Data de Nascimento Value: {dtpNasc.Text}\n" +
                $"Telefone: {txtTelefone.Text}");
        }



        private void CalcularINSS()
        {

        }







        // Calcula INSS usando faixas progressivas (valores exemplificativos, ajustar conforme tabela vigente)
        private decimal CalculateINSS(decimal salario)
        {
            // Exemplo de faixas (valores e alíquotas fictícias para demonstração):
            // até 1212.00 => 7.5%
            // 1212.01 até 2427.35 => 9%
            // 2427.36 até 3641.03 => 12%
            // 3641.04 até 7087.22 => 14%

            decimal desconto = 0m;

            var restante = salario;

            // Faixa 1
            var faixa1 = 1212.00m;
            if (restante > 0)
            {
                var valor = Math.Min(restante, faixa1);
                desconto += valor * 0.075m;
                restante -= valor;
            }

            // Faixa 2
            var faixa2 = 2427.35m - 1212.00m;
            if (restante > 0)
            {
                var valor = Math.Min(restante, faixa2);
                desconto += valor * 0.09m;
                restante -= valor;
            }

            // Faixa 3
            var faixa3 = 3641.03m - 2427.35m;
            if (restante > 0)
            {
                var valor = Math.Min(restante, faixa3);
                desconto += valor * 0.12m;
                restante -= valor;
            }

            // Faixa 4
            var faixa4 = 7087.22m - 3641.03m;
            if (restante > 0)
            {
                var valor = Math.Min(restante, faixa4);
                desconto += valor * 0.14m;
                restante -= valor;
            }

            // Se salário acima do teto, desconto máximo já calculado até o teto (7087.22)

            return Math.Round(desconto, 2);
        }

        // Calcula IRRF com base na base de cálculo (salário - INSS)
        private decimal CalculateIRRF(decimal baseCalculo)
        {
            // Tabela exemplificativa (alíquotas e parcela a deduzir) - ajustar conforme tabela vigente:
            // até 1903.98 => isento
            // 1903.99 até 2826.65 => 7.5% - parcela 142.80
            // 2826.66 até 3751.05 => 15% - parcela 354.80
            // 3751.06 até 4664.68 => 22.5% - parcela 636.13
            // acima 4664.68 => 27.5% - parcela 869.36

            decimal aliquota = 0m;
            decimal parcela = 0m;

            if (baseCalculo <= 1903.98m)
            {
                return 0m;
            }
            else if (baseCalculo <= 2826.65m)
            {
                aliquota = 0.075m; parcela = 142.80m;
            }
            else if (baseCalculo <= 3751.05m)
            {
                aliquota = 0.15m; parcela = 354.80m;
            }
            else if (baseCalculo <= 4664.68m)
            {
                aliquota = 0.225m; parcela = 636.13m;
            }
            else
            {
                aliquota = 0.275m; parcela = 869.36m;
            }

            var irrf = (baseCalculo * aliquota) - parcela;
            if (irrf < 0) irrf = 0m;
            return Math.Round(irrf, 2);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //cálculo INSS
            decimal salario = Convert.ToDecimal(txtSalarioBruto.Text);
            decimal inss = CalculateINSS(salario);
            txtINSS.Text = inss.ToString("F2", CultureInfo.CurrentCulture);

            //cálculo IRRF
            decimal baseCalculo = salario - inss;
            decimal irrf = CalculateIRRF(baseCalculo);
            txtIRRF.Text = irrf.ToString("F2", CultureInfo.CurrentCulture);

            //cálculo VT e VR
            decimal VT = salario * 0.06m; // Exemplo de VT (6% do salário bruto)
            txtVT.Text = VT.ToString("F2", CultureInfo.CurrentCulture);

            decimal VR = salario * 0.10m;
            txtVR.Text = VR.ToString("F2", CultureInfo.CurrentCulture);

            decimal salarioLiquido = salario - inss - irrf - VT - VR;
            lblSalarioLiquido.Text = salarioLiquido.ToString("F2", CultureInfo.CurrentCulture);


        }

        private void btnAdicionais_Click(object sender, EventArgs e)
        {
            decimal salario = decimal.Parse(txtSalarioBruto.Text);

            decimal horasExtras = decimal.Parse(txtExtra.Text);
            decimal valorHoraExtra = salario / 220; // Exemplo: salário dividido por 220 horas mensais
            decimal valorTotalHorasExtras = horasExtras * valorHoraExtra;
            decimal insalubridade = 0m;
            decimal salarioMinimo = 1621.00m; // Exemplo de salário mínimo vigente

            switch (cboInsalubridade.SelectedIndex.ToString())
            {
                case "0": // Nenhuma
                    insalubridade = salarioMinimo * 0.10m;
                    break;
                case "1":
                    insalubridade = salarioMinimo * 0.20m; // Exemplo: insalubridade de 10% sobre o salário bruto
                    break;
                case "2":
                    insalubridade = salarioMinimo * 0.40m; // Exemplo: insalubridade de 20% sobre o salário bruto
                    break;
                default:
                    insalubridade = 0m; // Exemplo: insalubridade de 20% sobre o salário bruto
                    break;
            }

            decimal periculosidade = salario * 0.30m; // Exemplo: periculosidade de 30% sobre o salário bruto

            decimal PLR = Convert.ToDecimal(txtPLR.Text); // Exemplo: PLR de 10% sobre o salário bruto

            decimal adicionalNoturno = Convert.ToDecimal(txtAddNoturno.Text);
            decimal adicionalNoturnoValor = salario * 0.20m; // Exemplo: adicional noturno de 20% sobre o valor da hora

            MessageBox.Show(
                $"Salario: {txtSalarioBruto.Text}\n " +
                $"Valor total Horas extras: {valorTotalHorasExtras}\n" +
                $"PLR: {PLR}\n" +
                $"Periculosidade: {periculosidade}\n" +
                $"Insalubridade: {insalubridade}\n" +
                $"Adicional Noturno: {adicionalNoturnoValor}");


            lblAdicionais.Text = (valorTotalHorasExtras + PLR + adicionalNoturno).ToString();

        }
    }
}
