
using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;



namespace ClassLibrary
{
    public class User
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Picture { get; set; }
        public string Location { get; set; }
        public string Website { get; set; }
        public string Role { get; set; }
        public string ImageId { get; set; } // ссылка на изображение

        public bool HasImage()
        {
            return !String.IsNullOrWhiteSpace(ImageId);
        }
    }
}
