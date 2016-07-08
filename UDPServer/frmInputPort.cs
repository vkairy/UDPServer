using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UDPServer {
    public partial class frmInputPort : Form {
        public frmInputPort() {
            InitializeComponent();
        }

        private void txtNewPort_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }

        public static int GetNewPort(IWin32Window parent, int default_port) {
            using (var input_port = new frmInputPort()) {
                input_port.txtNewPort.Text = Convert.ToString(default_port);

                if (input_port.ShowDialog(parent) == DialogResult.OK) {
                    int new_port;

                    if (Int32.TryParse(input_port.txtNewPort.Text, out new_port) &&
                        new_port > 0 && new_port < 65536) {
                        return new_port;
                    } else {
                        MessageBox.Show("Invalid port value!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return default_port;
        }
    }
}
