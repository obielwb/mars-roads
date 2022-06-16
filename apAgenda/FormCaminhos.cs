using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace apCaminhos
{
    public partial class FormCaminhos : Form
    {
        ListaDupla<Cidade> cidades;
        ListaDupla<Ligacao> ligacoes;
        Cidade origem;
        Cidade destino;
        PilhaVetor<Movimento> movimentos;

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

        //public bool IniciarBusca()
        //{

        //}

        private void acharCaminhosButton_Click(object sender, EventArgs e)
        {
            // se a cidade de origem e a cidade de destino não forem null
            if (origem != null && destino != null)
            {
                //////////////////////////////////   atributos   //////////////////////////////////
                ///
                // instancia uma matriz de adjacências com tamanho das cidades
                int[,] adjacencias = new int[cidades.Tamanho, cidades.Tamanho];

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

                // vetor lógica para registrar a passagem por uma cidade
                bool[] passou = new bool[cidades.Tamanho];

                // list que agrega os caminhos
                List<PilhaVetor<Movimento>> caminhos = new List<PilhaVetor<Movimento>>();

                // for que percorre o vetor de cidades visitadas
                for (int i = 0; i < passou.Length; i++)
                {
                    // e o preenche com false
                    passou[i] = false;
                }

                // pilha vetor de movimentos
                movimentos = new PilhaVetor<Movimento>();

                // variáveis para o registro da cidade e registro
                int cidadeAtual = codigoOrigem, saidaAtual = 0;

                // variáveis lógicas para o controle da busca
                bool achou = false, fim = false;

                //////////////////////////////////   busca   //////////////////////////////////
                ///
                // enquanto o caminho não foi encontrado e há saída
                while (!achou && !fim)
                {
                    // não há saída se a cidade atual é a cidade de origem
                    fim = cidadeAtual == codigoOrigem &&
                        saidaAtual == cidades.Tamanho && // se a cidade atual é a última cidade
                            movimentos.EstaVazia; // e a pilha de movimentos está vazia

                    // se há saída
                    if (!fim)
                    {
                        // enquanto a cidade atual não for a última cidade e o caminho não foi encontrado
                        while ((saidaAtual < cidades.Tamanho) && !achou)
                        {
                            // se não há saída
                            if (adjacencias[cidadeAtual, saidaAtual] == 0)
                            {
                                // tenta a próxima
                                saidaAtual++;
                            }

                            else // se há saída
                            {
                                // se a saída já foi visitada
                                if (passou[saidaAtual])
                                {
                                    // tenta a próxima
                                    saidaAtual++;
                                }

                                else // se a saída não foi visitada
                                {
                                    // o movimento é empilhado
                                    Movimento movimento = new Movimento(cidadeAtual, saidaAtual);
                                    movimentos.Empilhar(movimento);

                                    // se a saída for o destino
                                    if (saidaAtual == codigoDestino)
                                    {
                                        achou = true; // achou recebe true
                                    }

                                    else // se a saída não for o destino
                                    {
                                        // marca que a cidade já foi passada
                                        passou[cidadeAtual] = true;

                                        // a cidade atual recebe a saída
                                        cidadeAtual = saidaAtual;
                                        // a saída recebe zero
                                        saidaAtual = 0;
                                    }
                                }
                            }
                        }
                    }

                    // se um caminho não foi encontrado e a pilha de movimentos não está vazia
                    if (!achou && !movimentos.EstaVazia)
                    {
                        // desempilha o movimento anterior da pilha
                        Movimento movimentoAnterior = movimentos.Desempilhar();

                        // a cidade atual recebe a cidade de origem do movimento anterior
                        cidadeAtual = movimentoAnterior.Origem;
                        // a saída atual recebe a próxima cidade relativa ao movimento anterior
                        saidaAtual = movimentoAnterior.Destino + 1;
                    }
                }



                // se um caminho foi encontrado
                if (achou)
                {
                    // enquanto a pilha de movimentos não está vazia
                    while (!movimentos.EstaVazia)
                    {
                        ///////// inicia o processo de achar vários caminhos ////////
                        // Pilha que armazena as origens disponiveis para realizar a operação de backtracking da cidade atual
                        bool[] origensDisponiveis = new bool[cidades.Tamanho];

                        for (int i = 0; i < origensDisponiveis.Length; i++)
                            origensDisponiveis[i] = false; // inicializa todas as posições como false

                        var movimentoDesempilhado = movimentos.Desempilhar();

                        Cidade cidadeOrigemDoMovimento = BuscarCidadePorCodigo(movimentoDesempilhado.Origem);

                        // percorre as saidas possíveis da cidade de origem
                        saidaAtual = 0;
                        cidadeAtual = int.Parse(cidadeOrigemDoMovimento.Codigo);
                        while (saidaAtual < cidades.Tamanho)
                        {
                            if (adjacencias[cidadeAtual, saidaAtual] != 0)
                            {
                                // armazena as saidas da cidade atual no vetor de destinos possíveis
                                origensDisponiveis[saidaAtual] = true; 
                            }

                            saidaAtual++;
                        }

                        for (int i = 0; i < passou.Length; i++)
                            passou[i] = false;


                        for (int i = 0; i < origensDisponiveis.Length; i++)
                        {
                            // Verifica se há uma conexão com outra cidade
                            if (origensDisponiveis[i])
                            {
                                // instancia uma pilha de movimentos relativa ao caminho
                                PilhaVetor<Movimento> caminho = new PilhaVetor<Movimento>();

                                codigoOrigem = i;
                                codigoDestino = int.Parse(destino.Codigo);


                                // instancia uma nova pilha de movimentos para o caminho atual
                                PilhaVetor<Movimento> movimentosNovoCaminho = new PilhaVetor<Movimento>();

                                // variáveis para o registro da cidade e registro
                                cidadeAtual = codigoOrigem;
                                saidaAtual = 0;

                                // variáveis lógicas para o controle da busca
                                achou = false;
                                fim = false;

                                while (!achou && !fim)
                                {
                                    // não há saída se a cidade atual é a cidade de origem
                                    fim = cidadeAtual == codigoOrigem &&
                                        saidaAtual == cidades.Tamanho && // se a cidade atual é a última cidade
                                            movimentosNovoCaminho.EstaVazia; // e a pilha de movimentos está vazia

                                    // se há saída
                                    if (!fim)
                                    {
                                        // enquanto a cidade atual não for a última cidade e o caminho não foi encontrado
                                        while ((saidaAtual < cidades.Tamanho) && !achou)
                                        {
                                            // se não há saída
                                            if (adjacencias[cidadeAtual, saidaAtual] == 0)
                                            {
                                                // tenta a próxima
                                                saidaAtual++;
                                            }

                                            else // se há saída
                                            {
                                                // se a saída já foi visitada
                                                if (passou[saidaAtual])
                                                {
                                                    // tenta a próxima
                                                    saidaAtual++;
                                                }

                                                else // se a saída não foi visitada
                                                {
                                                    // o movimento é empilhado
                                                    Movimento movimento = new Movimento(cidadeAtual, saidaAtual);
                                                    movimentosNovoCaminho.Empilhar(movimento);

                                                    // se a saída for o destino
                                                    if (saidaAtual == codigoDestino)
                                                    {
                                                        achou = true; // achou recebe true
                                                    }

                                                    else // se a saída não for o destino
                                                    {
                                                        // marca que a cidade já foi passada
                                                        passou[cidadeAtual] = true;

                                                        // a cidade atual recebe a saída
                                                        cidadeAtual = saidaAtual;
                                                        // a saída recebe zero
                                                        saidaAtual = 0;
                                                    }
                                                }
                                            }
                                        }
                                    }

                                    if (!achou && !movimentosNovoCaminho.EstaVazia)
                                    {
                                        // desempilha o movimento anterior da pilha
                                        Movimento movimentoAnterior = movimentosNovoCaminho.Desempilhar();

                                        // a cidade atual recebe a cidade de origem do movimento anterior
                                        cidadeAtual = movimentoAnterior.Origem;
                                        // a saída atual recebe a próxima cidade relativa ao movimento anterior
                                        saidaAtual = movimentoAnterior.Destino + 1;
                                    }
                                }

                                if (achou)
                                {
                                    // conectar os movimentos anteriores aos novos movimentos para criar o novo caminho
                                    var movimentosAnteriores = movimentos.DadosDaPilha();
                                    var novosMovimentos = movimentosNovoCaminho.DadosDaPilha();

                                    for (int j = 0; j < movimentosAnteriores.Count; j++)
                                        caminho.Empilhar(movimentosAnteriores[j]);

                                    for (int j = 0; j < novosMovimentos.Count; j++)
                                        caminho.Empilhar(novosMovimentos[j]);

                                    // adiciona o caminho a list de caminhos
                                    caminhos.Add(caminho);
                                }
                            }
                        }
                    }
                }

                // exibe cada caminho no data grid view
                for (int i = 0; i < caminhos.Count; i++)
                {
                    DataGridViewRow row = (DataGridViewRow)caminhosEncontradosDataGridView.Rows[0].Clone();

                    int celula = 0;

                    foreach (Movimento movimento in caminhos[i].DadosDaPilha())
                    {
                        Cidade cidadeOrigem = BuscarCidadePorCodigo(movimento.Origem);

                        row.Cells[celula++].Value = cidadeOrigem.Nome;

                        Cidade cidadeDestino = BuscarCidadePorCodigo(movimento.Destino);
                        row.Cells[celula++].Value = cidadeDestino.Nome;
                    }

                    caminhosEncontradosDataGridView.Rows.Add(row);
                }
            }
            else // se não
            {
                // exibe uma message box de erro
                MessageBox.Show(
                    "Selecione uma cidade de origem e uma cidade de destino!",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private Cidade BuscarCidadePorCodigo(int codigo)
        {
            cidades.PosicionarNoPrimeiro(); // posiciona o atual no primeiro

            // variável de controle da busca
            bool achou = false;

            Cidade cidade = default;

            // enquanto a cidade ainda não foi encontrada
            while (!achou)
            {
                cidade = cidades.DadoAtual();

                if (int.Parse(cidade.Codigo) == codigo)
                {
                    achou = true;
                }

                else
                {
                    cidades.AvancarPosicao();
                }
            }

            return cidade;
        }

        private void AdicionarLinhaNoDgv(DataGridView dgvParaExibicao)
        {
            // TODO: Lógica de adicionar uma nova linha no dgv
        }
    }
}
