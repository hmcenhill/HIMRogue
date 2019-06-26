using System;
using System.Collections.Generic;
using System.Text;

namespace HIMRogue
{
    public abstract class Actor : Entity
    {

        public int Health { get; set; }
        public abstract void Act();
        public abstract void Bump(Entity entity);

        public Actor()
        {
            EType = EntityType.Actor;
        }
    }
}
