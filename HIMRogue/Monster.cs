using System;
using System.Collections.Generic;
using System.Text;

namespace HIMRogue
{
    public class Monster : Actor
    {
        public Actor Target { get; set; }

        public Monster()
        {
            Icon = 'M';
            X = 20;
            Y = 10;

            Target = null;
        }
        public override void Bump(Entity entity)
        {
            Console.WriteLine("The monster attacks YOU!");

        }

        public override void Act()
        {
            if (Target != null)
            {
                AttackTarget();
            }
            else
            {
                DoNothing();
            }
        }
        private void AttackTarget()
        {
            if (Math.Abs(this.X - Target.X) > Math.Abs(this.Y - Target.Y))
            {
                if (this.X > Target.X)
                {
                    X--;
                }
                else
                {
                    X++;
                }
            }
            else
            {
                if (this.Y > Target.Y)
                {
                    Y--;
                }
                else
                {
                    Y++;
                }

            }
        }
        private void DoNothing()
        {

        }
    }
}
