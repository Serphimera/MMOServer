using ExitGames.Logging;
using Photon.SocketServer;

namespace PhotonFramework.Client.Interface
{
    public interface IClientPeerFactory
    {
        T CreateClientPeer<T>(InitRequest initRequest, ILogger logger) where T : PeerBase;
    }
}