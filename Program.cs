using TicTacToe.GamePlay;
using TicTacToe.GamePlay.Players;
using TicTacToe.Material;

//var game = new Game(new NächstesFreiesFeldPlayer(Wert.X), new NächstesFreiesFeldPlayer(Wert.O));
//var game = new Game(new NächstesFreiesFeldPlayer(Wert.X), new ConsolePlayer(Wert.O));

var player1 = new NächstesFreiesFeldPlayer();
var player2 = new RandomPlayer();

var game = new Game(player1, player2);
game.Start();