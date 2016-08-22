using System.Collections.Generic;
using PhotonCommon;

namespace PhotonFramework.Message.Interface
{
    public interface IMessage
    {
        Types.MessageTypes MessageType { get; }
        byte MessageCode { get; set; }
        int MessageSubCode { get; set; }
        Dictionary<byte, object> MessageParameters { get; set; }
    }
}