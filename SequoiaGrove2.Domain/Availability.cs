using System;

namespace SequoiaGrove2.Domain
{
    public class Availability
    {
        public int UserId { get; set; }
        public int WeekdayId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

    }
}