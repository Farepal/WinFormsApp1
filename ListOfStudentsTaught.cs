using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class ListOfStudentsTaught
    {
        public static List<Student> students { get; set; } = new List<Student>();

        public static void Initialize()
        {
            if (TeacherAppSession.teacher.Subjects.Count != 0)
            {
                foreach (SiswaYangDiajar siswaYangDiajar in TeacherAppSession.teacher.Subjects[0].Students)
                {
                    IMongoCollection<Student> studentCollection = StudentsCollection.Instance.Collection;
                    ObjectId studentId = ObjectId.Parse(siswaYangDiajar.StudentId);
                    var filter = Builders<Student>.Filter.Eq("_id", studentId);
                    var foundedStudent = studentCollection.Find(filter).FirstOrDefault();
                    students.Add(foundedStudent);
                }
            }
        }

        public static void Reset()
        {
            students = new List<Student>();
        }
    }
}
