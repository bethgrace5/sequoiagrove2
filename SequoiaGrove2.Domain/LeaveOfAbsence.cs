using System;

namespace SequoiaGrove2.Domain
{
    public class LeaveOfAbsence
    {
        public int Id { get; set; }
        public int RequestedBy { get; set; }
        public int RespondedBy { get; set; }
        public bool IsApproved { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
    }
}