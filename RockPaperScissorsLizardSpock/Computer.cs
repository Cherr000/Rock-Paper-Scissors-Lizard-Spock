using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Computer : Player
    {

        public Computer()
        {
            name = "AI";
        }
        public override void ChooseOption()
        {
            Random random = new Random();
            List<string> choices = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
            choice = choices[random.Next(0, 4)];
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n{choice}");
            Console.WriteLine($"{name} Choose {choice}");

        }
    }
}
