using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TommiTuomas.Models;
using TommiTuomas.Processors;

namespace TommiTuomas.Controllers
{

    [Route("api/chat")]
    public class ChatController
    {

        private ChatProcessor _processor;

        public ChatController(ChatProcessor processor) {
            _processor = processor;
        }


        [HttpGet("{pos}")]
        public string GetMessage(int pos)
        {
            return String.Format("{0} {1}: {2}",  _processor.GetMessage(pos).Timestamp, _processor.GetMessage(pos).Nickname, _processor.GetMessage(pos).Comment);
        }

        [HttpGet]
        public string GetAllMsgs()
        {
            return _processor.GetAllMsgs();
        }

        [HttpPost]
        public void PostMessage([FromBody]NewMessage msg)
        {
            _processor.PostMessage(msg);
        }
    }
}