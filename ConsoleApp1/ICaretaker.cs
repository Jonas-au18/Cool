namespace ConsoleApp1
{
    public interface ICaretaker
    {
        void add(Memento m);

        Memento get(int index);

        int getLen();
    }
}