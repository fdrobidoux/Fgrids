using Fgrids.Common;

namespace Fgrids.Square
{
    public interface IEdge : IGridElement
    {
        AxisDirection Direction { get; }

        Vector2 CoordonneeSource { get; }


    }
}