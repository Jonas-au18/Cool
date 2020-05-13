using FancyRpg.Concrete;

namespace FancyRpg.Commands
{
    public class AttackCommand : ICommand
    {
        private Combat _combat;

        public AttackCommand(Combat combat)
        {
            _combat = combat;
        }

        public void execute()
        {
            _combat.attack();
        }
    }

    public class BlockCommand : ICommand
    {
        private Combat _combat;

        public BlockCommand(Combat combat)
        {
            _combat = combat;
        }

        public void execute()
        {
            _combat.block();
        }
    }
}