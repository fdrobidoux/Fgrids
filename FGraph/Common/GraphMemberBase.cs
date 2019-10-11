using System;
using System.Collections.Generic;
using System.Text;

namespace FGraph.Common
{
    public abstract class BaseGraphMember : IDisposable
    {
        internal Graph _graph;
        protected BaseGraphMember()
        {
            
        }

        #region IDisposable Support

        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // Dispose managed state (managed objects).
                    _graph = null;
                }

                // TODO: set large fields to null.
                disposedValue = true;
            }
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose() => Dispose(true);

        #endregion
    }
}
