using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafosEArte
{
    class Vertice
    {
        public object[] ponto { get; set; }
    }

    /// <summary>
    /// Aresta é a junção de duas faces
    /// </summary>
    class Aresta
    {
        public Dictionary<Vertice, Vertice> DuplaDeVetices { get; set; }
    }

    class Grafo
    {
        public Dictionary<Vertice, Aresta> ConjuntoDeVetice { get; set; }
    }

    class Program
    {        
        static void Main(string[] args)
        {
            //object grafo = (Vertice, Arestas);
        }
    }
}
