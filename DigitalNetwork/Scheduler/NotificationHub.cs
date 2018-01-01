using DigitalNetwork.Models;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace DigitalNetwork.Scheduler
{
    public class NotificationHub : Hub
    {
       

        public void SendData(List<get_notification_Result> notificationData)
        {
            Clients.All.broadcastData(notificationData);
        }

        public void Heartbeat()
        {
            Clients.All.heartbeat();
        }

        public override Task OnConnected()
        {
            return (base.OnConnected());
        }
    }
}