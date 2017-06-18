using System;
using System.Collections.Generic;
using System.Linq;

namespace Chess.Model.Pieces {
    public class Rook : Piece
    {
        public override char Symbol {
            get {
                return Color == Color.White ? '♜' : '♖';
            }
        }
        public Rook(Color color) : base(color)
        {
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