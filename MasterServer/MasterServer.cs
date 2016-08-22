using ExitGames.Logging;
using PhotonFramework.Application.Interface;

namespace MasterServer
{
    public class MasterServer : IServerApplication
    {
        private ILogger Logger { get; }

        public MasterServer(ILogger logger)
        {
            Logger = logger;
        }

        public void Setup()
        {
            
        }

        public void OnServerConnectionFailed(int errorCode, string errorMessage, object state)
        {
            
        }

        public void OnStopRequested()
        {
            
        }

        public void TearDown()
        {
            
        }
    }
}
