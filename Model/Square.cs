using System;
using Chess.Model.Pieces;

namespace Chess.Model
{
    public class Square : ISquare
    {
        private File file;
        private Rank rank;
        public Square(File file, Rank rank)
        {
            this.file = file;
            this.rank = rank;
        }


        public File File
        {
            get { return file; }
        }

        public Rank Rank
        {
            get { return rank; }
        }

        private IPiece piece;
        public IPiece Piece
        {
            get
            {
                return piece;
            }
            set
            {
                piece = value;
            }
        }
    }
}