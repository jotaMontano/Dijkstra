using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dijkstra
{
    public class Node
    {

        private string name;
        private LinkedList<Node> shortestPath = new LinkedList<Node>();
        private int distance = int.MaxValue;
        //  private int mts;
        private double LatInitial;
        private double LngInitial;
        //private Dictionary<Node, int> adjacentNodes = new Dictionary<Node, int>();
        private Dictionary<Node, int> adjacentNodes = new Dictionary<Node, int>();

        public Node(string name, double LatInitial, double LngInitial/*, int mts*/)
        {
            this.name = name;
            this.LatInitial = LatInitial;
            this.LngInitial = LngInitial;
            //          this.mts = mts;
        }

        public void addDestination(Node destination, int distance)
        {
            adjacentNodes.Add(destination, distance);
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public void setShortestPath(LinkedList<Node> shortestPath)
        {
            this.shortestPath = shortestPath;
        }
        public LinkedList<Node> getShortestPath()
        {
            return shortestPath;
        }
        public void setDistance(int distance)
        {
            this.distance = distance;
        }
        public int getDistance()
        {
            return distance;
        }
        public void setAdjacentNodes(Dictionary<Node, int> adjacentNodes)
        {
            this.adjacentNodes = adjacentNodes;
        }
        public Dictionary<Node, int> GetAdjacentNodes()
        {
            return adjacentNodes;
        }
        public void setLatInitial(double LatInitial)
        {
            this.LatInitial = LatInitial;
        }

        public double getLatInitial()
        {
            return this.LatInitial;
        }
        public void setLngInitial(double LngInitial)
        {
            this.LngInitial = LngInitial;
        }
        public double getLngInitial()
        {
            return this.LngInitial;
        }

    }

}
