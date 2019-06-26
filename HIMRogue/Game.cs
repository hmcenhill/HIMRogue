using System;
using System.Collections.Generic;
using System.Text;

namespace HIMRogue
{
    public class Game
    {

        public void Launch()
        {
            var user = new Player();
            var session = new Session(user);
            session.Begin();


        }
    }

}
