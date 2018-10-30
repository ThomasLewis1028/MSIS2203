using System;

namespace Week11ICE1
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			Boolean winner = false;
			string[,] board = new string[3, 3];
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					board[i, j] = " ";
				}
			}
			
			
			Console.Out.WriteLine("Input coordinates as X/Y");

			PrintBoard(board);
			for (int i = 0; i < 9; i++)
			{
				int[] arr = new int[2];

				if (i % 2 == 0)
				{

					Console.Out.Write("Player X: ");
					string temp = Console.ReadLine();
					string[] temp2 = temp.Split(null);
					arr[0] = int.Parse(temp2[0]) - 1;
					arr[1] = int.Parse(temp2[1]) - 1;

					if (board[arr[0], arr[1]].Equals(" "))
						board[arr[0], arr[1]] = "X";
					else
					{
						Console.WriteLine("Square already filled");
						i--;
					}
				}
				else
				{
					Console.Out.Write("Player O: ");
					string temp = Console.ReadLine();
					string[] temp2 = temp.Split(null);
					arr[0] = int.Parse(temp2[0]) - 1;
					arr[1] = int.Parse(temp2[1]) - 1;
					
					if (board[arr[0], arr[1]].Equals(" "))
						board[arr[0], arr[1]] = "O";
					else
					{
						Console.WriteLine("Square already filled");
						i--;
					}
				}
				
				
				PrintBoard(board);
					
			}
		}

		public static void PrintBoard(string[,] board)
		{
			for (int i = 0; i < 3; i++)
			{
				Console.Out.WriteLine(board[i, 0] + "|" + board[i, 1] + "|" + board[i, 2]);
				if (i < 2)
					Console.Out.WriteLine("-----");
			}
			
			Console.Out.WriteLine();
		}
	}
}