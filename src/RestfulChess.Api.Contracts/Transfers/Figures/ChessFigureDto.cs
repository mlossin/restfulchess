﻿using RestfulChess.Common.Contracts.Enumerations;
using RestfulChess.Common.Contracts.Games;
using System.Runtime.Serialization;

namespace RestfulChess.Common.Contracts.Figures
{
    /// <summary>
    /// Base class for all chess figures
    /// </summary>
    [KnownType(typeof(KingDto))]
    [KnownType(typeof(QueenDto))]
    [KnownType(typeof(BishopDto))]
    [KnownType(typeof(RookDto))]
    [KnownType(typeof(KnightDto))]
    [KnownType(typeof(PawnDto))]
    public abstract class ChessFigureDto
    {
        public abstract FigureType FigureType { get; }

        public EPlayerColors Color { get; set; }

        /// <summary>
        /// Position of the figure. Null means not on the board!
        /// </summary>
        public BoardPosition Position { get; set; }
    }
}
