using Crtz.Common.Models;
using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crtz.Client.Cmd
{
    public class StockTickerClient
    {
        public StockTickerClient()
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
    }
}
