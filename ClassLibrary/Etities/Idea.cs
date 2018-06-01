using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    abstract class Idea
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public User Owner { get; set; }

        //public Status Status { get; set; } //draft, cancelled, confirmed, posted, life, outdate

    }

    class DraftIdea : Idea
    {
        //public DraftIdea(): base: Status = 1 ;
    }

    class PostedIdea : Idea
    {
        public DateTime Start_date { get; set; }
        public DateTime Deadline { get; set; }
        // public Rating Rating { get; set; }
        public User[] Sponsors { get; set; }
        public User[] Followers { get; set; }
        public string[] Images { get; set; }
        public decimal Funds { get; set; }
    }

}
