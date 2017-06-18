using Chess.Model.Pieces;

namespace Chess.Model
{
    public interface ISquare
    {
        File File {get;}
        Rank Rank {get;}
        IPiece Piece {get;set;}
    }
}