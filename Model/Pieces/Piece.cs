using System;
using System.Collections.Generic;

namespace Chess.Model.Pieces
{
    public abstract class Piece : IPiece
    {
        public Piece(Color color)
        {
            Color = color;
        }

        public abstract char Symbol {get;}
        private Color color;
        public Color Color
        {
            get
            {
                return color;
            }
            private set
            {
                color = value;
            }
        }

        public override string ToString() {
            return $"{Symbol} {GetType().Name} {Color}";
        }
        public virtual bool CanMove(File startingFile, Rank startingRank, File destinationFile, Rank destinationRank, IEnumerable<ISquare> squares = null)
        {
            return true;
        }
    }
}