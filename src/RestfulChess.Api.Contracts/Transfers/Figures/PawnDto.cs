﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RestfulChess.Common.Contracts.Figures
{
    /// <summary>
    /// Chess figure forward only movement of a field with some exceptions
    /// </summary>
    public class PawnDto : ChessFigure
    {
        private int _baseValue = 1;
    }
}
