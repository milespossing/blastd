namespace blastd.Models
{
    public class SponsorRelationship
    {
        public int ID { get; set; }
        public User Sponsor { get; set; }
        public User Accountable { get; set; }
    }
}