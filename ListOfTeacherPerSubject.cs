using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public static class ListOfTeacherPerSubject
    {
        public static List<Teacher> teachers { get; set; } = new List<Teacher>();

        public static void Initialize(string nameOfSubject)
        {
            var filter = Builders<Teacher>.Filter.ElemMatch(
                t => t.Subjects,
                Builders<Subject>.Filter.Eq(subject => subject.Name, nameOfSubject)
            );
            var teacherCollection = TeachersCollection.Instance.Collection;
            teachers = teacherCollection.Find(filter).ToList();
        }

        public static void Reset()
        {
            teachers = new List<Teacher>();
        }
    }
}
