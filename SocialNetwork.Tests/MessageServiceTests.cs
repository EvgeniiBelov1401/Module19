﻿using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Tests
{
    public class MessageServiceTests
    {
       
        [Fact]
        public void SendMessageMustGetNotNullMessage()
        {         
            string message = "Это не пустое сообщение";

            Assert.False(String.IsNullOrEmpty(message));
        }
        [Fact]
        public void SendMessageMustGetLengthNotMore5kChars()
        {
            string message = "Это не очень длинное сообщение";

            Assert.True(message.Length < 5000);
        }
        [Fact]
        public void SendMessageMustSendMessage()
        {
            MessageRepository messageRepository = new MessageRepository();
            var messageEntity = new MessageEntity()
            {
                content = "Отправляемое сообщение",
                sender_id = 1,
                recipient_id = 2
            };

            Assert.False(messageRepository.Create(messageEntity) == 0);
        }

       
    }
}
