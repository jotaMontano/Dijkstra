using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dijkstra
{
    class Program
    {
        static void Main(string[] args)
        {
            Node nodeA = new Node("Mi casa", 9.864015, -83.918284);
            Node nodeB = new Node("San Jose", 12.1, 12.1);
            Node nodeC = new Node("San Pedro", 12.1, 12.1);
            Node nodeD = new Node("Cenfo", 12.1, 12.1);

 

            Graph g = new Graph();
            g.add_vertex(nodeA, new Dictionary<Node, int>() { { nodeD, 3 } });
            g.add_vertex(nodeB, new Dictionary<Node, int>() { { nodeC, 5 }  });
            g.add_vertex(nodeC, new Dictionary<Node, int>() { { nodeD, 4 }, { nodeB, 5 }});
            g.add_vertex(nodeD, new Dictionary<Node, int>() { { nodeC, 4 },{nodeA,3 } });
            /*g.add_vertex('A', new Dictionary<char, int>() { { 'B', 7 }, { 'C', 8 } });
            g.add_vertex('B', new Dictionary<char, int>() { { 'A', 7 }, { 'F', 2 } });
            g.add_vertex('C', new Dictionary<char, int>() { { 'A', 8 }, { 'F', 6 }, { 'G', 4 } });
            g.add_vertex('D', new Dictionary<char, int>() { { 'F', 8 } });
            g.add_vertex('E', new Dictionary<char, int>() { { 'H', 1 } });
            g.add_vertex('F', new Dictionary<char, int>() { { 'B', 2 }, { 'C', 6 }, { 'D', 8 }, { 'G', 9 }, { 'H', 3 } });
            g.add_vertex('G', new Dictionary<char, int>() { { 'C', 4 }, { 'F', 9 } });
            g.add_vertex('H', new Dictionary<char, int>() { { 'E', 1 }, { 'F', 3 } });*/

            foreach (var x in g.shortest_path(nodeA,nodeB))
            {
                Console.WriteLine(x.getName());
            }
            Console.Read();
        }
    }
}
