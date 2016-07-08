using System;
using System.Net;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace UDPServer {
    public partial class frmMain : Form {
        private UDPListenerAsync udp_listener;

        public frmMain() {
            InitializeComponent();
            udp_listener = new UDPListenerAsync();
            udp_listener.LogReceived += new UDPListenerAsync.LogReceivedHandler(udp_listener_LogReceived);
            Application.ApplicationExit += new EventHandler((sender, args) => {
                udp_listener.Stop();
            });
        }

        void udp_listener_LogReceived(IPEndPoint client, string message) {
            if (this.txtLog.InvokeRequired) {
                this.Invoke((MethodInvoker) delegate {
                    this.txtLog.AppendText(client.ToString() + ": " + message);
                    this.txtLog.ScrollToCaret();
                });
            } else {
                this.txtLog.AppendText(client.ToString() + ": " + message);
                this.txtLog.ScrollToCaret();
            }
        }

        private void mnuExit_Click(object sender, EventArgs e) {
            udp_listener.Stop();
            Application.Exit();
        }

        private void mnuChangePort_Click(object sender, EventArgs e) {
            udp_listener.Port = frmInputPort.GetNewPort(this, udp_listener.Port);
        }

        private void mnuStartStopListening_Click(object sender, EventArgs e) {
            if (Convert.ToInt32(mnuStartStopListening.Tag) == 0) {
                mnuStartStopListening.Tag = 1;
                mnuStartStopListening.Text = "&Stop listening";
                udp_listener.Start();
                this.Text = "UDP Server - listening to port " + udp_listener.Port;
            } else {
                mnuStartStopListening.Tag = 0;
                mnuStartStopListening.Text = "&Start listening";
                udp_listener.Stop();
                this.Text = "UDP Server";
            }
        }

        private void mnuClear_Click(object sender, EventArgs e) {
            this.txtLog.Clear();
        }
    }
}
