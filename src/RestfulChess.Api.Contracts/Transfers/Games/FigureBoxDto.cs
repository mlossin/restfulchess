using RestfulChess.Common.Contracts.Figures;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestfulChess.Common.Contracts.Games
{
    /// <summary>
    /// A container for the chess figures of a player sorted by its type
    /// </summary>
    public class FigureBoxDto
    {
        public IList<ChessFigureDto> Figures { get; set; }
        public IList<KingDto> Kings { get; set; }
        public IList<QueenDto> Queens { get; set; }
        public IList<BishopDto> Bishops { get; set; }
        public IList<KnightDto> Knights { get; set; }
        public IList<RookDto> Rooks { get; set; }
        public IList<PawnDto> Pawns { get; set; }

    }
}
