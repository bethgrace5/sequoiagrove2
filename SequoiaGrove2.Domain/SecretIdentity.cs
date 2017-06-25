namespace SequoiaGrove2.Domain
{
    public class SecretIdentity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Samurai Samurai { get; set; }
        public int SamuraiId { get; set; }
    }
}