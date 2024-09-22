using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Web;

namespace DATE
{
    public class MongoContext
    {
        public string ConnStrMongo { get; set; }// ConfigurationManager.ConnectionStrings["ConnStrMongo"].ConnectionString;
        public MongoClient Client {  get; set; }
        public string DbName {  get; set; } 
        public IMongoDatabase Db {  get; set; }
        public MongoContext() 
        {
            //שליפת מחרוזת התחברות
            ConnStrMongo= ConfigurationManager.ConnectionStrings["ConnStrMongo"].ConnectionString;
            //יצירת אובייקט הקליינט לגישה לבסיס הנתונים
            Client = new MongoClient(ConnStrMongo);
            //בחירת בסיס הנתונים מולו עובדים
            DbName = ConfigurationManager.AppSettings["ConnStrMongoDbName"].ToString();
            Db = Client.GetDatabase("DbName");//בחירת בסיס הנתונים מולו מעוניינים לעבוד
        }
        public int InsertOne(string CollectionName,BsonDocument Tmp)
        {
         
            // var Client = new MongoClient(ConnStrMongo);//הגדרת אובייקט קליינט לור עבודה מול בסיס הנתונים
          

            var Collection = Db.GetCollection<BsonDocument>(CollectionName);//יצירת חיבור לקולקשיין בשיטת ביסון
            Collection.InsertOne(Tmp);

            return 1;
        }


    }
}