namespace TicTacToe;

public class Board
{
    public Wert A1
    {
        get;
        set
        {
            field = value;
            WertGeändert();
        }
    } = Wert.Leer;

    public Wert B1
    {
        get;
        set
        {
            field = value;
            WertGeändert();
        }
    } = Wert.Leer;

    public Wert C1
    {
        get;
        set => field = value;
    } = Wert.Leer;

    public Wert A2
    {
        get;
        set
        {
            field = value;
            WertGeändert();
        }
    } = Wert.Leer;

    public Wert B2
    {
        get;
        set
        {
            field = value;
            WertGeändert();
        }
    } = Wert.Leer;

    public Wert C2
    {
        get;
        set
        {
            field = value;
            WertGeändert();
        }
    } = Wert.Leer;

    public Wert A3
    {
        get;
        set
        {
            field = value;
            WertGeändert();
        }
    } = Wert.Leer;

    public Wert B3
    {
        get;
        set
        {
            field = value;
            WertGeändert();
        }
    } = Wert.Leer;

    public Wert C3
    {
        get;
        set
        {
            field = value;
            WertGeändert();
        }
    } = Wert.Leer;

    private void WertGeändert()
    {
        Print();
        PrüfeSieger(Wert.X);
        PrüfeSieger(Wert.O);
    }

    private void PrüfeSieger(Wert wert)
    {
        if (A1 == wert && A2 == wert && A3 == wert)
        {
            Console.WriteLine();
            Console.WriteLine($"Sieger: {wert} ☺️");
        }

        if (B1 == wert && B2 == wert && B3 == wert)
        {
            Console.WriteLine();
            Console.WriteLine($"Sieger: {wert} ☺️");
        }

        if (C1 == wert && C2 == wert && C3 == wert)
        {
            Console.WriteLine();
            Console.WriteLine($"Sieger: {wert} ☺️");
        }

        if (A1 == wert && B1 == wert && C1 == wert)
        {
            Console.WriteLine();
            Console.WriteLine($"Sieger: {wert} ☺️");
        }

        if (A2 == wert && B2 == wert && C2 == wert)
        {
            Console.WriteLine();
            Console.WriteLine($"Sieger: {wert} ☺️");
        }

        if (A3 == wert && B3 == wert && C3 == wert)
        {
            Console.WriteLine();
            Console.WriteLine($"Sieger: {wert} ☺️");
        }

        if (A1 == wert && B2 == wert && C3 == wert)
        {
            Console.WriteLine();
            Console.WriteLine($"Sieger: {wert} ☺️");
        }

        if (A3 == wert && B2 == wert && C1 == wert)
        {
            Console.WriteLine();
            Console.WriteLine($"Sieger: {wert} ☺️");
        }
    }

    private void Print()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("    A   B   C  ");
        Console.WriteLine("  -------------");
        Console.WriteLine($"1 | {GetChar(A1)} | {GetChar(B1)} | {GetChar(C1)} |");
        Console.WriteLine("  -------------");
        Console.WriteLine($"2 | {GetChar(A2)} | {GetChar(B2)} | {GetChar(C2)} |");
        Console.WriteLine("  -------------");
        Console.WriteLine($"3 | {GetChar(A3)} | {GetChar(B3)} | {GetChar(C3)} |");
        Console.WriteLine("  -------------");
    }

    private static char GetChar(Wert wert)
    {
        if (wert == Wert.X)
        {
            return 'X';
        }

        if (wert == Wert.O)
        {
            return 'O';
        }

        return ' ';
    }
}