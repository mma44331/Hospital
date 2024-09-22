using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Hospital
{
    public partial class Mongo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                //    string ConnStr = "mongodb://localhost:27017/";//הגדרת משתנה עם מחרוזת התחברות לבסיס הנתונים
                //    var Client = new MongoClient(ConnStr);//הגדרת אובייקט קליינט לור עבודה מול בסיס הנתונים
                //    var Db = Client.GetDatabase("Hospital");//בחירת בסיס הנתונים מולו מעוניינים לעבוד
                //    //var Logs = Db.GetCollection<DbLogs>("DBLogs");
                //var Log = new DbLogs()
                //{
                //    _id = "abcd123",
                //    user =6,
                //    operation="delete",
                //    date=DateTime.Now //.ToString("dd/MM/yyyy")
                //};
                //Logs.InsertOne(Log);
                //var LogsB = Db.GetCollection<BsonDocument>("DBLogs");
                //var LogB = new BsonDocument()
                //{
                //   // {"_id","abc333"},
                //    {"operation","select" },
                //    {"user",18 },
                //    {"date",DateTime.Now }
                //};
                //LogsB.InsertOne(LogB);

                DbLogs Tmp = new DbLogs()
                {
                    operation = "insert",
                    date = DateTime.Now.AddDays(-7),
                    user = 25                  

                };
                Tmp.Save();

            }
        }
    }
}