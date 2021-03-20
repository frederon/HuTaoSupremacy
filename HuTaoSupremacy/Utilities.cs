using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HuTaoSupremacy
{
    public static class Utilities
    {
        public static void printShit()
        {
            System.Diagnostics.Debug.WriteLine("hello world!");
        }

        public static Dictionary<string, List<string>> recommendationBFS(Graph g, Node s)
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

            return result;

            /* foreach(KeyValuePair<string, List<string>> kvp in result) {
                System.Diagnostics.Debug.WriteLine(kvp.Key + ":");
                kvp.Value.ForEach(n => System.Diagnostics.Debug.WriteLine("\t" + n));
            } */
        }

        public static Dictionary<string, List<string>> exploreBFS(Graph g, Node s, Node t)
        {
            Dictionary<string, bool> visited = new Dictionary<string, bool>();
            g.getNodes().ForEach(n => visited.Add(n.getName(), false));

            Dictionary<string, List<string>> path = new Dictionary<string, List<string>>();
            g.getNodes().ForEach(n => path.Add(n.getName(), new List<string>()));

            Queue<Node> queue = new Queue<Node>();

            queue.Enqueue(s);

            Node currentNode = queue.Dequeue();
            visited[currentNode.getName()] = true;

            while (currentNode.getName() != t.getName())
            {
                foreach (string neighbor in currentNode.getNeighbor())
                {
                    if (!visited[neighbor])
                    {
                        Node neighborNode = g.getNode(neighbor);
                        queue.Enqueue(neighborNode);
                        visited[neighbor] = true;
                        foreach(string str in path[currentNode.getName()])
                        {
                            path[neighbor].Add(str);
                        }
                        path[neighbor].Add(currentNode.getName());
                    }
                }
                currentNode = queue.Dequeue();
            }

            return path;

            /* foreach (KeyValuePair<string, List<string>> kvp in path)
            {
                System.Diagnostics.Debug.WriteLine(kvp.Key + ":");
                kvp.Value.ForEach(n => System.Diagnostics.Debug.WriteLine("\t" + n));
            } */
            
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

        public static string formatResult(
            string account,
            string exploreFriend,
            Dictionary<string, List<string>> recommendation,
            Dictionary<string, List<string>> explore
        )
        {
            string result = "";
            result += "Daftar rekomendasi teman untuk akun " + account + ":\n";

            var sortedRecommendation = from entry in recommendation
                                       orderby entry.Value.Count
                                           descending
                                       select entry;

            foreach (KeyValuePair<string, List<string>> kvp in sortedRecommendation)
            {
                if (kvp.Value.Count > 0)
                {
                    result += "Nama akun: " + kvp.Key + "\n";
                    result += kvp.Value.Count + " mutual friends:\n";
                    kvp.Value.ForEach(n => result += n + "\n");
                    result += "\n";
                }   
            }

            result += "\n";
            result += "Nama akun: " + account + " dan " + exploreFriend + "\n";
            if (explore[exploreFriend].Count > 0)
            {
                result += explore[exploreFriend].Count - 1 + " degree connection\n";
                foreach (string str in explore[exploreFriend])
                {
                    result += str + " -> ";
                }
                result += exploreFriend + "\n";
            } else
            {
                result += "Tidak ada jalur koneksi yang tersedia\nAnda harus memulai koneksi baru itu sendiri.";
            }

            return result;
        }
    }
}
