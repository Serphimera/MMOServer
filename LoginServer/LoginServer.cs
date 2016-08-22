using ExitGames.Logging;
using PhotonFramework.Application.Interface;

namespace LoginServer
{
    public class LoginServer : IServerApplication
    {
        private ILogger Logger { get; }

        public LoginServer(ILogger logger)
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
