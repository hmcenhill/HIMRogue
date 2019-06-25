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
            HRooms = 3; VRooms = 2;

            Grid = new Tile[Width, Height];
            for (var y = 0; y < Height; y++)
            {
                for (var x = 0; x < Width; x++)
                {
                    Grid[x, y] = new Tile();
                }
            }
        }
        public void DrawBoard()
        {
            Console.Write($"+{new string('-', Width)}+");
            for (var y = 0; y < Height; y++)
            {
                Console.Write("\n|");
                for (var x = 0; x < Width; x++)
                {
                    if(Grid[x,y].Contains == Entity.Actor)
                    {
                        Console.Write("@");
                    }
                    else if (Grid[x, y].Ground == TileType.Wall)
                    {
                        Console.Write("W");
                    }
                    else if (Grid[x, y].Ground == TileType.Wall)
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("|");
            }
            Console.Write($"\n+{new string('-', Width)}+");
        }
        public void CreateRoom(int xleft, int ytop, int size)
        {
            ytop = 5;
            xleft = 5;
            size = 30;

            for (var x = xleft - 1; x <= xleft + size + 1; x++)
            {
                Grid[x, ytop - 1].Ground = TileType.Wall;
                Grid[x, ytop + size / 2].Ground = TileType.Wall;
            }
            for (var y = ytop; y < ytop + size / 2; y++)
            {
                Grid[xleft - 1, y].Ground = TileType.Wall;

                for (var x = xleft; x < xleft + size; x++)
                {
                    Grid[x, y].Ground = TileType.Room;
                }
                Grid[xleft + size + 1, y].Ground = TileType.Wall;
            }
        }
    }
}
