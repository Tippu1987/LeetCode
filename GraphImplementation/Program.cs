using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace GraphImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphAdjacencyList g = new GraphAdjacencyList(6);
            Graph gl = new Graph(6);
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 3);
            g.AddEdge(2, 4);
            g.AddEdge(3, 5);
            g.AddEdge(4, 5);
            g.AddEdge(1, 4);
            g.AddEdge(3, 4);


            gl.AddEdge(0, 1);
            gl.AddEdge(0, 2);
            gl.AddEdge(1, 3);
            gl.AddEdge(3, 5);
            gl.AddEdge(4, 5);
            gl.AddEdge(2, 4);
            gl.AddEdge(1, 4);
            gl.AddEdge(3, 4);


            //g.PrintGraph();

            g.DoBFS(0);
            Console.WriteLine("\n--------------------------------\n");
            gl.DoBFS(0);
            //Console.WriteLine("Recursive\n...................");
            //g.DoDFSRecursive(0, new HashSet<int>());
        }
    }

    class Graph
    {
        List<int>[] nodes;
        private readonly int vertices;
        public Graph(int vertexCount)
        {
            vertices = vertexCount;
            nodes = new List<int>[vertexCount];
            for (int i = 0; i < vertexCount; i++)
            {
                nodes[i] = new List<int>();
            }
        }
        public void AddEdge(int src, int trg)
        {
            if (src < nodes.Length && trg < nodes.Length)
            {
                if (!nodes[src].Contains(trg))
                    nodes[src].Add(trg);
                if (!nodes[trg].Contains(src))
                    nodes[trg].Add(src);
            }
        }

        public void PrintGraph()
        {
            for (int i = 0; i < nodes.Length; i++)
            {
                Console.WriteLine($"{i}->{string.Join("->", nodes[i])}");
            }
        }

        public void DoDFS(int startVertex)
        {
            if (startVertex < 0 || startVertex >= nodes.Length) return;
            Stack<int> dfs = new Stack<int>();
            HashSet<int> seenbefore = new HashSet<int>();
            dfs.Push(startVertex);
            while (dfs.Count > 0)
            {
                int val = dfs.Pop();
                Console.Write($"{val}->");
                if (!seenbefore.Contains(val))
                    seenbefore.Add(val);
                if (nodes[val].Count > 0)
                {
                    foreach (var item in nodes[val])
                        if (!seenbefore.Contains(item))
                        {
                            dfs.Push(item);
                            seenbefore.Add(item);
                        }
                }
            }
        }
        public void DoDFSRecursive(int startVertex, HashSet<int> visitedNodes)
        {
            if (startVertex < 0 || startVertex >= nodes.Length) return;
            Console.Write($"{startVertex}->");
            visitedNodes.Add(startVertex);
            if (nodes[startVertex].Count > 0)
            {
                foreach (var item in nodes[startVertex])
                {
                    if (!visitedNodes.Contains(item))
                        DoDFSRecursive(item, visitedNodes);
                }
            }

        }

        public void DoBFS(int startVertex)
        {
            if (startVertex < 0 || startVertex >= nodes.Length) return;
            Queue<int> bfs = new Queue<int>();
            bfs.Enqueue(startVertex);
            HashSet<int> visited = new HashSet<int>();
            while (bfs.Count > 0)
            {
                var val = bfs.Dequeue();
                Console.Write($"{val}->");
                visited.Add(val);
                if (nodes[val].Count > 0)
                {
                    foreach (var item in nodes[val])
                    {
                        if (!visited.Contains(item))
                        {
                            bfs.Enqueue(item);
                            visited.Add(item);
                        }

                    }
                }
            }
        }

        public void DoBFSRecursive(int startVertex, HashSet<int> visited)
        {
            if (startVertex < 0 || startVertex >= nodes.Length) return;
            Queue<int> bfs = new Queue<int>();
            bfs.Enqueue(startVertex);
            while (bfs.Count > 0)
            {
                Console.Write($"{startVertex}->");
                var val = bfs.Dequeue();
                if (!visited.Contains(val))
                    visited.Add(val);
                if (nodes[val].Count > 0)
                {
                    foreach (var item in nodes[val])
                    {
                        if (!visited.Contains(item))
                        {
                            visited.Add(item);
                            Console.Write($"{item}->");
                            DoBFSRecursive(item, visited);
                        }
                    }
                }
            }
        }
    }

    class GraphAdjacencyList
    {
        int numberofVertices;
        int[,] adjacencyMatrix;
        public GraphAdjacencyList(int vertices)
        {
            numberofVertices = vertices;
            adjacencyMatrix = new int[numberofVertices, numberofVertices];
        }

        public void AddEdge(int src, int trg)
        {
            if (src < numberofVertices && trg < numberofVertices && src >= 0 && trg >= 0)
            {
                adjacencyMatrix[src, trg] = 1;
                adjacencyMatrix[trg, src] = 1;
            }
        }
        public void DoDFS(int startVertex)
        {
            if (startVertex < 0 || startVertex >= numberofVertices) return;
            Stack<int> dfs = new Stack<int>();
            HashSet<int> seenbefore = new HashSet<int>();
            dfs.Push(startVertex);
            while (dfs.Count > 0)
            {
                int val = dfs.Pop();
                Console.Write($"{val}->");
                if (!seenbefore.Contains(val))
                    seenbefore.Add(val);
                for (int i = 0; i < numberofVertices; i++)
                {
                    if (adjacencyMatrix[val, i] == 1 && !seenbefore.Contains(i))
                    {
                        dfs.Push(i);
                        seenbefore.Add(i);
                    }
                }
            }
        }

        public void DoBFS(int startVertex)
        {
            if (startVertex < 0 || startVertex >= numberofVertices) return;
            Queue<int> bfs = new Queue<int>();
            bfs.Enqueue(startVertex);
            HashSet<int> visited = new HashSet<int>();
            while (bfs.Count > 0)
            {
                var val = bfs.Dequeue();
                Console.Write($"{val}->");
                visited.Add(val);
                for (int i = 0; i < numberofVertices; i++)
                {
                    if(adjacencyMatrix[val,i]==1 && !visited.Contains(i))
                    {
                        bfs.Enqueue(i);
                        visited.Add(i);
                    }
                }
            }
        }
    }
}
