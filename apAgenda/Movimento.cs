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
            // o que usar como critério?
            return 0;
        }
    }
}
