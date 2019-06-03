using System;
using System.Collections.Generic;
using System.Text;

namespace HIMRogue
{
    class Game
    {
        public int Stage { get; set; }

        public void Launch()
        {
            var board = new Board(84, 24);
            board.DrawBoard();
            // Create Board
            // Populate Board
            // Cycle(Player move)
        }
    }
}
