using TommiTuomas.Models;
using System;

namespace TommiTuomas.Repositories
{
    public class ChatMemoryRepository
    {
        private int pos = 0;
        private Message[] _muisti = new Message[10];

        public void PostMessage(Message msg) {
            _muisti[pos] = msg;
            pos++;
        }

        public Message GetMessage(int pos) {
            return _muisti[pos];
        }

        public Message[] GetAllMsgs() {
            return _muisti;
        }
        
    }
}