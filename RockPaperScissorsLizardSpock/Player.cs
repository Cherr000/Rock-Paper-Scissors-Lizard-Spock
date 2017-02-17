using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Player
    {
        public string name;
        public string choice;
        public Random AiRandomOption = new Random();

        public Player()
        {

        }

        public void GetPlayerName()
        {
            Console.Write("\nPlease Enter Player Name: ");
            name = (Console.ReadLine());
        }
        
        
        
        public virtual void ChooseOption()
        {
            Console.WriteLine($"\n{name} Choose Your Option: \n Rock, Paper, Scissors, Lizard, or Spock");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "Rock":
                    Console.WriteLine($"{name} Choose Rock");
                    break;
                case "Paper":
                    Console.WriteLine($"{name} Choose Paper");
                    break;
                case "Scissors":
                    Console.WriteLine($"{name} Choose Scissors");
                    break;
                case "Lizard":
                    Console.WriteLine($"{name} Choose Lizard");
                    break;
                case "Spock":
                    Console.WriteLine($"{name} Choose Spock");
                    break;
                default:
                    Console.WriteLine("NOT A VALID OPTION");
                    ChooseOption();
                    break;
            }
        }
        
    }
}
