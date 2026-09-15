using TicTacToe.GamePlay;
using TicTacToe.GamePlay.Players;
using TicTacToe.Material;

//var game = new Game(new NächstesFreiesFeldPlayer(Wert.X), new NächstesFreiesFeldPlayer(Wert.O));
var game = new Game(new NächstesFreiesFeldPlayer(Wert.X), new ConsolePlayer(Wert.O));
game.Start();