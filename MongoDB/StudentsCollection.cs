using MongoDB.Bson;
using MongoDB.Driver;

namespace WinFormsApp1
{
    public sealed class StudentsCollection
    {
        private static readonly StudentsCollection instance = new StudentsCollection();
        IMongoDatabase database;
        IMongoCollection<Student> collection;

        public StudentsCollection()
        {
            database = MongoDBContext.Instance.Database;
            collection = database.GetCollection<Student>("students");
        }

        public static StudentsCollection Instance
        {
            get
            {
                return instance;
            }
        }

        public IMongoCollection<Student> Collection
        {
            get
            {
                return collection;
            }
        }
    }
}
