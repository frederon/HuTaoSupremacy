using System;
using System.Collections.Generic;
using System.Text;

namespace HuTaoSupremacy
{
    public class Graph
    {
        private List<Node> nodes;
        public Graph()
        {
            this.nodes = new List<Node>();
        }

        //setter and getter
        public Node getNode(string name)
        {
            foreach (Node el in nodes)
            {
                if (el.getName() == name)
                {
                    return el;
                }
            }
            return null;
        }

        //method
        public void addNode(Node N)
        {
            if(!this.hasNode(N.getName()))
            {
                nodes.Add(N);
            }
        }

        public bool hasNode(string name)
        {
            foreach (Node el in nodes)
            {
                if (el.getName() == name)
                {
                    return true;
                }
            }
            return false;
        }
    }
    public class Node
    {
        private string name;
        private List<string> neighbor;
        public Node(string name)
        {
            this.name = name;
            this.neighbor = new List<string>();
        }
        
        //setter and getter
        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        // method
        public void addNeighbor(string name)
        {
            if(!this.neighbor.Contains(name)) {
                this.neighbor.Add(name);
            }
        }
    }
}
