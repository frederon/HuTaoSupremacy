using System;
using System.Collections.Generic;
using System.Text;

namespace HuTaoSupremacy
{
    public static class Utilities
    {
        public static void printShit()
        {
            System.Diagnostics.Debug.WriteLine("hello world!");
        }

        public static void recommendationBFS(Graph g, Node s)
        {
            Dictionary<string, bool> visited = new Dictionary<string, bool>();
            g.getNodes().ForEach(n => visited.Add(n.getName(), false));

            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
            g.getNodes().ForEach(
                n => {
                    if (n.getName() != s.getName() && !s.getNeighbor().Contains(n.getName()))
                    {
                        result.Add(n.getName(), new List<string>());
                    }
                }
            );

            List<string> friends = s.getNeighbor();

            Queue<Node> queue = new Queue<Node>();

            queue.Enqueue(s);

            while (queue.Count > 0)
            {
                Node currentNode = queue.Dequeue();
                foreach(string neighbor in currentNode.getNeighbor())
                {
                    if (!visited[neighbor])
                    {
                        Node neighborNode = g.getNode(neighbor);
                        queue.Enqueue(neighborNode);
                        visited[neighbor] = true;
                        if (result.ContainsKey(neighbor))
                        {
                            neighborNode.getNeighbor().ForEach(
                                neighborOfNeighbor => {
                                    if (friends.Contains(neighborOfNeighbor))
                                    {
                                        result[neighbor].Add(neighborOfNeighbor);
                                    }
                                }
                            );
                        }
                    }
                }
            }

            foreach(KeyValuePair<string, List<string>> kvp in result) {
                System.Diagnostics.Debug.WriteLine(kvp.Key + ":");
                kvp.Value.ForEach(n => System.Diagnostics.Debug.WriteLine("\t" + n));
            }
        }

        public static List<string> exploreBFS(Graph g, Node s, Node t)
        {
            Dictionary<string, bool> visited = new Dictionary<string, bool>();
            g.getNodes().ForEach(n => visited.Add(n.getName(), false));

            List<string> result = new List<string>();

            Queue<Node> queue = new Queue<Node>();

            queue.Enqueue(s);

            while (queue.Count > 0)
            {
                Node currentNode = queue.Dequeue();
                foreach (string neighbor in currentNode.getNeighbor())
                {
                    if (!visited[neighbor])
                    {
                        Node neighborNode = g.getNode(neighbor);
                        queue.Enqueue(neighborNode);
                        visited[neighbor] = true;
                    }
                }
            }

            return result;
        }

        public static Graph StringToGraph(string text)
        {
            Graph g = new Graph();

            int numOfEdges = 0;

            string[] lines = text.Split(
                new[] { "\r\n", "\r", "\n" },
                StringSplitOptions.None
            );

            for(int i = 0; i < lines.Length; i++)
            {
                if (i == 0)
                {
                    numOfEdges = Int32.Parse(lines[i]);
                } else
                {
                    string[] s = lines[i].Split(' ');
                    Node n1 = g.getNode(s[0]);
                    Node n2 = g.getNode(s[1]);
                    if (n1 == null)
                    {
                        n1 = new Node(s[0]);
                        g.addNode(n1);
                    }
                    if (n2 == null)
                    {
                        n2 = new Node(s[1]);
                        g.addNode(n2);
                    }

                    n1.addNeighbor(n2.getName());
                    n2.addNeighbor(n1.getName());
                }
            }

            return g;
        }
    }
}
