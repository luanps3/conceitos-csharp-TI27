namespace conceitos_csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Tipos Númericos
        byte b = 10; // 1 byte
        int idade = 18; // 4 bytes
        short ano = 2024; // 2 bytes
        long populacao = 7_900_000_000; // 8 bytes

        //Tipo Reais
        float peso = 60.5f; //Sufixo 'f' para float e 
        double altura = 1.75d; // double diferente do float, tem maior precisão
        decimal saldoBancario = 10500.75m; // decimal geralmente usado para valores monetários, sufixo 'm'


        //Lógicos e texto
        bool estaChovendo = false; // true ou false
        string nome = "Luan"; // Cadeia de caracteres
        char inicialDoNome = 'L'; // Caractere único

      


        private void btnExibeMensagem_Click(object sender, EventArgs e)
        {
        //Inferência com var
        var mensagem = "Olá Mundo! COM ÎNFERÊNCIA"; // O compilador infere que é string


            MessageBox.Show
                (
                $"Númericos: {txtNumericos.Text}\n" +
                $"Textuais: {txtTextuais.Text}\n" +
                $"Inferência: {txtInferencia.Text}"
                );
        }
    }
}
