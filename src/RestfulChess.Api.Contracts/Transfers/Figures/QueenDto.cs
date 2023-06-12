using System;
using System.Collections.Generic;
using System.Text;

namespace RestfulChess.Common.Contracts.Figures
{
    /// <summary>
    /// Chess figure for straight and diagonal movement of multiple fields
    /// </summary>
    public class QueenDto : ChessFigureDto
    {
        private int _baseValue = 15;
    }
}
