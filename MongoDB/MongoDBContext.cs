using MongoDB.Driver;
using System.Runtime.ExceptionServices;

namespace WinFormsApp1
{
    public sealed class MongoDBContext
    {
        private static readonly MongoDBContext instance = new MongoDBContext();
        private IMongoDatabase database;

        private MongoDBContext()
        {
            string connectionString = AppConfig.Instance.GetSetting("DATABASE:URI");
            MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(connectionString));
            MongoClient client = new MongoClient(settings);

            string databaseName = AppConfig.Instance.GetSetting("DATABASE:NAME");
            database = client.GetDatabase(databaseName);
        }

        public static MongoDBContext Instance
        {
            get
            {
                return instance;
            }
        }

        public IMongoDatabase Database
        {
            get
            {
                return database;
            }
        }
    }
}
