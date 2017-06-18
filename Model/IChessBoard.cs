using System;
using System.Collections.Generic;

namespace Chess.Model
{
    public interface IChessBoard
    {
        IEnumerable<ISquare> Squares { get; }
        ISquare this[File file, Rank rank] { get; }
    }
}