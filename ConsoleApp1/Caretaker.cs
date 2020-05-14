using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Caretaker : ICaretaker
    {
        private List<Memento> _mementoes = new List<Memento>();

        public void add(Memento state)
        {
            Console.Write("Adding to memento: " + state.state + "\n");
            _mementoes.Add(state);
        }

        public Memento get(int index)
        {
            return _mementoes[index-1];
        }

        public int getLen()
        {
            return (_mementoes.Count);
        }
        
    }
}