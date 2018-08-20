﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();
            var intro = new IntroScreen(player);
            var nextScreen = intro.Run();

            while (nextScreen != null)
            {
                nextScreen = nextScreen.Run();
            }   }
    }
}
