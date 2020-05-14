using System;
using System.Text;
using FancyRpg.Commands;
using FancyRpg.Concrete;
using FancyRpg.Utility;

namespace FancyRpg
{

    public class Game
    {
        private Map myMap;
        private Hero myHero;
        private Chat myChat;
        private Combat myCombat;
        private Keypad controller;
        private Movememt myMovement;
        
        public Game()
        {
            //Utility
            myMap = new Map();
            myHero = new Hero();
            myMap.GenerateMap();
            //Recievers
            myChat = new Chat();
            myMovement = new Movememt(myMap);
            myCombat = new Combat(myHero,myMap);
            
            //Invoker
            controller = new Keypad();
        }

        public void run()
        {
            controller.setCommand(new ForwardCommand(myMovement),new BackwardCommand(myMovement),
                new LeftCommand(myMovement),new RightCommand(myMovement),0 );
            controller.setCommand(new JumpCommand(myMovement),new ChatCommand(myChat),
                new AttackCommand(myCombat),new BlockCommand(myCombat),  1  );

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.KeyChar == 'w')
                {
                    controller.keyOnePressed(0);
                }
                else if (key.KeyChar == 's')
                {
                    controller.keyTwoPressed(0);
                }
                else if (key.KeyChar == 'a')
                {
                    controller.keyThreePressed(0);
                }
                else if (key.KeyChar == 'd')
                {
                    controller.keyFourPressed(0);
                }
                else if (key.KeyChar == ' ')
                {
                    controller.keyOnePressed(1);
                }
                else if (key.KeyChar == 'c')
                {
                    controller.keyTwoPressed(1);
                }
                else if (key.KeyChar == 'f')
                {
                    controller.keyThreePressed(1);
                }
                else if (key.KeyChar == 'g')
                {
                    controller.keyFourPressed(1);
                }
                else if (key.KeyChar == 'x')
                {
                    return;
                }
            }
        }
    }
}