using BLL;
using Data;
using DATE;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace DAL
{
    public class DoctorsDAL
    {
        public static void Save(Doctors Tmp)
        {
            string Sql = "";
            if (Tmp.Id == -1)
            {
                Sql = $"insert into T_Doctors(DId,DFname,DLname,DPhone,City,Domain,DSeniority)";
                Sql += $"values(N'{Tmp.DId}',N'{Tmp.DFname}',N'{Tmp.DLname}',N'{Tmp.DPhone}',N'{Tmp.City}',{Tmp.Domain},'{Tmp.DSeniority}')";


            }
            else
            {
                Sql = "Update T_Doctors set ";
                Sql += $" DId=N'{Tmp.DId}',";
                Sql += $" DFname=N'{Tmp.DFname}',";
                Sql += $" DLname=N'{Tmp.DLname}',";
                Sql += $" DPhone=N'{Tmp.DPhone}',";
                Sql += $" City=N'{Tmp.City}',";
                Sql += $" Domain={Tmp.Domain},";
                Sql += $" DSeniority=N'{Tmp.DSeniority}' ";
                Sql += $" Where Id={Tmp.Id}";
            }

            DbContext Db = new DbContext();
            Db.ExecuteNonQuery(Sql);

            if (Tmp.Id == -1)
            {
                Sql = $"select max(Id) from T_Doctors where DId=N'{Tmp.DId}'";

                Tmp.Id = (int)Db.ExecuteScalar(Sql);
            }
            Db.Close();
        }
        public static int Save(Doctors Tmp,string ContexName)
        {
            BsonDocument doctors = new BsonDocument()
            {
                { "DId",Tmp.DId },
                {"DFname",Tmp.DFname},
                 {"DLname",Tmp.DLname},
                 {"DPhone",Tmp.DPhone},
                 {"City",Tmp.City},
                 {"Domain",Tmp.Domain},
                 {"DSeniority",Tmp.DSeniority }
            };
            MongoContext mongoContext = new MongoContext();
            mongoContext.InsertOne("Doctors",doctors);
            int RecCount = 1;
            return RecCount;

        }

        public static List<Doctors> GetAll()
        {
            List<Doctors> lstDoctor = new List<Doctors>();

            string Sql = "select * from T_Doctors";
            DbContext Db = new DbContext();
            DataTable Dt = Db.Execute(Sql);

            //נעבור על טבלת הנתונים שורה שורה נעביר אותם אותם לתוך רשימה של מוצרים

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                lstDoctor.Add(new Doctors()
                {
                    Id = (int)Dt.Rows[i]["Id"],
                    DId = Dt.Rows[i]["DId"]+"",
                    DFname = Dt.Rows[i]["DFname"] + "",
                    DLname = Dt.Rows[i]["DLname"] + "",
                    DPhone = Dt.Rows[i]["DPhone"]+"",
                    City = Dt.Rows[i]["City"] + "",
                    Domain = int.Parse(Dt.Rows[i]["Domain"] + ""),
                    DSeniority =DateTime.Parse(Dt.Rows[i]["DSeniority"]+""),

                });
            }

            Db.Close();
            return lstDoctor;

        }
        public static Doctors GetByiD(int Id)
        {
            Doctors tmp = null;

            string Sql = $"select * from t_Doctors where Id={Id}";

            DbContext Db = new DbContext();
            DataTable Dt = Db.Execute(Sql);

            if (Dt.Rows.Count > 0)
            {
                tmp = new Doctors()
                {
                    Id = (int)Dt.Rows[0]["Id"],
                    DId = Dt.Rows[0]["DId"] + "",
                    DFname = Dt.Rows[0]["DFname"] + "",
                    DLname = Dt.Rows[0]["DLname"] + "",
                    DPhone = Dt.Rows[0]["DPhone"] + "",
                    City = Dt.Rows[0]["City"] + "",
                    Domain = int.Parse(Dt.Rows[0]["Domain"] + ""),
                    DSeniority = DateTime.Parse(Dt.Rows[0]["DSeniority"] + ""),
                };
            }
            Db.Close();
            return tmp;


        }

        public static int DeleteByiD(int Id)
        {
            int RetVal = 0;
            string Sql = $"delete from t_Doctors where Id={Id}";
            DbContext Db = new DbContext();
            RetVal = Db.ExecuteNonQuery(Sql);
            Db.Close();
            return RetVal;
        }

    }
}