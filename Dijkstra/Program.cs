
using System;
using System.Collections.Generic;

namespace Project_Dijkstra
{
    class Program
    {
        static void Main(string[] args)
        {
            Node nodeA = new Node("cartago", 9.864015, -83.918284);
            Node nodeB = new Node("San Jose", 12.1, 12.1);
            Node nodeC = new Node("San Pedro", 12.1, 12.1);
            Node nodeD = new Node("Cenfo",  12.1, 12.1);
          
            nodeA.addDestination(nodeB, 20);
            nodeA.addDestination(nodeD, 5);
            nodeA.addDestination(nodeC, 12);

            nodeB.addDestination(nodeA, 20);
            nodeB.addDestination(nodeC, 15);
            nodeB.addDestination(nodeD, 12);

            nodeC.addDestination(nodeA, 12);
            nodeC.addDestination(nodeB, 15);
            nodeC.addDestination(nodeD, 10);

            nodeD.addDestination(nodeA, 5);
            nodeD.addDestination(nodeB, 12);
            nodeD.addDestination(nodeC, 10);

            Graph graph = new Graph();

            graph.addNode(nodeA);
            graph.addNode(nodeB);
            graph.addNode(nodeC);
            graph.addNode(nodeD);
          

            graph = Dijkstra.calculateShortestPathFromSource(graph, nodeA);
            List<Node> shortestPathForNodeE = new List<Node> { nodeA, nodeB, nodeD };
            foreach (Node node in graph.getNodes())
            {
                foreach (Node destino in node.getShortestPath())
                {
                    Console.WriteLine(string.Format("Nodo {0}: destino {1}", node.getName(), destino.getName()));
                }
            }
            Console.Read();
        }
    }
}
