using System;
using System.Collections.Generic;
using System.Text;

namespace RestfulChess.Common.Contracts.Exceptions
{
    /// <summary>
    /// Exception pointing out an illegal movement
    /// </summary>
    public class MovementException : ChessException
    {
        public MovementException() : base() { }
        public MovementException(string message) : base(message) { }
        public MovementException(string message, Exception innerException) : base(message,innerException){ }
    }
}
