
using System;
using System.Collections;
using System.Collections.Generic;


namespace Project_Dijkstra
{
    public class Dijkstra
    {

        public static Graph calculateShortestPathFromSource(Graph graph, Node source)
        {
            source.setDistance(0);
            HashSet<Node> settledNodes = new HashSet<Node>();
            HashSet<Node> unsettledNodes = new HashSet<Node>();
            unsettledNodes.Add(source);
            while (unsettledNodes.Count != 0)
            {
              
                Node currentNode = getLowestDistanceNode(unsettledNodes);
                unsettledNodes.Remove(currentNode);
                foreach (KeyValuePair<Node,int> adjacencyPair in currentNode.GetAdjacentNodes())
                {
                    Node adjecentNode = adjacencyPair.Key;
                    int edgeWeight = adjacencyPair.Value;
                    if (!settledNodes.Contains(adjecentNode))
                    {
                        calculateMinimunDistance(adjecentNode, edgeWeight, currentNode);
                    }
                }
                settledNodes.Add(currentNode);
            }
            return graph;
        }
        public static Node getLowestDistanceNode(HashSet<Node> unsettledNodes)
        {
            Node lowestDistanceNode = null;
            int lowestDistance = int.MaxValue;
            foreach (Node node in unsettledNodes)
            {
                int nodeDistance = node.getDistance();
                if (nodeDistance < lowestDistance)
                {
                    lowestDistance = nodeDistance;
                    lowestDistanceNode = node;
                }
            }
            return lowestDistanceNode;
        }
        public static void calculateMinimunDistance(Node evaluationNode, int edgeWeight, Node sourceCode)
        {
            int sourceDistance = sourceCode.getDistance();
            if (sourceDistance + edgeWeight < evaluationNode.getDistance())
            {
                evaluationNode.setDistance(sourceDistance + edgeWeight);
                LinkedList<Node> shortestPath = new LinkedList<Node>(sourceCode.getShortestPath());
                shortestPath.AddLast(sourceCode);
                evaluationNode.setShortestPath(shortestPath);
            }
        }
    }
}
