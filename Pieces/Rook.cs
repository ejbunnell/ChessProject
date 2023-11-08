public class Rook : Piece {
    bool hasMoved;

    public Rook(Vector2 pos, PieceColor color) : base(PieceType.Rook, pos, color) {
        hasMoved = false;
    }

    public void getLegalMoves(Piece[][] board) {
        Debug.Log("test");
    }
}

