namespace TicTacToe.Material;

public static class SiegerPrüfung
{
    public static Wert? PrüfeSieger(Board board)
    {
        if (PrüfeSieger(board, Wert.X))
        {
            return Wert.X;
        }

        if (PrüfeSieger(board, Wert.O))
        {
            return Wert.O;
        }

        return null;
    }
    
    private static bool PrüfeSieger(Board board, Wert wert)
    {
        if (board.Felder[Feld.A1] == wert && board.Felder[Feld.A2] == wert && board.Felder[Feld.A3] == wert)
        {
            return true;
        }

        if (board.Felder[Feld.B1] == wert && board.Felder[Feld.B2] == wert && board.Felder[Feld.B3] == wert)
        {
            return true;
        }

        if (board.Felder[Feld.C1] == wert && board.Felder[Feld.C2] == wert && board.Felder[Feld.C3] == wert)
        {
            return true;
        }

        if (board.Felder[Feld.A1] == wert && board.Felder[Feld.B1] == wert && board.Felder[Feld.C1] == wert)
        {
            return true;
        }

        if (board.Felder[Feld.A2] == wert && board.Felder[Feld.B2] == wert && board.Felder[Feld.C2] == wert)
        {
            return true;
        }

        if (board.Felder[Feld.A3] == wert && board.Felder[Feld.B3] == wert && board.Felder[Feld.C3] == wert)
        {
            return true;
        }

        if (board.Felder[Feld.A1] == wert && board.Felder[Feld.B2] == wert && board.Felder[Feld.C3] == wert)
        {
            return true;
        }

        if (board.Felder[Feld.A3] == wert && board.Felder[Feld.B2] == wert && board.Felder[Feld.C1] == wert)
        {
            return true;
        }

        return false;
    }
}