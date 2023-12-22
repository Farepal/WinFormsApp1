using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public static class StudentAppSession
    {
        public static Student student { get; set; } = null;

        public static void Initialize(Student student)
        {
            StudentAppSession.student = student;
        }

        public static void Reset()
        {
            student = null;
        }

        public static void UpdateStudent()
        {
            IMongoCollection<Student> studentCollection = StudentsCollection.Instance.Collection;

            ObjectId studentId = ObjectId.Parse(student.Id);

            var filter = Builders<Student>.Filter.Eq("_id", studentId);

            var update = Builders<Student>.Update
                .Set("name", student.Name)
                .Set("phoneNumber", student.PhoneNumber)
                .Set("imageLink", student.ImageLink)
                .Set("guruYangMengajar", student.Teachers);

            studentCollection.UpdateOne(filter, update);
        }

        public static string getStatusById(string teacherId)
        {
            foreach (GuruYangMengajar guru in student.Teachers)
            {
                if (guru.Id == teacherId)
                {
                    return guru.Status;
                }
            }

            return "";
        }
    }
}
