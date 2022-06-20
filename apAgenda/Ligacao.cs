using System;
using System.IO;

namespace apCaminhos
{
    class Ligacao : IComparable<Ligacao>, IRegistro<Ligacao>
    {
        // tamanho dos atributos
        const int tamCodigo = 3,
                  tamDistancia = 5,
                  tamTempo = 4,
                  tamCusto = 5;

        // início dos atributos
        const int iniCodigoOrigem = 0,
                  iniCodigoDestino = iniCodigoOrigem + tamCodigo,
                  iniDistancia = iniCodigoDestino + tamCodigo,
                  iniTempo = iniDistancia + tamDistancia,
                  iniCusto = iniTempo + tamTempo;

        // atributos
        string codigoOrigem, codigoDestino;
        int distancia, custo, tempo;

        // acessadores get e set
        public string CodigoOrigem { get => codigoOrigem; set => codigoOrigem = value.PadLeft(tamCodigo, '0').Substring(0, tamCodigo); }
        public string CodigoDestino { get => codigoDestino; set => codigoDestino = value.PadLeft(tamCodigo, '0').Substring(0, tamCodigo); }
        public int Distancia { get => distancia; set => distancia = value; }
        public int Custo { get => custo; set => custo = value; }
        public int Tempo { get => tempo; set => tempo = value; }

        public Ligacao() // construtor vazio para instância new Dado()
        { }

        // construtor
        public Ligacao(string codigoOrigem, string codigoDestino, int distancia, int custo, int tempo)
        {
            CodigoOrigem = codigoOrigem;
            CodigoDestino = codigoDestino;
            Distancia = distancia;
            Custo = custo;
            Tempo = tempo;
        }

        public int CompareTo(Ligacao outro)
        {
            // a comparação das ligações é feita a partir de seus códigos concatenados
            return (CodigoOrigem + CodigoDestino).CompareTo((outro.CodigoOrigem + outro.CodigoDestino));
        }

        // método de leitura de arquivo
        public Ligacao LerRegistro(StreamReader arquivo)
        {
            if (arquivo != null) // arquivo aberto?
            {
                string linha = arquivo.ReadLine();

                CodigoOrigem = linha.Substring(iniCodigoOrigem, tamCodigo);
                CodigoDestino = linha.Substring(iniCodigoDestino, tamCodigo);
                Distancia = int.Parse(linha.Substring(iniDistancia, tamDistancia));
                Tempo = int.Parse(linha.Substring(iniTempo, tamTempo));
                Custo = int.Parse(linha.Substring(iniCusto));

                return this; // retorna o próprio objeto Caminho, com os dados
            }

            return default;
        }

        public void GravarRegistro(StreamWriter arquivo)
        {
            if (arquivo != null)  // arquivo de saída aberto?
            {
                arquivo.WriteLine(ParaArquivo());
            }
        }

        // método de string para arquivo
        public string ParaArquivo()
        {
            return CodigoOrigem + codigoDestino + Distancia.ToString("00000") +
                Tempo.ToString("0000") + Custo.ToString("00000");
        }

        // override do método to string
        public override string ToString()
        {
            return CodigoOrigem + " " + CodigoDestino + " " + Distancia +  " " + Custo + " " + Tempo;
        }
    }
}
