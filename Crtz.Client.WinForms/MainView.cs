using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNet.SignalR.Client;
using Crtz.Common;

namespace Crtz.Client.WinForms
{
    public partial class MainView : Form
    {
        private string url = "http://localhost:6118";
        private HubConnection connection;
        private IHubProxy myHub;
        private IDisposable signalR;

        public MainView()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            connection = new HubConnection(url);
            myHub = connection.CreateHubProxy("SuperChatHub");
        }

        private void BtnStartSignalR_Click(object sender, EventArgs e)
        {
            connection.Start().ContinueWith(p =>
            {
                if (p.IsFaulted)
                    this.SafeInvoke(pp => Field_Return.Text = "Some error occurred");
                else
                    this.SafeInvoke(pp => Field_Return.Text = "Connected");
            });
        }

        private void BtnStopSignalR_Click(object sender, EventArgs e)
        {
            connection.Stop();
        }

        private void BtnStartAutoTickerData_Click(object sender, EventArgs e)
        {

        }

        private void BtnStopAutoTickerData_Click(object sender, EventArgs e)
        {

        }

        private void BtnSendOneTicker_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myHub.Invoke<string>("Send", "Hello World").ContinueWith(p =>
            {
                if (p.IsFaulted)
                    this.SafeInvoke(pp => Field_Return.Text = "Some error occurred");
                else
                    this.SafeInvoke(pp => Field_Return.Text = p.Result);
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.SafeInvoke(pp => Field_Return.Text = $"Starting Message event");

            myHub.On<string>("AddMessage", p =>
            {
                this.SafeInvoke(pp => Field_Return.Text = $"Message event: " + p);
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myHub.Invoke<string>("DoSomething", "something now").ContinueWith(p =>
            {
                if (p.IsFaulted)
                    this.SafeInvoke(pp => Field_Return.Text = "Some error occurred");
            });
        }
    }
}
