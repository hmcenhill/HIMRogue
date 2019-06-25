using System;
using System.Collections.Generic;
using System.Text;

namespace HIMRogue
{
   public class Player
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Player()
        {
            X = 10;
            Y = 10;
        }
        public void Move()
        {
            var input = GetMovement();

        }
        public string GetMovement()
        {
            while (true)
            {
                var input = Console.ReadKey().KeyChar;
                if (input == 'w') return "up";
                if (input == 'a') return "left";
                if (input == 's') return "down";
                if (input == 'd') return "right";
            }
        }
    }
}
