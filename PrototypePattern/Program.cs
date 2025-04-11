using PrototypePattern;

Gameboard gameboard = new Gameboard();
gameboard.AddGamePieces(new Gamepiece("Red", 2));
gameboard.AddGamePieces(new Gamepiece("Yellow", 3));

Console.WriteLine(gameboard.GetBoardState());
//SavePoint
Gameboard savedGameBoard = gameboard.Clone();
Console.WriteLine(savedGameBoard.GetBoardState());