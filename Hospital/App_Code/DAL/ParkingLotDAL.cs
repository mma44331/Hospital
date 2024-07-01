using BLL;
using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DAL
{
    public class ParkingLotDAL
    {
        public static void Save(ParkingLot Tmp)
        {
            string Sql = "";
            if (Tmp.CId == -1)
            {
                Sql = $"insert into T_ParkingLot(CNumber,EntryTime,ReleaseTime)";
                Sql += $"values(N'{Tmp.CNumber}','{Tmp.EntryTime}','{Tmp.ReleaseTime}')";


            }
            else
            {
                Sql = "Update T_ParkingLot set ";
                Sql += $" CNumber=N'{Tmp.CNumber}',";
                Sql += $" EntryTime='{Tmp.EntryTime}',";
                Sql += $" ReleaseTime='{Tmp.ReleaseTime}',";
                Sql += $" Where CId={Tmp.CId}";
            }

            DbContext Db = new DbContext();
            Db.ExecuteNonQuery(Sql);

            if (Tmp.CId == -1)
            {
                Sql = $"select max(CId) from T_ParkingLot where CNumber=N'{Tmp.CNumber}'";

                Tmp.CId = (int)Db.ExecuteScalar(Sql);
            }
            Db.Close();
        }

        public static List<ParkingLot> GetAll()
        {
            List<ParkingLot> lstParkingLot = new List<ParkingLot>();

            string Sql = "select * from T_ParkingLot";
            DbContext Db = new DbContext();
            DataTable Dt = Db.Execute(Sql);

            //נעבור על טבלת הנתונים שורה שורה נעביר אותם אותם לתוך רשימה של מוצרים

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                lstParkingLot.Add(new ParkingLot()
                {
                    CId = (int)Dt.Rows[i]["CId"],
                    CNumber =(Dt.Rows[i]["CNumber"] + ""),
                    EntryTime = DateTime.Parse(Dt.Rows[i]["EntryTime"] + ""),
                    ReleaseTime = DateTime.Parse(Dt.Rows[i]["ReleaseTime"] + ""),


                });
            }

            Db.Close();
            return lstParkingLot;

        }
        public static ParkingLot GetByiD(int Id)
        {
            ParkingLot tmp = null;

            string Sql = $"select * from t_ParkingLot where CId={Id}";

            DbContext Db = new DbContext();
            DataTable Dt = Db.Execute(Sql);

            if (Dt.Rows.Count > 0)
            {
                tmp = new ParkingLot()
                {
                    CId = int .Parse(Dt.Rows[0]["CId"] + ""),
                    CNumber = Dt.Rows[0]["CNumber"] + "",
                    EntryTime = DateTime.Parse(Dt.Rows[0]["EntryTime"] + ""),
                    ReleaseTime = DateTime.Parse(Dt.Rows[0]["ReleaseTime"] + ""),

                };
            }
            Db.Close();
            return tmp;


        }

        public static int DeleteByiD(int Id)
        {
            int RetVal = 0;
            string Sql = $"delete from t_ParkingLot where CId={Id}";
            DbContext Db = new DbContext();
            RetVal = Db.ExecuteNonQuery(Sql);
            Db.Close();
            return RetVal;
        }

    }
}