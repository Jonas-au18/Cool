using System;

namespace FancyRpg.Concrete
{
    public class Chat
    {
        public void SendChat()
        {
            string message = Console.ReadLine();
            Console.WriteLine("\n Our hero said" + message);
        }
    }
}