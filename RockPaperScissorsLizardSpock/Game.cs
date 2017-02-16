using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        SinglePlayer singlePlayer = new SinglePlayer();
        _2Player twoPlayer = new _2Player();

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
                    // Make Function To Run Single Player
                    singlePlayer.StartSinglePlayerGame();
                    break;
                case "2":
                    // Make A Function To Run 2 Player
                    twoPlayer.StartTwoPlayerGame();
                    break;
                default:
                    Console.WriteLine("NOT A VALID OPTION");
                    ChoosePlayerOption();
                    break;
            }
        }
        public void StartGame()
        {
            GetRule();
            ChoosePlayerOption();
        }
    }
}
