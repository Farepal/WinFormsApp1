using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace WinFormsApp1
{
    public static class TeacherAppSession
    {
        public static Teacher teacher { get; set; } = null;

        public static void Initialize(Teacher teacher)
        {
            TeacherAppSession.teacher = teacher;
        }

        public static void Reset()
        {
            teacher = null;
        }

        public static void UpdateTeacher()
        {
            IMongoCollection<Teacher> teacherCollection = TeachersCollection.Instance.Collection;

            ObjectId teacherId = ObjectId.Parse(teacher.Id);

            var filter = Builders<Teacher>.Filter.Eq("_id", teacherId);

            var update = Builders<Teacher>.Update
                .Set("name", teacher.Name)
                .Set("phoneNumber", teacher.PhoneNumber)
                .Set("deskripsi", teacher.Description)
                .Set("imageLink", teacher.ImageLink)
                .Set("subjects", teacher.Subjects);

            teacherCollection.UpdateOne(filter, update);
        }

        public static string getStatusById(string studentId)
        {
            foreach (Subject subject in teacher.Subjects)
            {
                foreach (SiswaYangDiajar siswaYangDiajar in subject.Students)
                {
                    if (siswaYangDiajar.StudentId == studentId)
                    {
                        return siswaYangDiajar.Status;
                    }
                }
            }

            return "";
        }
    }
}
