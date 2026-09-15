using TicTacToe.GamePlay.Players;
using TicTacToe.Material;

namespace TicTacToe.GamePlay;

public class Game(IPlayer player1, IPlayer player2)
{
    private IPlayer? _currentPlayer;
    
    public void Start()
    {
        player1.Wert = Wert.X;
        player2.Wert = Wert.O;

        var board = new Board();

        _currentPlayer = new Random().Next(2) == 0 ? player1 : player2;

        Console.WriteLine();
        Console.WriteLine($"Spieler {_currentPlayer.Wert} beginnt.");
        Console.WriteLine();
        
        while (board.Sieger == null && !board.IstVoll)
        {
            Console.WriteLine($"Spieler {_currentPlayer.Wert} ist am Zug.");
            _currentPlayer.MacheZug(board);
            _currentPlayer = _currentPlayer == player1 ? player2 : player1;
        }

        Console.WriteLine("Spiel beendet.");
    }
}