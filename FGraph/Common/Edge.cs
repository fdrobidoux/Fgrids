using System;
using System.Collections;
using System.Dynamic;

namespace FGraph.Common
{
    public class Edge
    {
        public Node FirstNode { get => Nodes[0]; set => Nodes[0] = value; }
        public Node SecondNode { get => Nodes[1]; set => Nodes[1] = value; }

        public Node[] Nodes { get; protected set; } = new Node[2];

        public Edge() { }

        public Edge(Node first, Node second)
        {
            FirstNode = first;
            SecondNode = second;
        }

        public Edge Fill(Node node)
        {
            if (FirstNode == null)
                FirstNode = node;
            else if (SecondNode == null)
                SecondNode = node;
            else
                throw new MethodAccessException("Can't fill up nodes for an edge if it is full.");
            return this;
        }
        

    }
}