using System;

namespace SequoiaGrove2.Domain
{
    public class TemporaryLocationHourChange
    {
        public int Id { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string ReasonId { get; set; }
        public int LocationId { get; set; }
        public bool IsOpen { get; set; }
    }
}