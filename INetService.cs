using System.Net;

namespace CoreBindShell
{
    interface INetService
    {
        void Start(IPAddress ipAddress, int port);
        void WriteLine(int clientId, string output);
        void AcceptOneClient();
        void InteractAsync(int clientId);
        void ReadSync(int clientId);
        void Write(int clientId, string output);
        void Shutdown();
    }
}