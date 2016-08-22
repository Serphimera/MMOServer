using ExitGames.Logging;
using Photon.SocketServer;
using Photon.SocketServer.ServerToServer;
using PhotonFramework.Server.Implementation;

namespace PhotonFramework.Server.Interface
{
    public interface IServerPeerFactory
    {
        T CreateServerPeer<T>(InitRequest initRequest, ILogger logger) where T : InboundServerPeer;
        T CreateServerPeer<T>(ApplicationBase application, ILogger logger) where T : OutboundServerPeer;
    }
}