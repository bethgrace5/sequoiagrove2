using System;

namespace SequoiaGrove2.Domain
{
    public class Business
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime SignUpDate { get; set; }
        public DateTime SubscriptionEndDate { get; set; }
        public int HeadquarterAddressId { get; set; }
        public int BillingAddressId { get; set; }
        public string PrimaryPhone { get; set; }
        public string SecondaryPhone { get; set; }
        public string Fax { get; set; }
        public int TimeZoneId { get; set; }
    }
}