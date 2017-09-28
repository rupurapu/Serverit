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
            return _processor.GetMessage(pos).Comment;
        }

        [HttpGet]
        public string GetAllMsgs()
        {
            return _processor.GetAllMsgs();
        }

        [HttpPost("{pos}")]
        public void PostMessage([FromBody]NewMessage msg, int pos)
        {
            _processor.PostMessage(msg, pos);
        }
    }
}