using RestfulChess.Common.Contracts.Figures;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestfulChess.Common.Contracts.Games
{
    /// <summary>
    /// A container for the chess figures of a player sorted by its type
    /// </summary>
    public class FigureBox
    {
        public IList<ChessFigure> Figures { get; set; }
        public IList<King> Kings { get; set; }
        public IList<Queen> Queens { get; set; }
        public IList<Bishop> Bishops { get; set; }
        public IList<Knight> Knights { get; set; }
        public IList<Rook> Rooks { get; set; }
        public IList<Pawn> Pawns { get; set; }

    }
}
