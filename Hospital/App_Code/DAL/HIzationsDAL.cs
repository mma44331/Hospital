using BLL;
using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DAL
{
    public class HIzationsDAL
    {
        public static void Save(HIzations Tmp)
        {
            string Sql = "";
            if (Tmp.HId == -1)
            {
                Sql = $"insert into T_HIzations(Id,DReception,DId,TDescription,TSummary,DRelease)";
                Sql += $"values(N'{Tmp.Id}',N'{Tmp.DReception}',N'{Tmp.DId}',N'{Tmp.TDescription}',N'{Tmp.TSummary}',N'{Tmp.DRelease}')";


            }
            else
            {
                Sql = "Update T_HIzations set ";
                Sql += $" Id={Tmp.Id},";
                Sql += $" DReception='{Tmp.DReception}',";
                Sql += $" DId=N{Tmp.DId},";
                Sql += $" TDescription=N'{Tmp.TDescription}',";
                Sql += $" TSummary=N'{Tmp.TSummary}',";
                Sql += $" DRelease=N'{Tmp.DRelease}',";
                Sql += $" Where HId={Tmp.HId}";
            }

            DbContext Db = new DbContext();
            Db.ExecuteNonQuery(Sql);

            if (Tmp.HId == -1)
            {
                Sql = $"select max(HId) from T_HIzations where Id=N'{Tmp.Id}'";

                Tmp.HId = (int)Db.ExecuteScalar(Sql);
            }
            Db.Close();
        }

        public static List<HIzations> GetAll()
        {
            List<HIzations> lstHIzations = new List<HIzations>();

            string Sql = "select * from T_HIzations";
            DbContext Db = new DbContext();
            DataTable Dt = Db.Execute(Sql);

            //נעבור על טבלת הנתונים שורה שורה נעביר אותם אותם לתוך רשימה של מוצרים

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                lstHIzations.Add(new HIzations()
                {
                    HId = (int)Dt.Rows[i]["HId"],
                    Id = Dt.Rows[i]["Id"]+"",
                    DReception = DateTime.Parse (Dt.Rows[i]["DReception"] + ""),
                    DId = (int)Dt.Rows[i]["DId"],
                    TDescription = Dt.Rows[i]["TDescription"] + "",
                    TSummary = Dt.Rows[i]["TSummary"] + "",
                    DRelease = DateTime.Parse(Dt.Rows[i]["DRelease"] + ""),

                });
            }

            Db.Close();
            return lstHIzations;

        }
        public static HIzations GetByiD(int Id)
        {
            HIzations tmp = null;

            string Sql = $"select * from t_HIzations where Id={Id}";

            DbContext Db = new DbContext();
            DataTable Dt = Db.Execute(Sql);

            if (Dt.Rows.Count > 0)
            {
                tmp = new HIzations()
                {
                    Id = (int)Dt.Rows[0]["Id"],
                    DId = (int)Dt.Rows[0]["DId"],
                    DFname = Dt.Rows[0]["DFname"] + "",
                    DLname = Dt.Rows[0]["DLname"] + "",
                    DPhone = Dt.Rows[0]["DPhone"] + "",
                    City = Dt.Rows[0]["City"] + "",
                    Domain = Dt.Rows[0]["Domain"] + "",
                    DSeniority = DateTime.Parse(Dt.Rows[0]["DSeniority"] + ""),
                };
            }
            Db.Close();
            return tmp;


        }

        public static int DeleteByiD(int Id)
        {
            int RetVal = 0;
            string Sql = $"delete from t_HIzations where Id={Id}";
            DbContext Db = new DbContext();
            RetVal = Db.ExecuteNonQuery(Sql);
            Db.Close();
            return RetVal;
        }

    }
}