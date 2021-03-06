using TommiTuomas.Models;
using TommiTuomas.Repositories;
using System;

namespace TommiTuomas.Processors
{
    public class ChatProcessor
    {
        private readonly ChatMemoryRepository _repository;

        public ChatProcessor(ChatMemoryRepository repository) {
            _repository = repository;
        }

        public void PostMessage(NewMessage msg, int pos) {
            Message _message = new Message() {
                Nickname = msg.Nickname,
                Comment = msg.Comment,
                Timestamp = DateTime.Now.ToString("HH:mm")//yyyyMMddHHmmssffff
            };
            _repository.PostMessage(_message, pos);
        }

        public Message GetMessage(int pos) {
            return _repository.GetMessage(pos);
        }

        public string GetAllMsgs() {
            Message[] kaikki = _repository.GetAllMsgs();
            int pituus = kaikki.Length;
            string palautus = "";

            for (int i = 0; i < pituus; i++) {
                palautus += kaikki[i].Timestamp + " " + kaikki[i].Nickname + ": " + kaikki[i].Comment + "\n";
            }

            return palautus;
        }
    }
}