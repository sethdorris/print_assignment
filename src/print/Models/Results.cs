using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace print.Models
{
    public class Results
    {
        public List<object> errors { get; set; }
        public List<object> messages { get; set; }
        public List<Datum> data { get; set; }
    }
}
