using System;
using System.Collections.Generic;
using FGraph.Common;

namespace FGraph
{
    public class Graph
    {
        protected List<Node> Nodes { get; set; } = new List<Node>();

        protected List<Edge> Edges { get; set; } = new List<Edge>();

        public IReadOnlyList<Node> AllNodes => Nodes;
        public IReadOnlyList<Edge> AllEdges => Edges;

        public Graph()
        {
            
        }

        public void InitializeWith(Node node)
        {
            Nodes.Add(node);
        }
    }
}
