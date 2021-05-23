using System;
using System.Collections.Generic;

namespace rockpaper.Models
{
    public class Game
    {
        public List<string> comChoices = new List<string> { "Rock", "Paper", "Scissors" };
        private string Choice { get; set; }
        public string playerChoice { get; set; }

        public ComChoice()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 4);
        }
    }
}