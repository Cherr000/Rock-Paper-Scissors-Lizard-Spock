using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        public int playerOnePoint;
        public int playerTwoPoint;
        Player playerOne;
        Player playerTwo;

        private void GetRule()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            Console.WriteLine("Rock Paper Scissors Lizard Spock");
            Console.WriteLine("\nRules for Rock, Paper, Scissors, Lizard, Spock: This is a 2player game. You Can Play Human vs AI or Human vs Human.");
            Console.WriteLine("\nHow To Win \n Scissors cuts Paper, Paper covers Rock, Rock crushes Lizard \n Lizard poisons Spock, Spock smashes Scissors, Scissors decapitates Lizard \n Lizard eats Paper, Paper disproves Spock, Spock vaporizes Rock, Rock crushes Scissors");
            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
        }
        private void ChoosePlayerOption()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nType 1 For Single Player Or Type 2 For 2 Player");
            string choosePlayer = Console.ReadLine();
            switch (choosePlayer)
            {
                case "1":
                    playerOne = new Human();
                    playerTwo = new Computer();
                    playerOne.GetPlayerName();
                    break;
                case "2":
                    playerOne = new Human();
                    playerTwo = new Human();
                    playerOne.GetPlayerName();
                    playerTwo.GetPlayerName();
                    break;
                default:
                    Console.WriteLine("NOT A VALID OPTION");
                    ChoosePlayerOption();
                    break;
            }
        }
        private void RoundWinner()
        {
            if ((playerOne.choice == "Rock" && playerTwo.choice == "Rock") || (playerOne.choice == "Paper" && playerTwo.choice == "Paper") || (playerOne.choice == "Scissors" && playerTwo.choice == "Scissors") || (playerOne.choice == "Lizard" && playerTwo.choice == "Lizard")  || (playerOne.choice == "Spock" && playerTwo.choice == "Spock"))
            {
                Console.WriteLine("Tie");
            }
            else if ((playerOne.choice == "Rock" && playerTwo.choice == "Scissors") || (playerOne.choice == "Rock" && playerTwo.choice == "Lizard") || (playerOne.choice == "Paper" && playerTwo.choice == "Rock") || (playerOne.choice == "Paper" && playerTwo.choice == "Lizard") || (playerOne.choice == "Scissors" && playerTwo.choice == "Paper") || (playerOne.choice == "Scissors" && playerTwo.choice == "Lizard") || (playerOne.choice == "Lizard" && playerTwo.choice == "Paper") || (playerOne.choice == "Lizard" && playerTwo.choice == "Lizard") || (playerOne.choice == "Spock" && playerTwo.choice == "Scissors") || (playerOne.choice == "Spock" && playerTwo.choice == "Rock"))
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{playerOne.name} Won This Round");
                playerOnePoint++;                
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{playerTwo.name} Won This Round");
                playerTwoPoint++;                
            }
        }
        private void GetPoint()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n{playerOne.name} has {playerOnePoint} piont");
            Console.WriteLine($"{playerTwo.name} has {playerTwoPoint} piont");
            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
        }
        private void GameWinner()
        {
            int score = 0;
            while (++score < 2)
            {
                if (playerOnePoint > 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"\n{playerOne.name} win");
                    Console.WriteLine(" The game is over ");
                    playerOnePoint = 2;
                    playerTwoPoint = 0;
                }
                else if (playerTwoPoint > 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"\n{playerTwo.name} win");
                    Console.WriteLine(" The game is over ");
                    playerOnePoint = 0;
                    playerTwoPoint = 2;
                }
            }
        }
        private void RestartGame()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nThank You For Playing \nWill You Like To Replay The Game. If Yes Type Yes, If No Type No.");
            string choosePlayer = Console.ReadLine();
            switch (choosePlayer)
            {
                case "Yes":
                    playerOnePoint = 0;
                    playerTwoPoint = 0;
                    StartGame();
                    break;
                case "No":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("NOT A VALID OPTION");
                    RestartGame();
                    break;
            }
        }
        public void StartGame()
        {
            Console.Clear();
            do
            {
                GetRule();
                ChoosePlayerOption();

                while (playerOnePoint < 3 && playerTwoPoint < 3)
                {
                    playerOne.ChooseOption();
                    playerTwo.ChooseOption();
                    RoundWinner();
                    GetPoint();
                }
                GameWinner();
                RestartGame();
            }
            while (playerOnePoint == 0 && playerTwoPoint == 0);
        }
    }
}
