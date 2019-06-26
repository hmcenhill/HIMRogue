using System;
using System.Collections.Generic;
using System.Text;

namespace HIMRogue
{
    public class Session
    {
        public Player User { get; set; }
        public int Level { get; set; }

        public Session(Player user)
        {
            User = user;
            Level = 1;

        }

        public void Begin()
        {
            var playing = true;
            while (playing)
            {
                var stage = new Stage(Level, User);
                stage.Play();
            }
        }

    }
}
