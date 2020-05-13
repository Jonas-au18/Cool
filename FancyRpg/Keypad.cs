using System.Collections.Generic;

namespace FancyRpg
{
    public class Keypad
    {
        private ICommand[] commands;

        public Keypad()
        {
            commands = new ICommand[8];
        }

        public void setCommand(ICommand command, int bind)
        {
            commands[bind] = command;
        }

        public void keyPressed(int bind)
        {
            commands[bind].execute();
        }
    }
}