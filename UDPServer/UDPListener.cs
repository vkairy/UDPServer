using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace UDPServer {
    class UDPListener {
        private UdpClient udp_client;
        private Thread worker_thread;
        private bool running;

        public event LogReceivedHandler LogReceived;
        public delegate void LogReceivedHandler(IPEndPoint self, String message);

        public int Port { get; set; }

        public UDPListener(int port = 514) {
            this.running = false;
            this.Port = port;
            udp_client = new UdpClient(new IPEndPoint(IPAddress.Any, this.Port));
        }

        public void Start() {
            if (!this.running) {
                Debug.WriteLine("Listener started on port {0}!", this.Port);
                this.running = true;

                worker_thread = new Thread(() => {
                    var client = new IPEndPoint(IPAddress.Any, 0);
                    Debug.WriteLine("UDPListener is waiting for a client...");
                    var datagram = udp_client.Receive(ref client);
                    Debug.WriteLine("Client {0} connected!", client.ToString());

                    while (this.running) {
                        string message = Encoding.ASCII.GetString(datagram, 0, datagram.Length);
                        Debug.WriteLine("Message {0} received!", message);

                        if (LogReceived != null) {
                            LogReceived(client, message);
                        }
                        datagram = udp_client.Receive(ref client);
                    }
                });

                worker_thread.Start();
                Debug.WriteLine("Listener started!");
            }
        }

        public void Stop() {
            if (this.running) {
                Debug.WriteLine("Stoping listener...");
                this.running = false;
                worker_thread.Join();
            }
        }

    }
}
