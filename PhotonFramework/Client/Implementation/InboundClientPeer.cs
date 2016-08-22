using Photon.SocketServer;
using PhotonHostRuntimeInterfaces;

namespace PhotonFramework.Client.Implementation
{
    public class InboundClientPeer : ClientPeer
    {
        public InboundClientPeer(InitRequest initRequest) : base(initRequest)
        {
        }

        protected override void OnOperationRequest(OperationRequest operationRequest, SendParameters sendParameters)
        {
        }

        protected override void OnDisconnect(DisconnectReason reasonCode, string reasonDetail)
        {
        }
    }
}