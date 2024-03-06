using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;

namespace OPCClient2
{
    class MongoDbHelper
    {
        private IMongoDatabase database;
        
        public MongoDbHelper(string databaseName)
        {
            this.database = GetDb(databaseName);
        }

        public IMongoDatabase GetDb(string databaseName)
        {
            var db = new MongoClient(databaseName).GetDatabase(new MongoUrlBuilder(databaseName).DatabaseName);
            return db;
        }

        private IMongoCollection<T> GetCollection<T>(string collName)
        {
            return database.GetCollection<T>(collName);
        }

        public List<T> findAll<T>(string tableName)
        {
            List<T> list = new List<T>();
            try
            {
                var collection = GetCollection<T>(collName: tableName);
                FilterDefinition<T> filter = Builders<T>.Filter.Empty;
                list = collection.Find<T>(filter).ToList<T>();
            }
            catch
            {
                Console.WriteLine("find all 错误");
            }
            return list;
        }

        public DbMessage Insert<T>(string collName,T document)
        {
            try
            {
                var coll = GetCollection<T>(collName);
                coll.InsertOne(document);
                return new DbMessage { Ex = string.Empty, iFlg = 1};
            }
            catch(Exception ex)
            {
                Console.WriteLine("insert 错误");
                return new DbMessage { Ex = ex.Message, iFlg = -101 };
            }
        }

        public DbMessage InsertMany<T>(string collName, List<T> documents)
        {
            try
            {
                var coll = GetCollection<T>(collName);
                coll.InsertMany(documents);
                return new DbMessage { Ex = string.Empty, iFlg = documents.Count };
            }
            catch(Exception ex)
            {
                Console.WriteLine("insert 错误");
                return new DbMessage { Ex = ex.Message, iFlg = -101 };
            }
        }
        public class DbMessage
        {
            public long iFlg { get; set; }
            public string Ex { get; set; }
        }
    }
}
