using DigitalNetwork.Models;
using DigitalNetwork.Scheduler;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DigitalNetwork.Controllers
{
    public class NotificationController : ApiController
    {

        [HttpGet]
        [Route("api/user/get/notification")]
        public List<get_notification_Result> get_Notification()
        {


            List<get_notification_Result> notifications = new List<get_notification_Result>();
            using (var data = new digimarketEntities1().get_notification())
            {
                notifications = data.ToList<get_notification_Result>();
            }
            return notifications;
        }

        [HttpPut]
        [Route("api/admin/push/notification")]
        public int Put_Notification([FromBody] Notification notification)
        { int result = 0;
           


            IHubContext _hubs1 = GlobalHost.ConnectionManager.GetHubContext<NotificationHub>();
            string uid;
            using (var data = new digimarketEntities1().get_uid(notification.uid))
            {
                uid = data.FirstOrDefault<string>(); 
            }

            result = new digimarketEntities1().add_notification(notification.message, notification.category, uid, true, System.DateTime.Now);
            List<get_notification_Result> notifications = new List<get_notification_Result>();
            using (var data = new digimarketEntities1().get_notification())
            {
                notifications = data.ToList<get_notification_Result>();
            }

            _hubs1.Clients.All.broadcastData(notifications);
          
            return result;
        }

        [HttpPost]
        [Route("api/admin/update/notification")]
        public int Update_Notification([FromBody] Notification notification)
        {

            return new digimarketEntities1().update_notification(notification.uid,notification.status);
        }
        [HttpDelete]
        [Route("api/admin/Delete/notification")]
        public int Delete_Notification([FromBody] Notification notification)
        {

            return new digimarketEntities1().delete_notification(notification.n_id);
        }
    }
}

