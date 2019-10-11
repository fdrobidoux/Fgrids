using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using FGraph.v2;
using FGraph;

namespace NUnitTestFGraph
{
    /*
    public class V2Tests
    {
        Vertex<string> vertLA;
        Vertex<string> vertSF;
        Vertex<string> vertLV;
        Vertex<string> vertSE;
        Vertex<string> vertAU;
        Vertex<string> vertPO;
        Vertex<string> vertNY;

        UndirectedGenericGraph<string> testGraph;

        [SetUp]
        public void SetUp()
        {
            vertLA = new Vertex<string>("Los Angeles");
            vertSF = new Vertex<string>("San Francisco");
            vertLV = new Vertex<string>("Las Vegas");
            vertSE = new Vertex<string>("Seattle");
            vertAU = new Vertex<string>("Austin");
            vertPO = new Vertex<string>("Portland");
            vertNY = new Vertex<string>("New York");

            testGraph = new UndirectedGenericGraph<string>();

            // la <=> sf, lv, po
            testGraph.AddPair(vertLA, vertSF);
            testGraph.AddPair(vertLA, vertLV);
            testGraph.AddPair(vertLA, vertPO);

            // sf <=> se, po
            testGraph.AddPair(vertSF, vertSE);
            testGraph.AddPair(vertSF, vertPO);
            testGraph.AddPair(vertSF, vertNY);

            // lv <=> au
            testGraph.AddPair(vertLV, vertAU);

            // se <=> po
            testGraph.AddPair(vertSE, vertPO);
        }

        [Test][Order(0)]
        public void CheckVertices()
        {
            Assert.IsNotEmpty(testGraph.Vertices);

            // Los Angeles
            Assert.Contains(vertLA, testGraph.Vertices);
            Assert.Contains(vertSF, vertLA.Neighbors);
            Assert.Contains(vertLV, vertLA.Neighbors);
            Assert.Contains(vertPO, vertLA.Neighbors);

            // San Francisco
            Assert.Contains(vertSF, testGraph.Vertices);
            Assert.Contains(vertSE, vertSF.Neighbors);
            Assert.Contains(vertPO, vertSF.Neighbors);
            Assert.Contains(vertLA, vertSF.Neighbors);

            // Las Vegas
            Assert.Contains(vertLV, testGraph.Vertices);
            Assert.Contains(vertAU, vertLV.Neighbors);
            Assert.Contains(vertLA, vertLV.Neighbors);

            // Seattle
            Assert.Contains(vertSE, testGraph.Vertices);
            Assert.Contains(vertPO, vertSE.Neighbors);
            Assert.Contains(vertSF, vertSE.Neighbors);

            // Austin
            Assert.Contains(vertAU, testGraph.Vertices);
            Assert.Contains(vertLV, vertAU.Neighbors);

            // Portland
            Assert.Contains(vertPO, testGraph.Vertices);
            Assert.Contains(vertSF, vertPO.Neighbors);
            Assert.Contains(vertSE, vertPO.Neighbors);
            Assert.Contains(vertLA, vertPO.Neighbors);

            // Test searching algorithms
            testGraph.DepthFirstSearch(vertLA, (m) => System.Diagnostics.Debug.WriteLine(m));

            return;
        }
    }
    */
}
