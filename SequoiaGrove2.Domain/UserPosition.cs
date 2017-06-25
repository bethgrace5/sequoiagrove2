using System;

namespace SequoiaGrove2.Domain
{
    public class UserPosition
    {
        public int UserId { get; set; }
        public int PositionId { get; set; }
        public DateTime DateAcquired { get; set; }
        public DateTime DateRemoved { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsTraining { get; set; }
    }
}