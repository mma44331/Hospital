using BLL;
using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Xml.Linq;

namespace DAL
{
    public class PatzientDAL
    {
        public static void Save(Patzient Tmp)
        {
            string Sql = "";
            if (Tmp.PCId == -1)
            {
                Sql = $"insert into T_Patzient(PId,PFname,PLname,PAddress,PCity,PAge,Phone,PGender,Platoon,DId,PCarNumber)";
                Sql += $"values(N'{Tmp.PId}',N'{Tmp.PFname}',{Tmp.PLname},N'{Tmp.PAddress}',N'{Tmp.PCity}','{Tmp.PAge}',N'{Tmp.Phone}',N'{Tmp.PGender}',{Tmp.Platoon},{Tmp.DId},N'{Tmp.PCarNumber}')";


            }
            else
            {
                Sql = "Update T_Patzient set ";
                Sql += $" PId=N'{Tmp.PId}',";
                Sql += $" PFname=N'{Tmp.PFname}',";
                Sql += $" PLname=N'{Tmp.PLname}',";
                Sql += $" PAddress=N'{Tmp.PAddress}',";
                Sql += $" PCity=N'{Tmp.PCity}',";
                Sql += $" PAge='{Tmp.PAge}',";
                Sql += $" Phone=N'{Tmp.Phone}',";
                Sql += $" PGender=N'{Tmp.PGender}',";
                Sql += $" Platoon={Tmp.Platoon},";
                Sql += $" DId={Tmp.DId},";
                Sql += $" PCarNumber=N'{Tmp.PCarNumber}'";
                Sql += $" Where PCId={Tmp.PCId}";
            }

            DbContext Db = new DbContext();
            Db.ExecuteNonQuery(Sql);

            if (Tmp.PCId == -1)
            {
                Sql = $"select max(PCId) from T_Patzient where PId=N'{Tmp.PId}'";

                Tmp.PCId = (int)Db.ExecuteScalar(Sql);
            }
            Db.Close();
        }

        public static List<Patzient> GetAll()
        {
            List<Patzient> lstPatzient = new List<Patzient>();

            string Sql = "select * from T_Patzient";
            DbContext Db = new DbContext();
            DataTable Dt = Db.Execute(Sql);

            //נעבור על טבלת הנתונים שורה שורה נעביר אותם אותם לתוך רשימה של מוצרים

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                lstPatzient.Add(new Patzient()
                {
                    PCId = (int)Dt.Rows[i]["PCId"],
                    PId = Dt.Rows[i]["PId"] + "",
                    PFname = Dt.Rows[i]["PFname"] + "",
                    PLname = Dt.Rows[i]["PLname"] + "",
                    PAddress = Dt.Rows[i]["PAddress"] + "",
                    PCity = Dt.Rows[i]["PCity"] + "",
                    PAge = float.Parse(Dt.Rows[i]["PAge"] + ""),
                    Phone = Dt.Rows[i]["Phone"] + "",
                    PGender = int.Parse(Dt.Rows[i]["PGender"]+""),
                    Platoon= int.Parse(Dt.Rows[i]["Platoon"] +""),
                    DId = int.Parse(Dt.Rows[i]["DId"] + ""),
                    PCarNumber = Dt.Rows[i]["PCarNumber"] + ""
                });
            }
             Db.Close();
            return lstPatzient;
        }
        public static Patzient GetByiD(int Id)
    {
        Patzient tmp = null;

        string Sql = $"select * from t_Patzient where PCId={Id}";

        DbContext Db = new DbContext();
        DataTable Dt = Db.Execute(Sql);

        if (Dt.Rows.Count > 0)
        {
            tmp = new Patzient()
            {
                PCId = (int)Dt.Rows[0]["PCId"],
                PId = Dt.Rows[0]["PId"] + "",
                PFname = Dt.Rows[0]["PFname"] + "",
                PLname = Dt.Rows[0]["PLname"] + "",
                PAddress = Dt.Rows[0]["PAddress"] + "",
                PCity = Dt.Rows[0]["PCity"] + "",
                PAge = float.Parse(Dt.Rows[0]["PAge"] + ""),
                Phone = Dt.Rows[0]["Phone"] + "",
                PGender = int.Parse(Dt.Rows[0]["PGender"] + ""),
                Platoon = int.Parse(Dt.Rows[0]["Platoon"] + ""),
                DId = int.Parse(Dt.Rows[0]["DId"] + ""),
                PCarNumber = Dt.Rows[0]["PCarNumber"] + ""

            };
        }
        Db.Close();
        return tmp;


        }

        public static int DeleteByiD(int Id)
    {
        int RetVal = 0;
        string Sql = $"delete from t_Patzient where PCId={Id}";
        DbContext Db = new DbContext();
        RetVal = Db.ExecuteNonQuery(Sql);
        Db.Close();
        return RetVal;
    }
    } 
}