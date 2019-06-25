using System;
using System.Collections.Generic;
using System.Text;

namespace HIMRogue
{
    public class Tile
    {
        public bool Visible { get; set; }
        public bool Uncovered { get; set; }
        public TileType Ground { get; set; }
        public Entity Contains { get; set; }
         
        public Tile()
        {
            Visible = false;
            Uncovered = false;
            Ground = TileType.Void;
            Contains = Entity.Terrain;
        }
    }
}
