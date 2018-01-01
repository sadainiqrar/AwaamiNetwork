using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DigitalNetwork.DataModel
{
    public class NotificationModel
    {
        public int n_id { get; set; }
        public string message { get; set; }
        public string categoy { get; set; }
        public string uid { get; set; }
        public bool status { get; set; }
    }
}