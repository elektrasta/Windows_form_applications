using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace bakalım_olcakmı
{
	
		internal class Program
		{
			static void Main(string[] args)
			{
				int a, b, c;

				Console.Title = "Creasydot Software";
				Console.WriteLine("Creasydot\n");

				Console.Write("Birinci sayıyı girin: ");
				a = int.Parse(Console.ReadLine());

				Console.Write("İkinci sayıyı girin: ");
				b = int.Parse(Console.ReadLine());

				c = a + b;

				SoundPlayer sp = new SoundPlayer("ses.wav");
				sp.PlayLooping();
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.WriteLine("\nTebrikler, NASA'yı Hacklediniz!");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("  ____      _                                 _  ");
				Console.WriteLine(" / ___|   _| |__   ___ _ __ _ __  _   _ _ __ | | __  ");
				Console.WriteLine("| |  | | | | '_ \\ / _ \\ '__| '_ \\| | | | '_ \\| |/ /  ");
				Console.WriteLine("| |__| |_| | |_) |  __/ |  | |_) | |_| | | | |   <  ");
				Console.WriteLine(" \\____\\__, |_.__/ \\___|_|  | .__/\\__, _|_| |_|_|\\_\\  ");
				Console.WriteLine("      |___/                |_|                       ");
				Console.WriteLine("                ____   ___ _____ _____ ");
				Console.WriteLine("               |___ \\ / _ \\___  |___  |");
				Console.WriteLine("                 __) | | | | / /   / /");
				Console.WriteLine("                / __/| |_| |/ /   / /");
				Console.WriteLine("               |_____|\\___//_/   /_/");
				Console.ReadKey();
			}
		}
}
	

		
    

