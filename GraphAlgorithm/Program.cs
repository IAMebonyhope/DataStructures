using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Vertix<String>, List<Node<String>>> graph = new Dictionary<Vertix<String>, List<Node<String>>>();

            Vertix<String> v1 = new Vertix<String>("A");
            Vertix<String> v2 = new Vertix<String>("B");
            Vertix<String> v3 = new Vertix<String>("C");
            Vertix<String> v4 = new Vertix<String>("D");
            Vertix<String> v5 = new Vertix<String>("E");

            //adjacent nodes of v1
            List<Node<String>> arr1 = new List<Node<String>>();
            arr1.Add(new Node<String>(v2, 2));
            arr1.Add(new Node<String>(v3, 5));
            arr1.Add(new Node<String>(v4, 7));
            //arr1.Add(new Node<String>(v5, 4));
            graph.Add(v1, arr1);

            List<Node<String>> arr2 = new List<Node<String>>();
            //arr2.Add(new Node<String>(v1, 7));
            arr2.Add(new Node<String>(v3, 2));
            //arr2.Add(new Node<String>(v4, 2));
            //arr2.Add(new Node<String>(v5, 6));
            graph.Add(v2, arr2);

            List<Node<String>> arr3 = new List<Node<String>>();
            //arr3.Add(new Node<String>(v1, 3));
            //arr3.Add(new Node<String>(v2, 2));
            arr3.Add(new Node<String>(v4, 2));
            //arr3.Add(new Node<String>(v5, 1));
            graph.Add(v3, arr3);

            //
            List<Node<String>> arr4 = new List<Node<String>>();
            //arr4.Add(new Node<String>(v1, 1));
            //arr4.Add(new Node<String>(v2, 2));
            //arr4.Add(new Node<String>(v3, 2));
            arr4.Add(new Node<String>(v5, 1));
            graph.Add(v4, arr4);

            List<Node<String>> arr5 = new List<Node<String>>();
            arr5.Add(new Node<String>(v1, 3));
            arr5.Add(new Node<String>(v2, 3));
            //arr5.Add(new Node<String>(v3, 5));
            //arr5.Add(new Node<String>(v4, 4));
            graph.Add(v5, arr5);

            Graph<String> Graph = new Graph<String>(graph);

            DijkstraAlgorithm<String> dijs = new DijkstraAlgorithm<String>(Graph, v1);

            
            Graph.printGraph();

            Console.WriteLine();
            Console.WriteLine();

            dijs.PrintShortestPath();
        }
    }
}
