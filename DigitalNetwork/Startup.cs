﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Owin;
using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.AspNet.SignalR;
using DigitalNetwork.Scheduler;
using System.Web.Http;

[assembly: OwinStartup(typeof(DigitalNetwork.Startup))]

namespace DigitalNetwork
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);



            GlobalConfiguration.Configure(WebApiConfig.Register);

            GlobalConfiguration.Configuration.EnsureInitialized();


            var hubConfiguration = new HubConfiguration();
            hubConfiguration.EnableDetailedErrors = true;


            app.MapSignalR(hubConfiguration);


            RealtimeEngine realtime = new RealtimeEngine(10000);
            Task.Factory.StartNew(async () => await realtime.OnDataMonitor());
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.UseShellExecute = false;
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.WorkingDirectory = @"C:\Users\AJ\source\repos\Awami Network\nodejs";
            startInfo.Arguments = @"/c node app";
            process.StartInfo = startInfo;
            process.Start();
         
        }
    }
}