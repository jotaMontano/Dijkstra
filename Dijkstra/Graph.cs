using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dijkstra
{
    public class Graph
    {
        private HashSet<Node> nodes = new HashSet<Node>();
        
        public void addNode(Node node)
        {
            nodes.Add(node);
        }

        public HashSet<Node> getNodes()
        {
            return nodes;
        }

        public void setNodes(HashSet<Node> nodes)
        {
            this.nodes = nodes;
        }

    }
}
