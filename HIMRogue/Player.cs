using System;
using System.Collections.Generic;
using System.Text;

namespace HIMRogue
{
   public class Player : Actor
    {
        public Player()
        {
            Icon = '@';
            X = 10;
            Y = 10;
        }
        public override void Act()
        {
            var input = GetMovement();
            if (input == "up") Y--;
            if (input == "left") X--;
            if (input == "down") Y++;
            if (input == "right") X++;
        }
        public override void Bump(Entity entity)
        {
            if(entity.EType == EntityType.Actor)
            {
                Console.WriteLine("You ATTACK the Monster!");
            }
        }
        public string GetMovement()
        {
            while (true)
            {
                var input = Console.ReadKey().KeyChar;
                Console.Clear();

                if (input == 'w') return "up";
                if (input == 'a') return "left";
                if (input == 's') return "down";
                if (input == 'd') return "right";
            }
        }
    }
}
