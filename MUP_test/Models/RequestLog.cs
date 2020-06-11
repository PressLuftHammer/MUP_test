using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MUP_test.Models
{
    public class RequestLog
    {  
        public int RequestId { get; set; }
        public DateTime LogTime { get; set; }
        public int Status { get; set; }
        public string Comment { get; set; }
    }
}
