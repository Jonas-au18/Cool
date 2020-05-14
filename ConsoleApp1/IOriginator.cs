namespace ConsoleApp1
{
    public interface IOriginator
    {
        Memento saveStateToMemento();
        void getStateFromMemento(Memento memento);
    }
}
