using System.Collections.Generic;
using PhotonCommon;
using PhotonFramework.Message.Interface;

namespace PhotonFramework.Message.Implementation
{
    public class EventMessage : IMessage
    {
        public Types.MessageTypes MessageType => Types.MessageTypes.EventMessage;
        public byte MessageCode { get; set; }
        public int MessageSubCode { get; set; }
        public Dictionary<byte, object> MessageParameters { get; set; }
    }
}