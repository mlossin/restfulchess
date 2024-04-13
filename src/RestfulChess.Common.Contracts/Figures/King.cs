using System;
using System.Collections.Generic;
using System.Text;
using RestfulChess.Common.Contracts.Enumerations;

namespace RestfulChess.Common.Contracts.Figures
{
    /// <summary>
    /// Chess figure for straight and diagonal movement of one field
    /// </summary>
    public class King : ChessFigure
    {
        private int _baseValue = int.MaxValue;
        public override FigureType GetFigureType()
        {
            return FigureType.King;
        }
    }
}
