﻿using System;
using System.Collections.Generic;

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
                n =>
                {
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
                foreach (string neighbor in currentNode.getNeighbor())
                {
                    if (!visited[neighbor])
                    {
                        Node neighborNode = g.getNode(neighbor);
                        queue.Enqueue(neighborNode);
                        visited[neighbor] = true;
                        if (result.ContainsKey(neighbor))
                        {
                            neighborNode.getNeighbor().ForEach(
                                neighborOfNeighbor =>
                                {
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

           
        }

        public static void recommendationDFS(Graph G, Node N)
        {
            Dictionary<string, bool> visited = new Dictionary<string, bool>();
            G.getNodes().ForEach(n => visited.Add(n.getName(), false));

            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
            G.getNodes().ForEach(
                n =>
                {
                    if (n.getName() != N.getName() && !N.getNeighbor().Contains(n.getName()))
                    {
                        result.Add(n.getName(), new List<string>());
                    }
                }
            );

            DFSrekursif(G, N, N, ref visited, ref result); 
            foreach (KeyValuePair<string, List<string>> kvp in result)
            {
                System.Diagnostics.Debug.WriteLine(kvp.Key + ":");
                kvp.Value.ForEach(n => System.Diagnostics.Debug.WriteLine("\t" + n));
            }
        }

        private static void DFSrekursif(Graph G, Node SimpulAwal, Node N, ref Dictionary<string, bool> visited, ref Dictionary<string, List<string>> result)
        {
            if (!visited[SimpulAwal.getName()])
            {
                visited[SimpulAwal.getName()] = true; // nandain klo udh dikunjungin
            }

            List<string> friends = SimpulAwal.getNeighbor(); // list semua tetangga simpul awal
            
            if (SimpulAwal != N)
            {
                visited[N.getName()] = true;
                if (!friends.Contains(N.getName()))
                {
                    List<string> resultList = new List<string>();
                    N.getNeighbor().ForEach(
                       n =>
                       {
                           if (friends.Contains(n))
                           {
                                resultList.Add(n);
                           }
                       }
                    );
                    result[N.getName()] = resultList;
                }
            }

            // cari neighbor selanjutnya yang blom dikunjungin
            while (!isAllNeighborVisited(visited, N))
            {
                int i = 0;
                bool OutOfBounds = false;
                string nextNeighbor = N.getNeighbor()[i];
                i++;
                while (visited[nextNeighbor] && !OutOfBounds)
                {
                    if (i == N.getNeighbor().Count)
                    {
                        OutOfBounds = true;
                    }
                    else
                    {
                        nextNeighbor = N.getNeighbor()[i];
                        i++;
                    }
                }
                if (OutOfBounds)
                {
                    return;
                }
                DFSrekursif(G, SimpulAwal, G.getNode(nextNeighbor), ref visited, ref result);
            }
            
        }

        private static bool isAllNeighborVisited(Dictionary<string, bool> D, Node N)
        {
            bool visited = true;
            List<string> allNeighbor = N.getNeighbor();
            foreach (KeyValuePair<string, bool> x in D)
            {
                if (allNeighbor.Contains(x.Key))
                {
                    if (!x.Value)
                    {
                        visited = false;
                    }
                }
            }
            return visited;
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

            for (int i = 0; i < lines.Length; i++)
            {
                if (i == 0)
                {
                    numOfEdges = Int32.Parse(lines[i]);
                }
                else
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
