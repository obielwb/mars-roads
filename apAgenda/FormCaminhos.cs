using System;
using System.Drawing;
using System.Windows.Forms;

namespace apMarsRoads
{
    public partial class FormCaminhos : Form
    {
        ListaDupla<Cidade> cidades;

        public FormCaminhos()
        {
            InitializeComponent();
        }

        private void FrmAgenda_Load(object sender, EventArgs e)
        {
            int indice = 0;
            Caminhos.ImageList = imlBotoes;
            foreach (ToolStripItem item in Caminhos.Items)
                if (item is ToolStripButton)
                    (item as ToolStripButton).ImageIndex = indice++;


            if (dlgAbrirCidades.ShowDialog() == DialogResult.OK) // se o arquivo de cidades foi aberto
            {
                cidades = new ListaDupla<Cidade>(); // instancia uma lista dupla de cidades

                cidades.LerDados(dlgAbrirCidades.FileName); // lê os dados do arquivo aberto

                // limpa os combo boxes
                origemComboBox.Items.Clear();
                destinoComboBox.Items.Clear();

                cidades.PosicionarNoPrimeiro(); // posiciona no primeiro

                while (cidades.DadoAtual() != null) // enquanto atual for diferente de null
                {
                    // adiciona o dado atual no combo box
                    origemComboBox.Items.Add(cidades.DadoAtual().Nome);
                    destinoComboBox.Items.Add(cidades.DadoAtual().Nome);

                    cidades.AvancarPosicao(); // avança o atual
                }

                // define o texto dos combo boxes
                origemComboBox.Text = destinoComboBox.Text = "Selecione";
            }
        }

        private void mapaPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (cidades != null && cidades.Tamanho > 0) // se lista não for null e há elementos na lista
            {
                cidades.PosicionarNoPrimeiro(); // posiciona o atual no primeiro

                while (cidades.DadoAtual() != null) // enquanto atual for diferente de null
                {
                    Cidade cidadeASerDesenhada = cidades.DadoAtual(); // cidade recebe o dado atual

                    int x = (int)(cidadeASerDesenhada.X * mapaPictureBox.Width); // calcula a coordenada relativa ao X
                    int y = (int)(cidadeASerDesenhada.Y * mapaPictureBox.Height); // calcula a coordenada relativa ao Y

                    e.Graphics.FillEllipse(Brushes.Black, new Rectangle(x, y, 8, 8)); // desenha a cidade

                    Font font = new Font("Arial", 12); // instancia uma font Arial
                    e.Graphics.DrawString(
                        cidadeASerDesenhada.Nome,
                        font, Brushes.Black,
                        x - cidadeASerDesenhada.Nome.Length * 2,
                        y - 20
                    ); // desenha o nome da cidade

                    cidades.AvancarPosicao(); // avança o atual
                }
            }
        }
    }
}
