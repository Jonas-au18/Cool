using System;
using FancyRpg.Commands;
using FancyRpg.Concrete;
using FancyRpg.Utility;

namespace FancyRpg
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup
            //Recievers
            Map myMap = new Map();
            myMap.GenerateMap();
            Hero myHero = new Hero();
            Chat myChat = new Chat();
            Movememt myMovement = new Movememt(myMap);
            Combat myCombat = new Combat(myHero,myMap);
            
            //Invoker
            Keypad controller = new Keypad();
            
            controller.setCommand(new ForwardCommand(myMovement),0);
            controller.setCommand(new BackwardCommand(myMovement),1 );
            controller.setCommand(new LeftCommand(myMovement),2 );
            controller.setCommand(new RightCommand(myMovement),3 );
            controller.setCommand(new JumpCommand(myMovement),4 );
            controller.setCommand(new ChatCommand(myChat),5 );
            controller.setCommand(new AttackCommand(myCombat),6);
            controller.setCommand(new BlockCommand(myCombat),7);

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.KeyChar == 'w')
                {
                    controller.keyPressed(0);
                }
                else if (key.KeyChar == 's')
                {
                    controller.keyPressed(1);
                }
                else if (key.KeyChar == 'a')
                {
                    controller.keyPressed(2);
                }
                else if (key.KeyChar == 'd')
                {
                    controller.keyPressed(3);
                }
                else if (key.KeyChar == ' ')
                {
                    controller.keyPressed(4);
                }
                else if (key.KeyChar == 'c')
                {
                    controller.keyPressed(5);
                }
                else if (key.KeyChar == 'f')
                {
                    controller.keyPressed(6);
                }
                else if (key.KeyChar == 'g')
                {
                    controller.keyPressed(7);
                }
                else if (key.KeyChar == 'x')
                {
                    return;
                }
            }
        }
    }
}