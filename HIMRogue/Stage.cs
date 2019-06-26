using System;
using System.Collections.Generic;
using System.Text;

namespace HIMRogue
{
    public class Stage
    {
        public Player User { get; set; }
        public int Level { get; set; }
        public Board Map { get; set; }
        public List<Actor> Actors { get; set; }
        public List<Monster> Monsters { get; set; }

        public Stage(int level, Player user)
        {
            Level = level;

            Map = new Board(48, 24);
            Map.CreateRoom(4, 2, 40);
            User = user;
            Actors = new List<Actor>();
            Monsters = new List<Monster>();
            Actors.Add(User);
            var monster = new Monster();
            Actors.Add(monster);
            Monsters.Add(monster);

        }
        public void Play()
        {
            var playing = true;
            while (playing)
            {
                TakeTurn();
                DrawBoard();
            }
        }
        private void DrawBoard()
        {
            Map.DrawBoard();
        }
        private void TakeTurn()
        {
            foreach (var actor in Actors)
            {
                var lastX = actor.X;
                var lastY = actor.Y;
                Map.Grid[actor.X, actor.Y].Contains = EntityType.Terrain;
                Map.Grid[actor.X, actor.Y].Character = null;

                actor.Act();

                if (Map.Grid[actor.X, actor.Y].Ground != TileType.Room || Map.Grid[actor.X, actor.Y].Character != null)
                {
                    actor.Bump(Map.Grid[actor.X, actor.Y].Character);
                    actor.X = lastX;
                    actor.Y = lastY;
                }

                Map.Grid[actor.X, actor.Y].Contains = EntityType.Actor;
                Map.Grid[actor.X, actor.Y].Character = actor;
            }
            foreach(var monster in Monsters)
            {
                if(monster.Target == null)
                {
                    monster.Target = User;
                }
            }
        }
    }
}
