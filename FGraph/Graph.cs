using System;
using System.Collections.Generic;
using FGraph.Common;

namespace FGraph
{
    public class Graph
    {
        protected List<Node> Nodes { get; set; } = new List<Node>();

        protected List<Link> Edges { get; set; } = new List<Link>();

        public IReadOnlyList<Node> AllNodes => Nodes;
        public IReadOnlyList<Link> AllLinks => Edges;

        public Graph()
        {
            
        }

        public Node AddNode(Node node)
        {
            Nodes.Add(node);
            node._graph = this;
            return node;
        }

        public void Link(Node node1, Node node2)
        {
            
        }
    }
}
