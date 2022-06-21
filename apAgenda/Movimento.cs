using System;

namespace apCaminhos
{
    class Movimento : IComparable<Movimento>
    {
        int origem, destino;

        public Movimento(int origem, int destino)
        {
            Origem = origem;
            Destino = destino;
        }

        public int Origem { get => origem; set => origem = value; }
        public int Destino { get => destino; set => destino = value; }

        public override string ToString()
        {
            return Origem + " " + Destino;
        }

        public int CompareTo(Movimento outro)
        {
            // a comparação dos movimentos é feita a partir de sua origem e seu destino concatenados
            return (Origem.ToString("000") + Destino.ToString("000")).CompareTo(outro.Origem.ToString("000") + outro.Destino.ToString("000"));
        }
    }
}
