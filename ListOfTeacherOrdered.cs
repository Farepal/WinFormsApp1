using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace WinFormsApp1
{
    public class ListOfTeacherOrdered
    {
        public static List<Teacher> teachers { get; set; } = new List<Teacher>();

        public static void Initialize()
        {
            foreach(GuruYangMengajar guru in StudentAppSession.student.Teachers)
            {
                IMongoCollection<Teacher> teacherCollection = TeachersCollection.Instance.Collection;
                ObjectId teacherId = ObjectId.Parse(guru.Id);
                var filter = Builders<Teacher>.Filter.Eq("_id", teacherId);
                var foundedTeacher = teacherCollection.Find(filter).FirstOrDefault();
                teachers.Add(foundedTeacher);
            }
        }

        public static void Reset()
        {
            teachers = new List<Teacher>();
        }
    }
}
