public class King : Piece {
    bool hasMoved;

    public King(Vector2 pos, PieceColor color) : base(PieceType.King, pos, color) {
        hasMoved = false;
    }

    public void getLegalMoves(Piece[][] board) {
        Debug.Log("test");
    }
}

