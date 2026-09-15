using TicTacToe.Material;

namespace TicTacToe.GamePlay.Players;

public class NächstesFreiesFeldPlayer(Wert wert) : IPlayer
{
    public Wert Wert { get; } = wert;
    
    public void MacheZug(Board board)
    {
        foreach (var feld in board.Felder)
        {
            if (feld.Value == null)
            {
                board.SetzeFeld(feld.Key, Wert);
                return;
            }
        }
    }
}