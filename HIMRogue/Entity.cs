using System;
using System.Collections.Generic;
using System.Text;

namespace HIMRogue
{
    public abstract class Entity
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Char Icon { get; set; }
        public EntityType EType {get;set;}

    }
}
