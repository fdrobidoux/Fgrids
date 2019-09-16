using NUnit.Framework;
using FGraph;
using FGraph.Common;
using System.Linq;
using NUnitTestFGraph.Visual;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        Graph graph;

        [SetUp]
        public void Setup()
        {
            graph = new Graph();

            graph.AddNode(new TextNode("A"))
                .AssignTo(new TextNode("B"))
                .AssignTo(new TextNode("C")
                    .CreateLink().FirstNode)
                .AssignTo(new TextNode("D")
                    .AssignTo(new TextNode("E")));

        }

        [Test]
        public void Test_NodesAreAtTheRightPlace()
        {
            Node A = graph.AllNodes.First();
            Assert.AreEqual("A", (A as TextNode).Text, "First one is A.");

            Node B = A.GetNeighbors().ToList()[0];
            Assert.AreEqual("B", (B as TextNode).Text, "A is linked with B.");

            Assert.IsNotEmpty(A.AllLinks, "A has one link created.");
            Assert.IsEmpty(A.GetNeighborlessLinks(), "No neighborless links for A");
        }

        [Test]
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