using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace print.Models
{
    public class Webhook
    {
        public string type { get; set; }
        public string callbackUri { get; set; }
        public CallbackHeaders callbackHeaders { get; set; }
    }
}
