using TommiTuomas.Models;
using System;
using System.Collections.Generic;

namespace TommiTuomas.Repositories
{
    public class ChatMemoryRepository
    {
        private List<Message> _lista = new List<Message>();

        public void PostMessage(Message msg) {
            _lista.Add(msg);
        }

        public Message GetMessage(int pos) {
            return _lista[pos];
        }

        public List<Message> GetAllMsgs() {
            return _lista;
        }
        
    }
}