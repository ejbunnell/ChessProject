
public class Piece {
    public static enum PieceType {
        Pawn,
        Bishop,
        Knight,
        Rook,
        Queen,
        King
    }
    
    public static enum PieceColor {
        White,
        Black
    }

    PieceType type;
    Vector2 pos;
    PieceColor color;
    GameObject object;

    public Piece(PieceType type, Vector2 pos, PieceColor color) {
        this.type = type;
        this.pos = pos;
        this.color = color;
        object = new GameObject();
        
    }

    private string getSpriteName() {
        return color + type;
    }
}

public class Pawn : Piece {
    bool hasMoved;

    public Pawn(Vector2 pos, PieceColor color) : base(PieceType.Pawn, pos, color) {
        hasMoved = false;
    }

    public void getLegalMoves(Piece[][] board) {
        Debug.Log("test");
    }
}

