using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafosEArte
{
    class Vertice
    {
        public object ponto { get; set; }
    }

    /// <summary>
    /// Aresta é a junção de duas vertices
    /// </summary>
    class Aresta
    {
        public Dictionary<Vertice, Vertice> DuplaDeVetices { get; set; }
    }

    class Grafo
    {
        public Vertice[] Vetices { get; set; }

        public Dictionary<Vertice, Aresta> ConjuntoDeVetice { get; set; }
    }

    class Program
    {        
        static void Main(string[] args)
        {
            var sudeste = new Grafo();
            var SaoPaulo = "São Paulo";
            var MinasGerais = "Minas Gerais";
            var EspiritoStanto = "Espirito Santo";
        }
    }
}
