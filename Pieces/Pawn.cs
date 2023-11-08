public class Pawn : Piece {
    bool hasMoved;

    public Pawn(Vector2 pos, PieceColor color) : base(PieceType.Pawn, pos, color) {
        hasMoved = false;
    }

    public void getLegalMoves(Piece[][] board) {
        Debug.Log("test");
    }
}

