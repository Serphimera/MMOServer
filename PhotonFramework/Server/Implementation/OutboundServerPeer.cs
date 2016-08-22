using Photon.SocketServer;
using Photon.SocketServer.ServerToServer;
using PhotonHostRuntimeInterfaces;

namespace PhotonFramework.Server.Implementation
{
    public class OutboundServerPeer : OutboundS2SPeer
    {
        public OutboundServerPeer(ApplicationBase application) : base(application)
        {
        }

        protected override void OnOperationRequest(OperationRequest operationRequest, SendParameters sendParameters)
        {
        }

        protected override void OnDisconnect(DisconnectReason reasonCode, string reasonDetail)
        {
        }

        protected override void OnEvent(IEventData eventData, SendParameters sendParameters)
        {
        }

        protected override void OnOperationResponse(OperationResponse operationResponse, SendParameters sendParameters)
        {
        }

        protected override void OnConnectionEstablished(object responseObject)
        {
        }

        protected override void OnConnectionFailed(int errorCode, string errorMessage)
        {
        }
    }
}