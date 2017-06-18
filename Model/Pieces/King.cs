using System;
using System.Collections.Generic;

namespace Chess.Model.Pieces {
    public class King : Piece
    {
        public King(Color color) : base(color)
        {    
        }
        public override char Symbol {
            get {
                return Color == Color.White ?  '♚' : '♔';
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