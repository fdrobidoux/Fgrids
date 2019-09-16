using System;
using System.Collections.Generic;
using System.Text;
using Fgrids.Common;

namespace Fgrids.Square
{
    public class Edge : IEdge
    {
        public AxisDirection Direction { get; protected set; }

        public Vector2 CoordonneeSource => throw new NotImplementedException();

        public int X { get; set; }
        public int Y { get; set; }

        public IGridElement[] Neighbors => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IGridElement NeighborAt(PoleOrientation direction)
        {
            throw new NotImplementedException();
        }

        public IGridElement NeighborAtDiff(int diffX, int diffY)
        {
            throw new NotImplementedException();
        }
    }
}
