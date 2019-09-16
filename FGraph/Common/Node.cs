using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace FGraph.Common
{
    [System.Diagnostics.DebuggerDisplay("Node ({GetHashCode()})")]
    public abstract class Node
    {
        internal Graph _graph;

        protected List<Link> Links { get; set; } = new List<Link>();

        public ExpandoObject Data { get; protected set; } = new ExpandoObject();

        public IReadOnlyList<Link> AllLinks => Links;

        public Node()
        {
            // TODO: Add init stuff.
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
                else yield return null;
            }
            yield break;
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
            Link anEdge = new Link();
            this.AssignTo(anEdge);
            return anEdge;
        }

        public IEnumerable<Link> GetNeighborlessLinks()
        {
            foreach (var link in Links)
            {
                var opposite = link.OppositeNodeOf(this);
                if (opposite == null)
                {
                    yield return link;
                }
            }
            yield break;
        }
    }
}
