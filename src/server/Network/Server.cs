using System.Net;
using System.Net.Sockets;

namespace server.Network
{
    public abstract class Server
    {
        // Private field for the listener socket
        private Socket _listener;

        // Public method to start the server
        public void Start(int port)
        {
            // Create a new listener socket and bind it to the specified port
            _listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _listener.Bind(new IPEndPoint(IPAddress.Any, port));

            // Start listening for incoming connections
            _listener.BeginAccept(OnAccept, null);
        }

        // Callback for the BeginAccept method
        private void OnAccept(IAsyncResult result)
        {
            // Create a new socket for the incoming connection
            Socket socket = _listener.EndAccept(result);

            // Start receiving data
            socket.BeginReceive(OnReceive, socket);
        }

        // Callback for the BeginReceive method
        private void OnReceive(IAsyncResult result)
        {
            // Get the socket and receive buffer
            Socket socket = (Socket)result.AsyncState;
            byte[] buffer = new byte[1024];

            // Receive data from the socket
            int bytesReceived = socket.EndReceive(result);
            if (bytesReceived > 0)
            {
                // Process the received data
                // TODO: Add code here to process the received data

                // Send a response if necessary
                // TODO: Add code here to send a response

                // Start receiving data again
                socket.BeginReceive(OnReceive, socket);
            }
        }
    }
}