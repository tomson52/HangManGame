namespace HangManGame
{
	public class ASCIIArt
	{
		public static void HangedPrint(){
			// hanged
			System.Console.WriteLine("  ________");
			System.Console.WriteLine("  |	 |");
			System.Console.WriteLine("  |      0");
			System.Console.WriteLine("  |     /|\\");
			System.Console.WriteLine(" /|\\    / \\");
			System.Console.WriteLine("/___\\_______");
		}

		public static void ArtPrint(int life)
		{
			switch (life)
			{
				case 5:
					//life = 5
					System.Console.WriteLine("  ________");
					System.Console.WriteLine("  |	 |");
					System.Console.WriteLine("  |");
					System.Console.WriteLine("  |");
					System.Console.WriteLine(" /|\\");
					System.Console.WriteLine("/___\\_______");
					return;
					
				case 4:
					//life = 4
					System.Console.WriteLine("  ________");
					System.Console.WriteLine("  |	 |");
					System.Console.WriteLine("  |      0");
					System.Console.WriteLine("  |");
					System.Console.WriteLine(" /|\\");
					System.Console.WriteLine("/___\\_______");
					return;
					
				case 3:	
					//life = 3
					System.Console.WriteLine("  ________");
					System.Console.WriteLine("  |	 |");
					System.Console.WriteLine("  |      0");
					System.Console.WriteLine("  |     /");
					System.Console.WriteLine(" /|\\");
					System.Console.WriteLine("/___\\_______");
					return;
					
				case 2:
					//life = 2 
					System.Console.WriteLine("  ________");
					System.Console.WriteLine("  |	 |");
					System.Console.WriteLine("  |      0");
					System.Console.WriteLine("  |     /|");
					System.Console.WriteLine(" /|\\");
					System.Console.WriteLine("/___\\_______");
					return;
					
				case 1:	
					//life = 1
					System.Console.WriteLine("  ________");
					System.Console.WriteLine("  |	 |");
					System.Console.WriteLine("  |      0");
					System.Console.WriteLine("  |     /|\\");
					System.Console.WriteLine(" /|\\");
					System.Console.WriteLine("/___\\_______");
					return;
				
				case 0:
					//life = 0 
					System.Console.WriteLine("  ________");
					System.Console.WriteLine("  |	 |");
					System.Console.WriteLine("  |      0");
					System.Console.WriteLine("  |     /|\\");
					System.Console.WriteLine(" /|\\    / ");
					System.Console.WriteLine("/___\\_______");
					return;
			}
		}
	}
}