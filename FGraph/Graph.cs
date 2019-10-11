using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FGraph.Common;

namespace FGraph
{
    public class Graph
    {
        protected HashSet<Node> Nodes { get; set; }
        protected HashSet<Link> Links { get; set; }

        public IEnumerable<Node> AllNodes => Nodes.AsEnumerable();
        public IEnumerable<Link> AllLinks => Links.AsEnumerable();

        public Graph()
        {
            Nodes = new HashSet<Node>();
            Links = new HashSet<Link>();
        }

        public Node AddNode(Node node)
        {
            if (!Nodes.Contains(node))
            {
                Nodes.Add(node);
                node._graph = this;
            }
            return node;
        }

        internal void AddLink(Link link)
        {
            Links.Add(link);
            link._graph = this;
        }

        public void LinkTogether(Node node1, Node node2)
        {
            List<Link> noNeighborLinks = node1.GetNeighborlessLinks().ToList();
            if (noNeighborLinks.Count > 0)
            {
                noNeighborLinks[0].Fill(node2);
            }
            else
            {
                noNeighborLinks = node2.GetNeighborlessLinksSync();
                if (noNeighborLinks.Count > 0)
                {
                    noNeighborLinks[0].Fill(node1);
                }
                else
                {
                    node1.CreateLink().Fill(node2);
                }
            }
        }
    }
}
