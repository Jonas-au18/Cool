using System.Runtime.CompilerServices;
using FancyRpg.Concrete;

namespace FancyRpg.Commands 
{
    public class ForwardCommand : ICommand
    {
        private Movememt _movement;

        public ForwardCommand(Movememt movement)
        {
            _movement = movement;
        }

        public void execute()
        {
            _movement.Forward();
        }
    }

    public class BackwardCommand : ICommand
    {
        private Movememt _movememt;

        public BackwardCommand(Movememt movement)
        {
            _movememt = movement;
        }

        public void execute()                   
        {
            _movememt.Backward();
        }
    }

    public class LeftCommand : ICommand
    {
        private Movememt _movememt;

        public LeftCommand(Movememt movememt)
        {
            _movememt = movememt;
        }

        public void execute()
        {
            _movememt.Left();
        }
    }

    public class RightCommand : ICommand
    {
        private Movememt _movememt;

        public RightCommand(Movememt movememt)
        {
            _movememt = movememt;
        }

        public void execute()
        {
            _movememt.Right();
        }
    }

    public class JumpCommand : ICommand
    {
        private Movememt _movememt;

        public JumpCommand(Movememt movememt)
        {
            _movememt = movememt;
        }

        public void execute()
        {
            _movememt.Jump();
        }
    }
}