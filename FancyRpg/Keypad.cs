using System;
using System.Collections.Generic;

namespace FancyRpg
{
    public class Keypad
    {
        private ICommand[] command1;
        private ICommand[] command2;
        private ICommand[] command3;
        private ICommand[] command4;

        public Keypad()
        {
            command1 = new ICommand[2];
            command2 = new ICommand[2];
            command3 = new ICommand[2];
            command4 = new ICommand[2];
        }

        public void setCommand(ICommand com1,ICommand com2, ICommand com3, ICommand com4, int bind)
        {
            command1[bind] = com1;
            command2[bind] = com2;
            command3[bind] = com3;
            command4[bind] = com4;
        }

        public void keyOnePressed(int bind)
        {
            command1[bind].execute();
        }

        public void keyTwoPressed(int bind)
        {
            command2[bind].execute();
        }

        public void keyThreePressed(int bind)
        {
            command3[bind].execute();
        }

        public void keyFourPressed(int bind)
        {
            command4[bind].execute();
        }
    }
}