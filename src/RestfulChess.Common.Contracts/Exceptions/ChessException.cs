using System;
using System.Collections.Generic;
using System.Text;

namespace RestfulChess.Common.Contracts.Exceptions
{
    /// <summary>
    /// General Exception of the Chess Game
    /// </summary>
    public class ChessException : Exception
    {
        public ChessException(): base() { }
        public ChessException(string message) : base (message) { }

        public ChessException(string message, Exception innerException) : base(message, innerException)  { }
    }
}
