using System.Timers;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Threading;
using System.Text;

namespace MyMessengerBackend
{
    public class Program
    {
        public static List<string> PublicList = new List<string>();
        public static int cnt = 0;

        public static void Main(string[] args)
        {
            System.Timers.Timer t1 = new System.Timers.Timer();
            t1.Interval = (10000); 
            t1.Elapsed += new ElapsedEventHandler(t1_Elapsed);
            t1.AutoReset = true;
            t1.Start();
            CreateWebHostBuilder(args).Build().Run();
        }

        static void t1_Elapsed(object sender, ElapsedEventArgs e)
        {
            var newMessage = "Hello " + cnt++.ToString();
            PublicList.Add(newMessage);
        }
        

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
