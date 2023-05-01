using UnityEngine;

public enum PieceTypes
{
    Deborah = 0,
    Elisha = 1,
    Lamb = 2,
    Andrew = 3,
    Hannah = 4
}

public class Piece
{
    // This script will manage the state of a single
    // piece in the grid.

    private Vector3 position;
    private Vector2 gridPosition;
    private PieceTypes pieceType;
    private bool setForDestruction;

    public Piece()
    {
        position = Vector3.zero;
        gridPosition = Vector2.zero;
        pieceType = PieceTypes.Andrew;
        setForDestruction = false;
    }

    public Piece(Vector3 position, Vector2 gridPosition)
    {
        this.position = position;
        this.gridPosition = gridPosition;
        this.pieceType = PieceTypes.Andrew;
        this.setForDestruction = false;
    }

    public Piece(Vector3 position, Vector2 gridPosition, PieceTypes pieceType)
    {
        this.position = position;
        this.gridPosition = gridPosition;
        this.pieceType = pieceType;
        this.setForDestruction = false;
    }

    public void SetForDestruction()
    {
        this.setForDestruction = true;
    }

    public void SetPieceType(PieceTypes pieceType)
    {
        this.pieceType = pieceType;
    }

    public void SetGridPosition(Vector2 position)
    {
        this.gridPosition = position;
    }

    public Vector3 GetPosition()
    {
        return position;
    }

    public Vector3 GetGridPosition()
    {
        return gridPosition;
    }

    public PieceTypes GetPieceType()
    {
        return pieceType;
    }

    public bool GetDestruction()
    {
        return setForDestruction;
    }
}
