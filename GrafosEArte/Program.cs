using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafosEArte
{
    class Vertice {
        public Vertice(string ponto) {
            this.Ponto = ponto;
        }
        public string Ponto { get; set; }
    }
        
    class Aresta {
        public Aresta(Vertice vertice1, Vertice vertice2)
        {
            Vertice[] aresta = new Vertice[2];
            aresta[0] = vertice1;
            aresta[1] = vertice2;
            this.DuplaDeVetices = aresta;
        }
        public Vertice[] DuplaDeVetices { get; set; }
    }

    class Grafo {
        public Grafo(Vertice[] vetices, Aresta[] aresta)
        {
            this.Vetices = vetices;
            this.Aresta = aresta;
        }
        public Vertice[] Vetices { get; set; }
        public Aresta[] Aresta { get; set; }
    }

    class Program
    {        
        static void Main(string[] args)
        {   
            Vertice[] vertices = new Vertice[4];
            vertices[0] = new Vertice("São Paulo");
            vertices[1] = new Vertice("Minas Gerais");
            vertices[2] = new Vertice("Espirito Santo");
            vertices[3] = new Vertice("Rio de Janeiro");

            Aresta aresta1 = new Aresta(vertices[0], vertices[1]);
            Aresta aresta2 = new Aresta(vertices[0], vertices[3]);
            Aresta aresta3 = new Aresta(vertices[1], vertices[2]);
            Aresta aresta4 = new Aresta(vertices[1], vertices[3]);
            Aresta aresta5 = new Aresta(vertices[2], vertices[3]);

            Grafo RegiaoSudeste = new Grafo(vertices, Arestas);
            Console.Write(RegiaoSudeste);
        }
    }
}
