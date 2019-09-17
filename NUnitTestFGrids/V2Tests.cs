using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using FGraph.v2;
using FGraph;

namespace NUnitTestFGraph
{
    public class V2Tests
    {


        [SetUp]
        public void SetUp()
        {

        }

        [Test][Order(0)]
        public void CheckVertices()
        {
            var la = new Vertex<string>("Los Angeles");
            var sf = new Vertex<string>("San Francisco");
            var lv = new Vertex<string>("Las Vegas");
            var se = new Vertex<string>("Seattle");
            var au = new Vertex<string>("Austin");
            var po = new Vertex<string>("Portland");

            var testGraph = new UndirectedGenericGraph<string>();

            // la <=> sf, lv, po
            testGraph.AddPair(la, sf);
            testGraph.AddPair(la, lv);
            testGraph.AddPair(la, po);

            // sf <=> se, po
            testGraph.AddPair(sf, se);
            testGraph.AddPair(sf, po);

            // lv <=> au
            testGraph.AddPair(lv, au);

            // se <=> po
            testGraph.AddPair(se, po);

            // Check to see that all neighbors are properly set up
            foreach (var vertex in testGraph.Vertices)
            {
                System.Diagnostics.Debug.WriteLine(vertex.ToString());
            }

            // Test searching algorithms
            testGraph.DepthFirstSearch(la, (m) => System.Diagnostics.Debug.WriteLine(m));

            return;
        }

    }
}
