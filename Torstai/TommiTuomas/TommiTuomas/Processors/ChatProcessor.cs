using TommiTuomas.Models;
using TommiTuomas.Repositories;
using System;
using System.Collections.Generic;

namespace TommiTuomas.Processors
{
    public class ChatProcessor
    {
        private readonly ChatMemoryRepository _repository;

        public ChatProcessor(ChatMemoryRepository repository) {
            _repository = repository;
        }

        public void PostMessage(NewMessage msg) {
            Message _message = new Message() {
                Nickname = msg.Nickname,
                Comment = msg.Comment,
                Timestamp = DateTime.Now.ToString("HH:mm")//yyyyMMddHHmmssffff
            };
            _repository.PostMessage(_message);
        }

        public Message GetMessage(int pos) {
            return _repository.GetMessage(pos);
        }

        public string GetAllMsgs() {
            List<Message> kaikki = _repository.GetAllMsgs();
            int pituus = kaikki.Count;

            string palautus = "*=. Tommi & Tuomas Chat .=*\n\n";

            if (pituus > 0) {

                for (int i = 0; i < pituus; i++) {
                    palautus += kaikki[i].Timestamp + " " + kaikki[i].Nickname + ": " + kaikki[i].Comment + "\n";
                }

            } else {
                palautus += "Chat on tällä hetkellä tyhjä!";
            }

            return palautus;
        }
    }
}