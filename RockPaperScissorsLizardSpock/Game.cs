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
            Console.WriteLine("Rock Paper Scissors Lizard Spock");
            Console.WriteLine("\nRules for Rock, Paper, Scissors, Lizard, Spock: This is a 2player game. You Can Play Human vs AI or Human vs Human.");
            Console.WriteLine("\nHow To Win \n Scissors cuts Paper, Paper covers Rock, Rock crushes Lizard \n Lizard poisons Spock, Spock smashes Scissors, Scissors decapitates Lizard \n Lizard eats Paper, Paper disproves Spock, Spock vaporizes Rock, Rock crushes Scissors");
        }
        private void ChoosePlayerOption()
        {
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
                Console.WriteLine($"{playerOne.name} Won This Round");
                playerOnePoint++;
            }
            else
            {
                Console.WriteLine($"{playerTwo.name} Won This Round");
                playerTwoPoint++;
            }
        }
        private void GetPoint()
        {
            Console.WriteLine($"{playerOne.name} has {playerOnePoint} piont");
            Console.WriteLine($"{playerTwo.name} has {playerTwoPoint} piont");
        }
        private void GameWinner()
        {

        }
        public void StartGame()
        {
            GetRule();
            ChoosePlayerOption();
            playerOne.ChooseOption();
            playerTwo.ChooseOption();
            RoundWinner();
            GetPoint();
            //determine a round winner
            //determine a game winner
        }
    }
}
