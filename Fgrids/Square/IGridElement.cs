using Fgrids.Common;
using System;

namespace Fgrids.Square
{
    public interface IGridElement : IDisposable
    {
        int X { get; set; }
        int Y { get; set; }

        IGridElement[] Neighbors { get; }

        IGridElement NeighborAt(PoleOrientation direction);

        IGridElement NeighborAtDiff(int diffX, int diffY);
    }
}