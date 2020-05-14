using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        { 
            ICaretaker Care = new Caretaker();
            IOriginator Original = new Originator();

            Original.state = "hello world";
            Care.add(Original.saveStateToMemento());
            Original.state = "I AM GROOT";
            Care.add(Original.saveStateToMemento());
            Original.state = "Memento mori";
            Care.add(Original.saveStateToMemento());

            bool done = false;
            do
            {
                Console.WriteLine("Select option:\n 1 Change string \n 2 for Create memento \n 3 for Load mememnto \n Q for terminate program\n");
                string function = Console.ReadLine();
                if (string.IsNullOrEmpty(function)) continue;

                switch (function[0])
                {
                    case '1':
                    {
                        Original.state = Console.ReadLine();
                        break;
                    }
                    case '2':
                    {
                        Care.add(Original.saveStateToMemento());
                        break;
                    }
                    case '3':
                    {
                        Console.WriteLine("Select memento to load from 1 - " + Care.getLen());
                        int index = Int32.Parse(Console.ReadLine());
                        Original.getStateFromMemento(Care.get(index));
                        break;
                    }
                    case 'Q':
                    case 'q':
                    {
                        done = true;
                        break;
                    }
                    default:
                        break;
                }
                Console.WriteLine("Current state is: " + Original.state + "\n");
            } while (!done);
        }
    }
}