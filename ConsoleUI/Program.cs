using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
/**
* 2/20/22
* CSC 153
* Tommy Williams
* This application stores Rooms,Weapon,Potion,Display, Treasure, Items, Mobs into arrays and list. The user can have 
* the arrays and list displayed to them
*/
{
	class Program
    {
		static void Main(string[] args)
		{

			int roomLocation = 0;

			string[] weapons = new string[4] { "crossbow", "staff", "axe", "knife", };
			string[] rooms = new string[5] {"Holding Cell", "Lunch Hall", "Armory", "Guard's Office", 
				"Dragon Layer"}; 
			string[] potions = new string[2] { "health", "mana" };
			string[] treasures = new string[3] { "Crown", "Sun Visors", "Gold  Watch" }; 

			List<string> items = new List<string>() {  "Chest Armor", "Door Key", "Shield", "candle" };
			List<string> mobs = new List<string>() { "Guard", "Prisoner", "Ward", "Ox", "Super Prisoner"};


			bool exit = false;

			//Main menu

			while (exit == false)
			{

				Console.WriteLine($"Your are in  the {rooms[roomLocation]}");
				Console.WriteLine("1. A User's Choice");
				Console.WriteLine("1.Display Rooms ");
				Console.WriteLine("2.Display Weapons");
				Console.WriteLine("3.Display Potions");
				Console.WriteLine("4.Treasures");
				Console.WriteLine("5.Items");
				Console.WriteLine("6.Display Mobs");
				Console.WriteLine("7. Exit");
				Console.Write("Enter a choice > ");
				string input = Console.ReadLine();



				switch(input.ToLower())
                {

					case "1":
						foreach (string value in rooms)
                        {
							Console.WriteLine(value);
                        }
						Console.WriteLine();
						break;

					case "2":
						foreach (string value in weapons)
						{
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;

					case "3":
						foreach (string value in potions)
						{
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;
						
					case "4":
						foreach (string value in treasures)
						{
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;
						
					case "5":
						foreach (string value in items)
						{
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;
						
					case "6":
						foreach (string value in mobs)
						{
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;
						
					case "7":
						exit = true;

						break;
						
					case "rooms":
						foreach (string value in rooms)
						{
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;
						
					case "weapons":
						foreach (string value in weapons)
						{
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;
					
						
					case "potions":
						foreach (string value in potions)
						{
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;

					case "treasures":
						foreach (string value in treasures)
						{
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;

					case "items":
						foreach (string value in items)
						{
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;

					case "mobs":
						foreach (string value in rooms)
						{
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;

					case "s":
						if (roomLocation != 0)
						{
							roomLocation--;
						}
						else
						{
							Console.WriteLine("You cant go any further south!");
						}
						Console.WriteLine();
						break;

					case "n":
						if (roomLocation != 4)
                        {
							roomLocation++;
                        }
						else
                        {
							Console.WriteLine("You cant go any further north!");
                        }
						Console.WriteLine();
						break;

					default:
						Console.WriteLine("That is not a choice!!");
						Console.WriteLine();
						break;


				}

				
			}
		}
    }
}
