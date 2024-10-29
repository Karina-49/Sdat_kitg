using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Алгоритм_Краскала
{
    public class Edge : IComparable<Edge>
    {
        public int Start { get; }
        public int End { get; }
        public int Weight { get; }

        public Edge(int start, int end, int weight)
        {
            Start = start;
            End = end;
            Weight = weight;
        }

        // Реализация метода для сравнения рёбер по весу
        public int CompareTo(Edge other)
        {
            return Weight.CompareTo(other.Weight);
        }
    }

}
