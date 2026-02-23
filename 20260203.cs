using System;
					
class GameSuite
{
	static void Main()
		// NOTE: 'public' - changes where access from.
		// 10 FEB: Removed public from class and staticvoid, changed Program to GameSuite.
	{
			bool running = true;
			while (running)
	{
		// Console.Clear (?)
		Console.WriteLine(" ————————————————————————————————————————————————");
		Console.WriteLine("|                   Game Menu                    |");
		Console.WriteLine(" ————————————————————————————————————————————————");
		Console.WriteLine("| [1] Naughts and Crosses (vs. another player)   |");
		Console.WriteLine("| [2] Scissors Paper Rock (vs. Computer)         |");
		Console.WriteLine("| [3] EXIT                                       |");
		Console.WriteLine("| Please submit prompt below:			          		|");
		Console.WriteLine(" ————————————————————————————————————————————————");
		// TODO: ABOVE: Make game menu - Lines C.W/L, 1-NC, 2-SPR, 3-EXIT, Please select option. RM C.C (?)
		
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
				running = false;
				break;
			default:
					Console.WriteLine("Invalid prompt. Select from the game menu. Input any key to return.");
					Console.ReadLine();
					break;
				// Send user back to game menu
				
		}
// NOTE: Get User Input from Console.ReadLine
		
	}
	
	static void PlayNC() {
		// TODO: Implement NC
	//	Console.Clear();
		Console.WriteLine(" ————————————————————————————————————————————————");
		Console.WriteLine("|              Naughts and Crosses               |");
		Console.WriteLine(" ————————————————————————————————————————————————");
	}
	static void PlaySPR() {
		// TODO: Implement SPR
	//	Console.Clear();
		Console.WriteLine(" ————————————————————————————————————————————————");
		Console.WriteLine("|           *  Scissors Paper Rock   *           |");
		Console.WriteLine(" ————————————————————————————————————————————————");
		
        {
		// 1: User makes choice
            Console.WriteLine("Scissors, Paper or Rock?");						// C.WL prompts player to make a decision
            string userChoice = Console.ReadLine() ?? "";						// C.RL captures what the player writes, and stores it in a variable called userChoice
			
		// 2: Computer picks randomly
			string[] options = {"Scissors", "Paper", "Rock"};					// options{} holds all valid choices
			Random rand = new Random ();										// Computer makes random choice
			string computerChoice = options[rand.Next(options.Length)];			// Computer makes a decision and it is stored in variable computerChoice

		// 3: Display userChoice and computerChoice
			Console.WriteLine($"You chose: {userChoice}");						// Draw on data stored in computerChoice and userChoice and display it
			Console.WriteLine($"Computer chose: {computerChoice}");
			
			
		// 3: Compare computer and user choices and decide a winner through an if-else statement
			if (userChoice == computerChoice)									// Check for a tie
{
   			Console.WriteLine("Tie!");
}
			else if (
					(userChoice == "Rock" && computerChoice == "Scissors") ||	// Define parameters for user win
					(userChoice == "Paper" && computerChoice == "Rock") ||
					(userChoice == "Scissors" && computerChoice == "Paper")
					)
{
   					 Console.WriteLine("You win!");
}
			else
{
					Console.WriteLine("Computer wins!");						// Else, computer wins
}

		}
	}
}
}
