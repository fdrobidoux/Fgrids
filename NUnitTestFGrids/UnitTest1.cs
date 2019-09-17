using NUnit.Framework;
using FGraph;
using FGraph.Common;
using System.Linq;
using NUnitTestFGraph.Visual;
using System.Collections.Generic;

namespace NUnitTestFGraph
{
    public class UnitTest1
    {
        VisualGraph graph;
        TextNode A;
        TextNode B;
        TextNode C;

        [SetUp]
        public void Setup()
        {
            graph = new VisualGraph();

            graph.AddNode(new TextNode(graph, "A"))
                .AssignTo(new TextNode(graph, "B"))
                .AssignTo(new TextNode(graph, "C")
                    .CreateLink().FirstNode)
                .AssignTo(new TextNode(graph, "D")
                    .AssignTo(new TextNode(graph, "E")));

        }

        //[Test]
        //[Order(0)]
        //public void Nodes_Are_At_The_Right_Place()
        //{
        //    A = graph.AllNodes.OfType<TextNode>().First();
        //    Assert.AreEqual("A", A.Text, "First one is A.");

        //    B = A.GetNeighbors().OfType<TextNode>().First();
        //    Assert.AreEqual("B", B.Text, "A is linked with B.");
        //    Assert.IsNotEmpty(A.AllLinks, "A has one link created.");
        //    Assert.IsEmpty(A.GetNeighborlessLinksSync(), "No neighborless links for A");

        //    C = B.GetNeighborsSync().OfType<TextNode>().First(x => x.Text == "C");
        //    Assert.IsNotNull(C, "C exists as a neighbor of B.");
        //}

        [Test]
        [Order(1)]
        public void Test_Instances_Of_Graph_Are_Assigned_To_Everything()
        {
            foreach (TextNode node in graph.AllNodes)
            {
                Assert.IsNotNull(node._graph, "Node {0} has _graph assigned.", node.Text);
            }

            foreach (Link link in graph.AllLinks)
            {
                Assert.IsNotNull(link._graph, "Link {0} to {1} has _graph assigned.", link.FirstNode, link.SecondNode);
            }
        }
    }
}