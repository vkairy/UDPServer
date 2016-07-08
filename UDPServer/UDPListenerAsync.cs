using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UDPServer {
    class UDPListenerAsync {
        private UdpClient udp_client = null;
        private bool running;
        private bool port_changed;
        private int port;

        public event LogReceivedHandler LogReceived;
        public delegate void LogReceivedHandler(IPEndPoint self, String message);

        public int Port {
            get { return this.port; }
            set {
                if (this.port != value) {
                    this.port = value;
                    this.port_changed = true;
                }
            }
        }

        public UDPListenerAsync(int port = 514) {
            this.running = false;
            this.Port = port;
        }

        private void DataReceived(IAsyncResult async_result) {
            if (this.running) {
                var client = new IPEndPoint(IPAddress.Any, 0);
                byte[] datagram = null;

                try {
                    datagram = udp_client.EndReceive(async_result, ref client);
                } catch {
                    Debug.WriteLine("Client {0} disconnected!", client.ToString());
                    return;
                }

                Debug.WriteLine("Client {0} connected!", client.ToString());
                string message = Encoding.ASCII.GetString(datagram, 0, datagram.Length);
                Debug.WriteLine("Message {0} received!", message);

                if (LogReceived != null) {
                    LogReceived(client, message);
                }

                udp_client.BeginReceive(new AsyncCallback(DataReceived), null);
            }
        }

        public void Start() {
            if (!this.running) {
                if (this.port_changed) {
                    if (udp_client != null) {
                        udp_client.Close();
                    }
                    udp_client = new UdpClient(new IPEndPoint(IPAddress.Any, this.Port));
                    this.port_changed = false;
                }

                Debug.WriteLine("Listener started on port {0}!", this.Port);
                this.running = true;

                Debug.WriteLine("UDPListener is waiting for a client...");
                udp_client.BeginReceive(new AsyncCallback(DataReceived), null);

                Debug.WriteLine("Listener started!");
            }
        }

        public void Stop() {
            if (this.running) {
                Debug.WriteLine("Stoping listener...");
                this.running = false;
            }
        }

    }
}
