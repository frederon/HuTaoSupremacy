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
