using System;
using System.Collections.Generic;
using System.Dynamic;

namespace FGraph.Common
{
    public class Node
    {
        protected Graph _graph;

        public List<Edge> Edges { get; protected set; } = new List<Edge>();

        public ExpandoObject Data { get; protected set; } = new ExpandoObject();

        public Node()
        {
            
        }

        internal Node AssignTo(Edge edge)
        {
            Edges.Add(edge);
            edge.Fill(this);

            return this;
        }
    }
}
