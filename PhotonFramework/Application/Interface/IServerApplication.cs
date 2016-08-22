namespace PhotonFramework.Application.Interface
{
    public interface IServerApplication
    {
        void Setup();
        void OnServerConnectionFailed(int errorCode, string errorMessage, object state);
        void OnStopRequested();
        void TearDown();
    }
}