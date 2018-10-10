using System;
using System.Collections.Generic;
using System.Text;

namespace blastd.Models
{
    public class User
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public virtual ICollection<SponsorRelationship> Sponsors { get; set; }
        public virtual ICollection<SponsorRelationship> Reports { get; set; }

        public User()
        {
        }

        public User(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;
        }
    }
}
