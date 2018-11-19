using System.Timers;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;


namespace MyMessengerBackend
{
    public class Program
    {
        public static List<string> PublicList = new List<string>();

        public static void Main(string[] args)
        {
            Timer t1 = new Timer();
            t1.Interval = (10000); // 20 minutes...
            t1.Elapsed += new ElapsedEventHandler(t1_Elapsed);
            t1.AutoReset = true;
            t1.Start();
            CreateWebHostBuilder(args).Build().Run();
        }

        static void t1_Elapsed(object sender, ElapsedEventArgs e)
        {

             PublicList.Add("dfkjaghdkjsfgh;kgh");

        }
        

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
