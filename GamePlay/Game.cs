using TicTacToe.GamePlay.Players;
using TicTacToe.Material;

namespace TicTacToe.GamePlay;

public class Game(IPlayer player1, IPlayer player2)
{
    private IPlayer? _currentPlayer;
    
    public void Start()
    {
        if (player1.Wert == player2.Wert)
        {
            Console.WriteLine("Beide Spieler haben den gleichen Wert.");
            return;
        }

        var board = new Board();

        _currentPlayer = player1;
        while (board.Sieger == null && !board.IstVoll)
        {
            _currentPlayer.MacheZug(board);
            _currentPlayer = _currentPlayer == player1 ? player2 : player1;
        }

        Console.WriteLine("Spiel beendet.");
    }
}