using TicTacToe.Material;

namespace TicTacToe.GamePlay.Players;

public interface IPlayer
{
    Wert Wert { get; }

    void MacheZug(Board board);
}