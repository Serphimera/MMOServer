using System;

namespace PhotonCommon
{
    public class Types
    {
        [Flags]
        public enum MessageTypes
        {
            RequestMessage = 0x01,
            ResponseMessage = 0x02,
            EventMessage = 0x03
        }
    }
}