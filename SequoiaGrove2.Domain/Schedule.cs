using System;

namespace SequoiaGrove2.Domain
{
    public class Schedule
    {
        public int PublishedBy { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DatePublished { get; set; }
        public int LocationId { get; set; }
    }
}