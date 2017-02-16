using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class _2Player
    {
        Player player = new Player();

        private void GetUserPlayerName()
        {
            player.GetPlayer1Name();
            player.GetPlayer2Name();
        }
        private void GetPlayerOne()
        {
            Console.WriteLine($"\n{player.player1Name} Choose Your Option: \n 1 = Rock  2 = Paper 3 = Scissors 4 = Lizard 5 = Spock");
            string choosePath = Console.ReadLine();
            switch (choosePath)
            {
                case "1":
                    Console.WriteLine($"{player.player1Name} Choose Rock");
                    break;
                case "2":
                    Console.WriteLine($"{player.player1Name} Choose Paper");
                    break;
                case "3":
                    Console.WriteLine($"{player.player1Name} Choose Scissors");
                    break;
                case "4":
                    Console.WriteLine($"{player.player1Name} Choose Lizard");
                    break;
                case "5":
                    Console.WriteLine($"{player.player1Name} Choose Spock");
                    break;
                default:
                    Console.WriteLine("NOT A VALID OPTION");
                    GetPlayerOne();
                    break;
            }
        }
        private void GetPlayerTwo()
        {
            Console.WriteLine($"\n{player.player2Name} Choose Your Option: \n 1 = Rock  2 = Paper 3 = Scissors 4 = Lizard 5 = Spock");
            string choosePath = Console.ReadLine();
            switch (choosePath)
            {
                case "1":
                    Console.WriteLine($"{player.player2Name} Choose Rock");
                    break;
                case "2":
                    Console.WriteLine($"{player.player2Name} Choose Paper");
                    break;
                case "3":
                    Console.WriteLine($"{player.player2Name} Choose Scissors");
                    break;
                case "4":
                    Console.WriteLine($"{player.player2Name} Choose Lizard");
                    break;
                case "5":
                    Console.WriteLine($"{player.player2Name} Choose Spock");
                    break;
                default:
                    Console.WriteLine("NOT A VALID OPTION");
                    GetPlayerTwo();
                    break;
            }
        }
        public void StartTwoPlayerGame()
        {
            GetUserPlayerName();
            GetPlayerOne();
            GetPlayerTwo();
        }
    }
}
