using System.Collections.Generic;

namespace Chess.Model.Pieces
{
    public interface IPiece
    {
        //CanMove returns a bool representing the outcome of the move
        //If true: the move was legal
        //Se false: the move was not legal (e.g. there was a piece in between the starting and destination squares)
        //or the destination was not reachable by the piece (e.g. the player tried to move a rook diagonally)
        bool CanMove(
            File startingFile,
            Rank startingRank,
            File destinationFile,
            Rank destinationRank,
            IEnumerable<ISquare> squares = null);
        Color Color { get; }
        char Symbol { get; }
    }
}