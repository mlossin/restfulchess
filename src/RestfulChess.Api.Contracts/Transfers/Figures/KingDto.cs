using System;
using System.Collections.Generic;
using System.Text;

namespace RestfulChess.Common.Contracts.Figures
{
    /// <summary>
    /// Chess figure for straight and diagonal movement of one field
    /// </summary>
    public class KingDto : ChessFigureDto
    {
        private int _baseValue = int.MaxValue;
    }
}
