using TommiTuomas.Models;
using System;

namespace TommiTuomas.Repositories
{
    public class ChatMemoryRepository
    {
        private Message[] _muisti = new Message[10];

        public void PostMessage(Message msg, int pos) {
            _muisti[pos] = msg;
        }

        public Message GetMessage(int pos) {
            Console.WriteLine("perkele");
            return _muisti[pos];
        }

        public Message[] GetAllMsgs() {
            return _muisti;
        }
        
    }
}