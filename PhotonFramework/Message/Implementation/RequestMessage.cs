using System.Collections.Generic;
using PhotonCommon;
using PhotonFramework.Message.Interface;

namespace PhotonFramework.Message.Implementation
{
    public class RequestMessage : IMessage
    {
        public Types.MessageTypes MessageType => Types.MessageTypes.RequestMessage;
        public byte MessageCode { get; set; }
        public int MessageSubCode { get; set; }
        public Dictionary<byte, object> MessageParameters { get; set; }
    }
}