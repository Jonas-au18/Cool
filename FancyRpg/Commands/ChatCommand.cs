using FancyRpg.Concrete;

namespace FancyRpg.Commands
{
    public class ChatCommand : ICommand
    {
        private Chat _chat;

        public ChatCommand(Chat chat)
        {
            _chat = chat;
        }

        public void execute()
        {
            _chat.SendChat();
        }
    }
}