using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Msagl.GraphViewerGdi;

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
        public List<Node> getNodes()
        {
            return this.nodes;
        }

        public Node getNode(string name)
        {
            foreach (Node el in this.nodes)
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
            foreach (Node el in this.nodes)
            {
                if (el.getName() == name)
                {
                    return true;
                }
            }
            return false;
        }

        public void displayInfo()
        {
            foreach (Node el in this.nodes)
            {
                System.Diagnostics.Debug.WriteLine(el.getName() + " :");
                foreach (string neighborName in el.getNeighbor())
                {
                    System.Diagnostics.Debug.WriteLine("\t" + neighborName);
                }
            }
        }

        public GViewer generateMSAGL()
        {
            GViewer viewer = new GViewer();
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");

            List<string[]> edges = new List<string[]>();

            foreach(Node n in this.nodes)
            {
                graph.AddNode(n.getName());
                foreach(string s in n.getNeighbor())
                {
                    //edges.FindIndex(e => e[0] == n.getName() && e[1] == s);
                    if (edges.FindIndex(e => e[0] == n.getName() && e[1] == s) < 0)
                    {
                        var edge = graph.AddEdge(n.getName(), s);
                        edge.Attr.ArrowheadAtTarget = Microsoft.Msagl.Drawing.ArrowStyle.None;
                        edge.Attr.ArrowheadAtSource = Microsoft.Msagl.Drawing.ArrowStyle.None;
                        string[] e1 = { n.getName(), s };
                        string[] e2 = { s, n.getName() };
                        edges.Add(e1);
                        edges.Add(e2);
                    }
                }
            }

            viewer.Graph = graph;
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;

            return viewer;
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

        public List<string> getNeighbor()
        {
            return this.neighbor;
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
