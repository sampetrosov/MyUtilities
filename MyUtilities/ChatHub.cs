// Copyright (c) 2017 Samvel Petrosov
// Created at 8/10/2017 10:00 AM
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUtilities
{
    class ChatHub
    {
        public ChatHub()
        {
            string url = "http://127.0.0.1:8088/";
            var server = new Server(url);

            // Map the default hub url (/signalr)
            server.MapHubs();

            // Start the server
            server.Start();

            Console.WriteLine("Server running on {0}", url);

            // Keep going until somebody hits 'x'
            while (true)
            {
                ConsoleKeyInfo ki = Console.ReadKey(true);
                if (ki.Key == ConsoleKey.X)
                {
                    break;
                }
            }
        }
    }

    [HubName("CustomHub")]
    public class MyHub : Hub
    {
        public string Send(string message)
        {
            return message;
        }

        public void DoSomething(string param)
        {
            Clients.All.addMessage(param);
        }
    }
}

