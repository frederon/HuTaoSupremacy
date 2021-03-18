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

        public static void stringToGraph(string text)
        {
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
                    string node1 = s[0];
                    string node2 = s[1];
                    System.Diagnostics.Debug.WriteLine(node1);
                    System.Diagnostics.Debug.WriteLine(node2);
                }
            }
        }
    }
}
