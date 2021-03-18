using System;
using System.Collections.Generic;
using System.Text;

namespace HuTaoSupremacy
{
    class Graph
    {
        private List<Node> nodes;
        public Graph()
        {
            this.nodes = new List<Node>();
        }

        public void addNode(Node N)
        {
            if(!this.nodes.Contains(N))
            {
                nodes.Add(N);
            }
        }
    }
    class Node
    {
        private string name;
        private List<string> neighbor;
        public Node(string name)
        {
            this.name = name;
            this.neighbor = new List<string>();
        }

        public void addNeighbor(string name)
        {
            if(!this.neighbor.Contains(name)) {
                this.neighbor.Add(name);
            }
        }
    }
}
