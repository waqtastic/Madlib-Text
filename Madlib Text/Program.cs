using System;

namespace Madlib_Text
{
	class Program
	{
		static void Main(string[] args)
		{
			//declare variables
			string Creature;
			string Luminous;
			string Ghastly;
			string Spectral;
			string Farrier;
			string Farmer;
			string Dreadful;
			string Apparition;
			string Hound;
			string Story;

			//write out a header
			Console.WriteLine("------------");
			Console.WriteLine("MadLib!!");
			Console.WriteLine("------------");

			//ask a player to enter words
			Console.WriteLine("Please enter a noun");
			Creature = Console.ReadLine();
			Console.WriteLine("Please enter a adjective");
			Luminous = Console.ReadLine();
			Console.WriteLine("Please enter a adjective");
			Ghastly = Console.ReadLine();
			Console.WriteLine("Please enter a adjective");
			Spectral = Console.ReadLine();
			Console.WriteLine("Please enter an occuation");
			Farrier = Console.ReadLine();
			Console.WriteLine("Please enter an occuation");
			Farmer = Console.ReadLine();
			Console.WriteLine("Please enter an adjective");
			Dreadful = Console.ReadLine();
			Console.WriteLine("Please enter an occuation");
			Apparition = Console.ReadLine();
			Console.WriteLine("Please enter an animal");
			Hound = Console.ReadLine();


			//write out finished story

			Story = "They all agreed that it was a huge " + Creature + ", " + Luminous + ", " + Ghastly + ", and " + Spectral + ". I have cross-examined these men, one of them a hard-headed " + Countryman + ", one a " + Farrier + ", and one a moorland " + Farmer + ", who all tell the same story of this " + Dreadful + " " + Apparition + ", exactly corresponding to the " + Hound + " of the legend.";
			Console.WriteLine(Story);

			//keep window open and prompt for an exit
		}
	}
}
