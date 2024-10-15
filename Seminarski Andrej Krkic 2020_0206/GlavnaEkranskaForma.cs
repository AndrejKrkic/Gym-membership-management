using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminarski_Andrej_Krkic_2020_0206
{
    public partial class GlavnaEkranskaForma : Form
    {
        private Server server;

        public GlavnaEkranskaForma()
        {
            InitializeComponent();
            server = new Server();
            StartButton_Click(new object(), new EventArgs()); //ovo obrisati kasnije, samo radi testa
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StopButton.Enabled = true;
            StartButton.Enabled = false;
            StatusServeraTextBox.Text = "Server je pokrenut.";
            server.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StopButton.Enabled = false;
            StartButton.Enabled = true;
            StatusServeraTextBox.Text = "Server je zaustavljen.";
            server.Stop();
        }
    }
}
