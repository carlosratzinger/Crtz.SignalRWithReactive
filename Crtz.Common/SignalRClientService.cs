using Crtz.Common.Models;
using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crtz.Common
{
    public class SignalRClientService
    {
        private HubConnection connection;
        private IHubProxy proxy;
        private readonly object connectionLock = new object();

        public SignalRClientService()
        {
            string url = "http://localhost:6118";
            string hubName = "StockTickerHub";

            using (var hubConnection = new HubConnection(url))
            {
                IHubProxy stockTickerProxy = hubConnection.CreateHubProxy(hubName);
                stockTickerProxy.On<Stock>("UpdateStockPrice", stock => Console.WriteLine($"Updated {stock.Symbol} for new price {stock.Price}"));
                hubConnection.Start();
            }
        }

        #region Connect/Disconnect

        public void Connect()
        {
            string url = "http://localhost:6118";
            string hubName = "SuperChatHub";

            try
            {
                lock (connectionLock)
                {
                    if (connection == null || connection.State == ConnectionState.Disconnected)
                    {
                        connection = new HubConnection(url);
                        proxy = connection.CreateHubProxy(hubName);
                        connection.Start();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Error on trying to connect to '{url}/{hubName}'", ex);
            }
        }

        private void Connection_Keep()
        {
            if (connection == null || connection.State != ConnectionState.Connected)
            {
                Connect();
            }
        }

        public void Disconnect()
        {
            try
            {
                connection.Stop();
            }
            finally
            {
                connection = null;
            }
        }

        #endregion

        public string HelloWorld_Send()
        {
            Connection_Keep();

            return proxy.Invoke<string>("Send", "Hello World").ContinueWith(p =>
            {
                if (p.IsFaulted)
                    return "Some error occurred";
                else
                    return p.Result;
            }).GetAwaiter().GetResult();
        }

        public void AddMessage_Event(Action<string> action)
        {
            Connection_Keep();

            proxy.On<string>("AddMessage", action);
        }

        public string DoSomething_Send()
        {
            Connection_Keep();

            return proxy.Invoke<string>("DoSomething", "Something now").ContinueWith(p =>
            {
                if (p.IsFaulted)
                    return "Some error occurred";
                else
                    return p.Result;
            }).GetAwaiter().GetResult();
        }
    }
}