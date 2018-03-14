/*
 * Created by SharpDevelop.
 * User: 0464017
 * Date: 3/14/2018
 * Time: 11:53 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */


	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine("Welcome to Rock, Paper, Scissors.");
			Console.ReadLine();
			Console.WriteLine("Make your choice:");
			gameFunc();
		}
		
		public static void gameFunc()
		{
			random rand = new random
				
			string rock = "ROCK";
			string paper = "PAPER";
			string scissors = "SCISSORS";
			string choice = Console.ReadLine();
			
			int random = rand.Next(1, 4);
			choice = choice.ToUpper();
			
			switch (random)
			{
					
				case 1:
					if (choice == rock)
					{
						Console.WriteLine(choice + " <-you vs. us -> " + rock + "./n");
						Console.WriteLine("Issa tie");
					}
					else if (choice == paper)
					{
						Console.WriteLine(choice + " <-you vs. us -> " + rock + "./n");
						Console.WriteLine("You win!");
					}
					else if (choice == scissors)
					{
						Console.WriteLine(choice + " <-you vs. us -> " + rock + "./n");
						Console.WriteLine("You suck!");
					}
					else 
					{
						Console.WriteLine(choice + " is not a choice.");
					}
					break;
					
					
				case 2: 
					if (choice == rock)
					{
						Console.WriteLine(choice + " <-you vs. us -> " + paper + "./n");
						Console.WriteLine("You suck");
					}
					else if (choice == paper)
					{
						Console.WriteLine(choice + " <-you vs. us -> " + paper + "./n");
						Console.WriteLine("Issa tie");
					}
					else if (choice == scissors)
					{
						Console.WriteLine(choice + " <-you vs. us -> " + paper + "./n");
						Console.WriteLine("You win");
					}
					else 
					{
						Console.WriteLine(choice + " is not a choice.");
					}
					break;
					
				default: 
					if (choice == rock)
					{
						Console.WriteLine(choice + " <-you vs. us -> " + scissors + "./n");
						Console.WriteLine("You win");
					}
					else if (choice == paper)
					{
						Console.WriteLine(choice + " <-you vs. us -> " + scissors + "./n");
						Console.WriteLine("You suck");
					}
					else if (choice == scissors)
					{
						Console.WriteLine(choice + " <-you vs. us -> " + scissors + "./n");
						Console.WriteLine("Issa tie");
					}
					else 
					{
						Console.WriteLine(choice + " is not a choice.");
					}
					break;
			}
			
			Console.ReadLine();
			
		}	
	}
	
}