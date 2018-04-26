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
        private double LatInitial;
        private double LngInitial;

        public Node(string name, double LatInitial, double LngInitial)
        {
            this.name = name;
            this.LatInitial = LatInitial;
            this.LngInitial = LngInitial;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
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
