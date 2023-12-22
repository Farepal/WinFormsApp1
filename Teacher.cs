using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public class SiswaYangDiajar
    {
        public string StudentId { get; set; }
        public string Status { get; set; } = "Belum Dikonfirmasi";
    }

    public class Subject
    {
        public string Name { get; set; }
        public string PricePerHour { get; set; }
        public List<SiswaYangDiajar> Students { get; set; } = new List<SiswaYangDiajar>();

        // Properti lain yang mungkin diperlukan untuk mata pelajaran
    }

    public class Teacher
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

        [BsonElement("deskripsi")]
        public string Description { get; set; } = "Tidak ada deskripsi";

        [BsonElement("imageLink")]
        public string ImageLink { get; set; } = "https://www.pngall.com/wp-content/uploads/5/User-Profile-PNG-Image.png";

        [BsonElement("subjects")]
        public List<Subject> Subjects { get; set; } = new List<Subject>();
    }
}

