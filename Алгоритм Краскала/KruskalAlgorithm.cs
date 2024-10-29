using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Алгоритм_Краскала
{
    public class KruskalAlgorithm
    {
        private int[] parent;
        private int[] rank;

        public KruskalAlgorithm(int verticesCount)
        {
            parent = new int[verticesCount];
            rank = new int[verticesCount];

            // Инициализация Union-Find
            for (int i = 0; i < verticesCount; i++)
            {
                parent[i] = i;
                rank[i] = 0;
            }
        }

        // Метод для поиска корня с путевым сжатием
        private int Find(int node)
        {
            if (parent[node] != node)
            {
                parent[node] = Find(parent[node]);
            }
            return parent[node];
        }

        // Метод для объединения двух множеств
        private void Union(int root1, int root2)
        {
            if (rank[root1] < rank[root2])
            {
                parent[root1] = root2;
            }
            else if (rank[root1] > rank[root2])
            {
                parent[root2] = root1;
            }
            else
            {
                parent[root2] = root1;
                rank[root1]++;
            }
        }

        public List<Edge> FindMinimumSpanningTree(Graph graph)
        {
            List<Edge> result = new List<Edge>();

            // Сортировка рёбер по возрастанию веса
            graph.Edges.Sort();

            foreach (Edge edge in graph.Edges)
            {
                int root1 = Find(edge.Start);
                int root2 = Find(edge.End);

                // Если вершины принадлежат разным множествам, добавляем ребро в остовное дерево
                if (root1 != root2)
                {
                    result.Add(edge);
                    Union(root1, root2);
                }
            }

            return result;
        }
    }

}
