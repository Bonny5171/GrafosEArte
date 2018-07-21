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
        public Aresta(Vertice pontoA, Vertice pontoB) {
            this.pontoA = pontoA;
            this.pontoB = pontoB;
        }
        public Vertice pontoA { get; set; }
        public Vertice pontoB { get; set; }
    }

    class Grafo {
        public Grafo(Vertice[] vetices, Aresta[] aresta)
        {
            this.Vetices = vetices;
            this.Arestas = aresta;
        }
        public Vertice[] Vetices { get; set; }
        public Aresta[] Arestas { get; set; }
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

            Aresta[] arestas = new Aresta[5];
            arestas[0] = new Aresta(vertices[0], vertices[1]);
            arestas[1] = new Aresta(vertices[0], vertices[3]);
            arestas[2] = new Aresta(vertices[1], vertices[2]);
            arestas[3] = new Aresta(vertices[1], vertices[3]);
            arestas[4] = new Aresta(vertices[2], vertices[3]);

            Grafo RegiaoSudeste = new Grafo(vertices, arestas);
            Console.Write(RegiaoSudeste);
        }
    }
}
