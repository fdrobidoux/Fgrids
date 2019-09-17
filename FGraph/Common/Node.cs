using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace FGraph.Common
{
    [System.Diagnostics.DebuggerDisplay("Node ({GetHashCode()})")]
    public abstract class Node : BaseGraphMember
    {
        protected List<Link> Links { get; set; } = new List<Link>();

        public IReadOnlyList<Link> AllLinks => Links;

        public Node(Graph graph) : base(graph)
        {
            _graph.AddNode(this);
        }

        public IEnumerable<Node> GetNeighbors()
        {
            foreach (var link in Links)
            {
                if (link.FirstNode == this)
                {
                    if (link.SecondNode != null)
                        yield return link.SecondNode;
                }
                else if (link.SecondNode == this)
                {
                    if (link.FirstNode != null)
                        yield return link.FirstNode;
                }
            }
            yield break;
        }

        public List<Node> GetNeighborsSync()
        {
            List<Node> neighbors = new List<Node>();

            foreach (var link in Links)
            {
                if (link.FirstNode == this)
                {
                    if (link.SecondNode != null)
                    {
                        neighbors.Add(link.SecondNode);
                    }
                }
                else if (link.SecondNode == this)
                {
                    if (link.FirstNode != null)
                    {
                        neighbors.Add(link.FirstNode);
                    }
                }
            }

            return neighbors;
        }

        internal Node AssignTo(Link link)
        {
            Links.Add(link);
            link.Fill(this);

            return this;
        }

        /// <summary>
        /// Assigns the node with this one, allowing to indent calls within the hierarchy.
        /// </summary>
        /// <param name="node"></param>
        /// <returns>The parameter node.</returns>
        internal Node AssignTo(Node node)
        {
            this.CreateLink().Fill(node);
            return node;
        }

        internal Link CreateLink()
        {
            Link nouvLink = new Link(_graph);
            this.AssignTo(nouvLink);
            return nouvLink;
        }

        public IEnumerable<Link> GetNeighborlessLinks()
        {
            foreach (var link in Links)
            {
                if (link.OppositeNodeOf(this) == null)
                {
                    yield return link;
                }
            }
            yield break;
        }

        public List<Link> GetNeighborlessLinksSync()
        {
            List<Link> linkList = new List<Link>();

            foreach (var link in Links)
            {
                if (link.OppositeNodeOf(this) == null)
                {
                    linkList.Add(link);
                }
            }

            return linkList;
        }
    }
}
