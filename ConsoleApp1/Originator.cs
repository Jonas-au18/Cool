namespace ConsoleApp1
{
    public class Originator : IOriginator
    {
        private string _state;

        public string state
        {
            get { return _state; }
            set
            {
                _state = value;
            }
        }

        public Memento saveStateToMemento()
        {
            return new Memento(state);
        }

        public void getStateFromMemento(Memento memento)
        {
            state = memento.state;
        }
        
        public void setState()
    }
}