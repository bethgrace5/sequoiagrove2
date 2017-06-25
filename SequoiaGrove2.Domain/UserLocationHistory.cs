using System;

namespace SequoiaGrove2.Domain
{
    public class UserLocationHistory
    {
        public int UserId { get; set; }
        public DateTime DateEmployed { get; set; }
        public DateTime DateUnemployed { get; set; }
        public int LocationId { get; set; }
    }
}