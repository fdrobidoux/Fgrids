using NUnit.Framework;
using FGraph;
using FGraph.Common;

namespace Tests
{
    public class Tests
    {
        Graph graph;

        [SetUp]
        public void Setup()
        {
            graph = new Graph();

            graph.InitializeWith(new Node());



        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}