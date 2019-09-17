using System;
using System.Collections.Generic;
using FGraph.Common;

namespace FGraph
{
    public class Graph
    {
        protected List<Node> Nodes { get; set; }
        protected List<Link> Links { get; set; }

        public IReadOnlyList<Node> AllNodes => Nodes;
        public IReadOnlyList<Link> AllLinks => Links;

        public Graph()
        {
            Nodes = new List<Node>();
            Links = new List<Link>();
        }

        public Node AddNode(Node node)
        {
            Nodes.Add(node);
            return node;
        }

        internal void AddLink(Link link)
        {
            Links.Add(link);
        }

        public void LinkTogether(Node node1, Node node2)
        {
            node1.GetNeighborlessLinksSync();
        }
    }
}
