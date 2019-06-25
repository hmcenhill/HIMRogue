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
            board.CreateRoom(5, 5, 40);
            var player = new Player();
            var playing = true;
            while (playing)
            {
                Console.Clear();
                board.Grid[player.X, player.Y].Contains = Entity.Actor;
                board.DrawBoard();
                var input = player.GetMovement();
                board.Grid[player.X, player.Y].Contains = Entity.Terrain;
                var lastX = player.X;
                var lastY = player.Y;
                if (input == "up") player.Y--;
                if (input == "left") player.X--;
                if (input == "down") player.Y++;
                if (input == "right") player.X++;
                if(board.Grid[player.X,player.Y].Ground == TileType.Wall)
                {
                    player.X = lastX;
                    player.Y = lastY;
                }
            }
            
            // Create Board
            // Populate Board
            // Cycle(Player move)
        }
    }
}
