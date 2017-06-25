namespace SequoiaGrove2.Domain
{
    public class Location
    {
        public int Id { get; set; }
        public int BusinessId { get; set; }
        public int AddressId { get; set; }
        public string Name { get; set; }
        public string PrimaryPhone { get; set; }
        public string SecondaryPhone { get; set; }
        public string Fax { get; set; }
        public int TimeZoneId { get; set; }
    }
}