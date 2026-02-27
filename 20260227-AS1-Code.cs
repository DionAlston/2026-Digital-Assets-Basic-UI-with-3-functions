using System;

class GameSuite
{
	static void Main()
	{
		bool running = true;
		while (running)
		{
			Console.WriteLine(" ————————————————————————————————————————————————");
			Console.WriteLine("|                   Game Menu                    |");
			Console.WriteLine(" ————————————————————————————————————————————————");
			Console.WriteLine("| [1] Naughts and Crosses (vs. another player)   |");
			Console.WriteLine("| [2] Scissors Paper Rock (vs. Computer)         |");
			Console.WriteLine("| [3] Quit                                       |");
			Console.WriteLine("| Please submit prompt below:					|");
			Console.WriteLine(" ————————————————————————————————————————————————");
			
			string choice = Console.ReadLine();
			switch (choice)
			{
				case "1":
					PlayNC();
					break;
				case "2":
					PlaySPR();
					break;
				case "3":
					Console.WriteLine("Goodbye! Thank you for playing!");
					running = false;
					break;
				default:
					Console.WriteLine("Invalid prompt. Select an option from the game menu. Input any key to return.");
					Console.ReadLine();
					break;
			}
		}

		static void PlayNC()
		{
			char[,] board = {										// Array
				{ '1', '2', '3' },
				{ '4', '5', '6' },
				{ '7', '8', '9' }
			};
			int turns = 0;
			char currentPlayer = 'X';								// Start with X
			bool NCRunning = true;									// Have in loop

			while (NCRunning && turns < 9)							// Define coordinates in array
			{
				Console.WriteLine(" ————————————————————————————————————————————————");
				Console.WriteLine($"|             Naughts and Crosses - {currentPlayer}           |");
				Console.WriteLine(" ————————————————————————————————————————————————");
				Console.WriteLine($"  {board[0, 0]} | {board[0, 1]} | {board[0, 2]} ");
				Console.WriteLine(" ---+---+---");
				Console.WriteLine($"  {board[1, 0]} | {board[1, 1]} | {board[1, 2]} ");
				Console.WriteLine(" ---+---+---");
				Console.WriteLine($"  {board[2, 0]} | {board[2, 1]} | {board[2, 2]} ");

				Console.WriteLine($"Player {currentPlayer}, select a square (1-9) or type 'exit':");
				string input = Console.ReadLine();

				if (input.ToLower() == "exit") break;				// Exit game function

																	// Define map inputs to array coordinates
				int row = -1, col = -1;
				if (input == "1") { row = 0; col = 0; }
				else if (input == "2") { row = 0; col = 1; }
				else if (input == "3") { row = 0; col = 2; }
				else if (input == "4") { row = 1; col = 0; }
				else if (input == "5") { row = 1; col = 1; }
				else if (input == "6") { row = 1; col = 2; }
				else if (input == "7") { row = 2; col = 0; }
				else if (input == "8") { row = 2; col = 1; }
				else if (input == "9") { row = 2; col = 2; }

				if (row != -1 && board[row, col] != 'X' && board[row, col] != 'O')
				{
					board[row, col] = currentPlayer;
					turns++;

																	// Define parameters to win - 3 vert, horiz, 2 diag
					if ((board[0, 0] == currentPlayer && board[0, 1] == currentPlayer && board[0, 2] == currentPlayer) ||
						(board[1, 0] == currentPlayer && board[1, 1] == currentPlayer && board[1, 2] == currentPlayer) ||
						(board[2, 0] == currentPlayer && board[2, 1] == currentPlayer && board[2, 2] == currentPlayer) ||
						(board[0, 0] == currentPlayer && board[1, 0] == currentPlayer && board[2, 0] == currentPlayer) ||
						(board[0, 1] == currentPlayer && board[1, 1] == currentPlayer && board[2, 1] == currentPlayer) ||
						(board[0, 2] == currentPlayer && board[1, 2] == currentPlayer && board[2, 2] == currentPlayer) ||
						(board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer) ||
						(board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer))
					{
						Console.WriteLine($"Player {currentPlayer} wins! Input any key to return to the main menu.");
						Console.ReadLine();
						NCRunning = false;
					}
					else currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
				}
				else
				{
					Console.WriteLine("Invalid move. Input any key to return.");
					Console.ReadLine();
				}
			}
			if (turns == 9 && NCRunning)
			{
				Console.WriteLine("Tie! Input any key to return to the main menu.");
				Console.ReadLine();
			}
		}

		static void PlaySPR()
		{
			bool playingSPR = true;
			while (playingSPR)
			{
				Console.WriteLine(" ————————————————————————————————————————————————");
				Console.WriteLine("|              Scissors Paper Rock               |");
				Console.WriteLine(" ————————————————————————————————————————————————");
				Console.WriteLine("Scissors, Paper or Rock? Enter 'Exit' to return to the main menu"); 
				string userChoice = Console.ReadLine(); 

				if (userChoice.ToLower() == "exit")
				{
					playingSPR = false;
					continue;
				}

				if (userChoice == "Scissors" || userChoice == "Paper" || userChoice == "Rock" || userChoice == "scissors" || userChoice == "paper" || userChoice == "rock")
				{
					string[] options = { "Scissors", "Paper", "Rock" };
					Random rand = new Random(); 
					string computerChoice = options[rand.Next(options.Length)]; 

					Console.WriteLine($"You chose: {userChoice}");
					Console.WriteLine($"Computer chose: {computerChoice}");

					if (userChoice.ToLower() == computerChoice.ToLower()) 
					{
						Console.WriteLine("Tie!");
					}
					else if ((userChoice.ToLower() == "rock" && computerChoice == "Scissors") ||
							 (userChoice.ToLower() == "paper" && computerChoice == "Rock") || 
							 (userChoice.ToLower() == "scissors" && computerChoice == "Paper"))
					{
						Console.WriteLine("You win!");
					}
					else
					{
						Console.WriteLine("Computer wins!"); 
					}
					Console.WriteLine("Input any key to play again");
					Console.ReadLine();
				}
				else
				{
					Console.WriteLine("Invalid Input. Input any key to try again.");
					Console.ReadLine();
				}
			}
		}
	}
}
