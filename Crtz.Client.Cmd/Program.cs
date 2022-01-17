using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Crtz.Client.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://localhost:6118";
            HubConnection connection = new HubConnection(url);
            IHubProxy myHub = connection.CreateHubProxy("SuperChatHub");

            Console.WriteLine("Press");
            Console.WriteLine($"'1: to start hub connection");
            Console.WriteLine($"'2: to send a 'Hello World'");
            Console.WriteLine($"'3: to sign AddMessageEvent");
            Console.WriteLine($"'4: to send and message on AddMessage channel");
            Console.WriteLine("Or, '0' to Quit");

            CancellationTokenSource cancellationToken = new CancellationTokenSource();
            while (!cancellationToken.Token.IsCancellationRequested)
            {
                try
                {
                    string command = Console.ReadLine();

                    switch (command)
                    {
                        case "1":
                            {
                                connection.Start().ContinueWith(p =>
                                {
                                    if (p.IsFaulted)
                                        Console.WriteLine("Some error ocurred");
                                    else
                                        Console.WriteLine("Connected");
                                }).Wait();

                                continue;
                            }

                        case "2":
                            {
                                myHub.Invoke<string>("Send", "Hello World").ContinueWith(p =>
                                {
                                    if (p.IsFaulted)
                                        Console.WriteLine("Some error ocurred");
                                    else
                                        Console.WriteLine(p.Result);
                                });

                                continue;
                            }

                        case "3":
                            {
                                myHub.On<string>("AddMessage", p =>
                                {
                                    Console.WriteLine($"Doing something: " + p);
                                });

                                continue;
                            }

                        case "4":
                            {
                                myHub.Invoke<string>("DoSomething", "something now").ContinueWith(p =>
                                {
                                    if (p.IsFaulted)
                                        Console.WriteLine("Some error ocurred");
                                });

                                continue;
                            }

                        case "0":
                            {
                                Console.WriteLine();
                                Console.WriteLine($"Finishing the application");

                                connection.Stop();
                                cancellationToken.Cancel();
                                break;
                            }

                        default:
                            continue;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unexpected error");
                }
            }
        }
    }
}
