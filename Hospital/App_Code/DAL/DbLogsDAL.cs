using System;
using Data;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using BLL;
using MongoDB.Bson;
using MongoDB.Driver;
using DATE;

namespace DAL
{
    public class DbLogsDAL
    {
        public static int Save(DbLogs Tmp)
        {
            try
            {
                //  string ConnStrMongo = "mongodb://localhost:27017/";//הגדרת משתנה עם מחרוזת התחברות לבסיס הנתונים
                //string ConnStrMongo = ConfigurationManager.ConnectionStrings["ConnStrMongo"].ConnectionString;
                //var Client = new MongoClient(ConnStrMongo);//הגדרת אובייקט קליינט לור עבודה מול בסיס הנתונים
                //var Db = Client.GetDatabase("Hospital");//בחירת בסיס הנתונים מולו מעוניינים לעבוד

                //var LogsB = Db.GetCollection<BsonDocument>("DBLogs");
             
                var LogB = new BsonDocument()
                {

                    {"operation",Tmp.operation },
                    {"user",Tmp.user },
                    {"date",Tmp.date}, 
                };
                MongoContext mongoContext = new MongoContext();
                mongoContext.InsertOne("DBLogs",LogB);            
            }
       
            catch (Exception ex)
            {
                return 0;
            }
            return 1;

        }
           
    }
}