using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Алгоритм_Краскала
{
    public class Graph
    {
        public List<Edge> Edges { get; } = new List<Edge>();
        public int VerticesCount { get; }

        public Graph(int verticesCount)
        {
            VerticesCount = verticesCount;
        }

        public void AddEdge(int start, int end, int weight)
        {
            Edges.Add(new Edge(start, end, weight));
        }
    }

}
