using System;

namespace Testapp
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                ConsoleKeyInfo name = Console.ReadKey();
                Console.WriteLine(name.KeyChar);

                if (name.KeyChar == 'x')
                {
                    return;
                }
            }
        }
    }
}
