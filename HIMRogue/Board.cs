using System;
using System.Collections.Generic;
using System.Text;

namespace HIMRogue
{
    public class Board
    {
        private int Width { get; set; }
        private int Height { get; set; }
        private int HRooms { get; set; }
        private int VRooms { get; set; }
        public Tile[,] Grid { get; set; }

        public Board(int width, int height)
        {
            Width = width; Height = height;
            Grid = new Tile[Width, Height];
            for(var y = 0; y < Height; y++)
            {
                for(var x = 0; x < Width; x++)
                {
                    Grid[x, y] = new Tile();
                }
            }
        }
        public void DrawBoard()
        {
            Console.Write($"+{new string('-',Width)}+");
            for (var y = 0; y < Height; y++)
            {
                Console.Write("\n|");
                for (var x = 0; x < Width; x++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
            }
            Console.Write($"\n+{new string('-',Width)}+");
        }
    }
}
