using System;
using FancyRpg.Commands;
using FancyRpg.Concrete;
using FancyRpg.Utility;

namespace FancyRpg
{
    class Program
    {
        private static Game myGame;
        static void Main(string[] args)
        {
            myGame = new Game();
            myGame.run();
        }
    }
}