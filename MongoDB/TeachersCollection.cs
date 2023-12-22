using MongoDB.Bson;
using MongoDB.Driver;
using System;

namespace WinFormsApp1
{
	public sealed class TeachersCollection
	{
		private static readonly TeachersCollection instance = new TeachersCollection();
		IMongoDatabase database;
		IMongoCollection<Teacher> collection;

		public TeachersCollection()
		{
			database = MongoDBContext.Instance.Database;
			collection = database.GetCollection<Teacher>("teachers");
		}

		public static TeachersCollection Instance
		{
			get
			{
				return instance;
			}
		}

		public IMongoCollection<Teacher> Collection
		{
			get
			{
				return collection;
			}
		}
	}
}
