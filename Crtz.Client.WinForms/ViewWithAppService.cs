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
    public partial class ViewWithAppService : Form
    {
        private SignalRClientService signalRClientService;

        public ViewWithAppService()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            signalRClientService = new SignalRClientService();
        }

        private void BtnStartSignalR_Click(object sender, EventArgs e)
        {
            signalRClientService.Connect();
        }

        private void BtnStopSignalR_Click(object sender, EventArgs e)
        {
            signalRClientService.Disconnect();
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
            this.SafeInvoke(pp => Field_Return.Text = signalRClientService.HelloWorld_Send());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.SafeInvoke(pp => Field_Return.Text = $"Starting Message event");

            Action<string> actionResult = new Action<string>(p =>
            {
                this.SafeInvoke(pp => Field_Return.Text = p);
            });

            signalRClientService.AddMessage_Event(actionResult);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            signalRClientService.DoSomething_Send();
        }
    }
}
