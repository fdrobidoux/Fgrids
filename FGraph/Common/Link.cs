using System;
using System.Collections;

namespace FGraph.Common
{
    [System.Diagnostics.DebuggerDisplay("{FirstNode} -> {SecondNode}")]
    public class Link : BaseGraphMember
    {

        public Node FirstNode { get => Nodes[0]; internal set => Nodes[0] = value; }
        public Node SecondNode { get => Nodes[1]; internal set => Nodes[1] = value; }

        public Node[] Nodes { get; protected set; } = new Node[2];

        public Link(Graph graph) : base(graph)
        {
            _graph.AddLink(this);
        }

        public Link(Graph graph, Node singleNode) : this(graph)
        {
            FirstNode = singleNode;
        }

        public Link(Graph graph, Node first, Node second) : this(graph, first)
        {
            FirstNode = first;
            SecondNode = second;
        }

        public Link Fill(Node node)
        {
            if (FirstNode == null)
                FirstNode = node;
            else if (SecondNode == null)
                SecondNode = node;
            else
                throw new IndexOutOfRangeException("Can't fill up nodes for an edge if it is full.");
            return this;
        }

        public Node OppositeNodeOf(Node node)
        {
            if (FirstNode == node)
            {
                return SecondNode;
            }
            else if (SecondNode == node)
            {
                return FirstNode;
            }
            return null;
        }
    }
}
