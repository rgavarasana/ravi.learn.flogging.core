using System;
using System.Collections.Generic;

namespace ravi.learn.flogging.core.dto
{
    public class FlogDetail
    {
        public FlogDetail()
        {
            TimeStamp = DateTime.UtcNow;
        }

        public DateTime TimeStamp { get; }
        public string Message { get; set; }
        public string Product { get; set; }
        public string Layer { get; set; }
        public string Location { get; set; }
        public string HostName { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public long? ElapsedTimeInMilliseconds { get; set; }
        public string CorrelationId { get; set; }
        public Dictionary<string, object> AdditionalInfo { get; set; }

    }
}
