using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class SinglePlayer
    {
        Player player = new Player();

        private void GetSinglePlayer()
        {
            player.GetPlayer1Name();
            Console.WriteLine($"\n{player.player1Name} Choose Your Option: \n 1 = Rock  2 = Paper 3 = Scissors 4 = Lizard 5 = Spock");
            string choosePath = Console.ReadLine();
            switch (choosePath)
            {
                case "1":
                    Console.WriteLine($"\n{player.player1Name} Choose Rock");
                    break;
                case "2":
                    Console.WriteLine($"\n{player.player1Name} Choose Paper");
                    break;
                case "3":
                    Console.WriteLine($"\n{player.player1Name} Choose Scissors");
                    break;
                case "4":
                    Console.WriteLine($"\n{player.player1Name} Choose Lizard");
                    break;
                case "5":
                    Console.WriteLine($"\n{player.player1Name} Choose Spock");
                    break;
                default:
                    Console.WriteLine("NOT A VALID OPTION");
                    GetSinglePlayer();
                    break;
            }
        }
        private void GetAiPlayer()
        {
            Console.WriteLine($"\n{player.GetAi()} Choose Your Option: \n 1 = Rock  2 = Paper 3 = Scissors 4 = Lizard 5 = Spock ");
            int choice = player.GetAiOption();
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"\n{player.GetAi()} Choose Rock");
                    break;
                case 2:
                    Console.WriteLine($"\n{player.GetAi()} Choose Paper");
                    break;
                case 3:
                    Console.WriteLine($"\n{player.GetAi()} Choose Scissors");
                    break;
                case 4:
                    Console.WriteLine($"\n{player.GetAi()} Choose Lizard");
                    break;
                case 5:
                    Console.WriteLine($"\n{player.GetAi()} Choose Spock");
                    break;
                default:
                    Console.WriteLine("NOT A VALID OPTION");
                    GetAiPlayer();
                    break;
            }
        }
        public void StartSinglePlayerGame()
        {
            GetSinglePlayer();
            GetAiPlayer();
        }
    }
}
