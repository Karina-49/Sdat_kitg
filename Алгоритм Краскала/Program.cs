using Алгоритм_Краскала;

public class Program
{
    public static void Main(string[] args)
    {
        // Создание графа с 4 вершинами
        Graph graph = new Graph(4);

        // Добавление рёбер
        graph.AddEdge(0, 1, 10);
        graph.AddEdge(0, 2, 6);
        graph.AddEdge(0, 3, 5);
        graph.AddEdge(1, 3, 15);
        graph.AddEdge(2, 3, 4);

        KruskalAlgorithm kruskal = new KruskalAlgorithm(graph.VerticesCount);
        List<Edge> minimumSpanningTree = kruskal.FindMinimumSpanningTree(graph);

        Console.WriteLine("Рёбра минимального остовного дерева:");
        foreach (Edge edge in minimumSpanningTree)
        {
            Console.WriteLine($"({edge.Start}, {edge.End}) - вес {edge.Weight}");
        }
    }
}
