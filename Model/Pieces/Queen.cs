using System;
using System.Collections.Generic;
using System.Linq;

namespace Chess.Model.Pieces
{
    public class Queen : Piece
    {
        public Queen(Color color) : base(color)
        {
        }

        public override char Symbol {
            get {
                return Color == Color.White ? '♛' : '♕';
            }
        }
        public override bool CanMove(
            File startingFile,
            Rank startingRank,
            File destinationFile,
            Rank destinationRank,
            IEnumerable<ISquare> squares = null)
        {
            return true;
        }
    }
}