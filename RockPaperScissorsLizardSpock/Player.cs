using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Player
    {
        public string player1Name;
        public string player2Name;
        public Random AiRandomOption;

        public Player()
        {

        }

        public void GetPlayer1Name()
        {
            Console.Write("\nPlease Enter Player 1 Name: ");
            player1Name = (Console.ReadLine());
        }
        public void GetPlayer2Name()
        {
            Console.WriteLine("\nPlease Enter Player 2 Name: ");
            player2Name = (Console.ReadLine());
        }
        public string GetAi()
        {
            string Ai = "Ai";
            return Ai;

        }
        public Random GetAiOption()
        {

            int choice = AiRandomOption.Next(1, 6);
            return AiChoice;
        }    
    }
}
