using System;

namespace SequoiaGrove2.Domain
{
    public class UserScheduledForShift
    {
        public int UserId { get; set; }
        public int ShiftId { get; set; }
        public DateTime Date { get; set; }
    }
}