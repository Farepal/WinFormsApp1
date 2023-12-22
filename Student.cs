using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class GuruYangMengajar
    {
        public string Id { get; set; }
        public string Status { get; set; } = "Belum Dikonfirmasi";
    }
    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }

        [BsonElement("roles")]
        public string Roles { get; set; }
        [BsonElement("name")]
        public string Name { get; set; } = "Guest";
        [BsonElement("phoneNumber")]
        public string PhoneNumber { get; set; } = "Tidak ada nomor telepon";
        [BsonElement("imageLink")]
        public string ImageLink { get; set; } = "https://www.pngall.com/wp-content/uploads/5/User-Profile-PNG-Image.png";
        [BsonElement("guruYangMengajar")]
        public List<GuruYangMengajar> Teachers { get; set; } = new List<GuruYangMengajar>();
    }
}
