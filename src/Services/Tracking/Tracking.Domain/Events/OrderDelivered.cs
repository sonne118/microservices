using System;
using System.Collections.Generic;
using System.Text;

namespace Tracking.Domain.Events
{
    public class OrderDelivered : EventBase
    {
        public string SignedBy{ get; set; }

        public OrderDelivered(string bookingId, string description,
          Guid messageId, string messageType, DateTime datetime ,string signedBy)
        {
            BookingId = bookingId;
            Description = description;
            SignedBy = signedBy;
            base.MessageType = messageType;
            base.MessageId = messageId;
            base.Date = datetime;
        }

    }
}
