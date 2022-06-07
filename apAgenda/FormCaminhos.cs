using System;
using System.Drawing;
using System.Windows.Forms;

namespace apCaminhos
{
    public partial class FormCaminhos : Form
    {
        ListaDupla<Cidade> cidades;
        ListaDupla<Ligacao> ligacoes
            ;
        Cidade origem;
        Cidade destino;

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


            if (cidadesOpenFileDialog.ShowDialog() == DialogResult.OK) // se o arquivo de cidades foi aberto
            {
                cidades = new ListaDupla<Cidade>(); // instancia uma lista dupla de cidades

                cidades.LerDados(cidadesOpenFileDialog.FileName); // lê os dados do arquivo aberto

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

            if (caminhosOpenFileDialog.ShowDialog() == DialogResult.OK) // se o arquivo de caminhos foi aberto
            {
                ligacoes = new ListaDupla<Ligacao>(); // instancia uma lista dupla de cidades

                ligacoes.LerDados(caminhosOpenFileDialog.FileName); // lê os dados do arquivo aberto
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

        private void FormCaminhos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ligacoes != null && caminhosOpenFileDialog.FileName != "") // se lista não foi null e um arquivo foi aberto
            {
                ligacoes.Ordenar(); // a lista é ordenada
                ligacoes.GravarDados(caminhosOpenFileDialog.FileName); // e depois tem seus dados gravados
            }
        }

        // TODO: critério de separação: como procurar por id e por nome?

        private void origemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // instancia uma cidade com o texto do elemento selecionado
            Cidade cidadeSelecionada = new Cidade("".PadLeft(3, '0'), origemComboBox.Text, 0, 0);

            // se a cidade existe
            if (cidades.Existe(cidadeSelecionada, out _))
            {
                // a cidade de origem recebe o dado atual
                origem = cidades.DadoAtual();
            }
        }

        private void destinoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // instancia uma cidade com o texto do elemento selecionado
            Cidade cidadeSelecionada = new Cidade("".PadLeft(3, '0'), destinoComboBox.Text, 0, 0);

            // se a cidade existe
            if (cidades.Existe(cidadeSelecionada, out _))
            {
                // a cidade de destino recebe o dado atual
                destino = cidades.DadoAtual();
            }
        }

        private void acharCaminhosButton_Click(object sender, EventArgs e)
        {
            // instancia uma matriz de adjacências com tamanho das cidades
            int[ , ] adjacencias = new int[cidades.Tamanho, cidades.Tamanho];

            ligacoes.PosicionarNoPrimeiro(); // posiciona o atual no primeiro

            while (ligacoes.DadoAtual() != null) // enquanto atual não for null
            {
                // obtém o dado atual e o atribui à ligação
                Ligacao ligacao = ligacoes.DadoAtual();

                // atribui ao elemento relativo aos códigos a distância
                adjacencias[int.Parse(ligacao.CodigoOrigem), int.Parse(ligacao.CodigoDestino)] = ligacao.Distancia;

                ligacoes.AvancarPosicao(); // avança o atual
            }

            // códigos de origem e destino
            int codigoOrigem = int.Parse(origem.Codigo);
            int codigoDestino = int.Parse(destino.Codigo);
        }
    }
}
