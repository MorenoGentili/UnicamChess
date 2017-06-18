using System;
using System.Collections.Generic;
using System.Linq;
using Chess.Model.Pieces;

namespace Chess.Model
{
    public class ChessBoard : IChessBoard
    {
        private ISquare[] squares;

    

        public ChessBoard()
        {
            squares = Enumerable.Range(0, 64)
            .Select(i => CreateSquare(i))
            .ToArray();
        }

        internal ISquare CreateSquare(int i)
        {
            File file = (File)(i % 8 + 1);
            Rank rank = (Rank)(i / 8 + 1);
            ISquare square = new Square(file, rank);

            return square;
        }

        public IEnumerable<ISquare> Squares
        {
            get
            {
                return squares;
            }
        }

        public ISquare this[File file, Rank rank]
        {
            get
            {
                return squares[(int)file - 1 + (((int)rank - 1) * 8)];
            }
            set {
                squares[(int)file - 1 + (((int)rank - 1) * 8)] = value;
            }
        }

    }
}