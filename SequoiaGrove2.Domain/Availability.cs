using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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