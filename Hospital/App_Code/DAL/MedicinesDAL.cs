using BLL;
using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DAL
{
    public class MedicinesDAL
    {
        public static void Save(Medicines Tmp)
        {
            string Sql = "";
            if (Tmp.MId == -1)
            {
                Sql = $"insert into T_Medicines(MName,Price)";
                Sql += $"values(N'{Tmp.MName}','{Tmp.Price}')";


            }
            else
            {
                Sql = "Update T_Medicines set ";
                Sql += $" MName= N'{Tmp.MName}',";
                Sql += $" Price='{Tmp.Price}',";
                Sql += $" Where MId={Tmp.MId}";
            }

            DbContext Db = new DbContext();
            Db.ExecuteNonQuery(Sql);

            if (Tmp.MId == -1)
            {
                Sql = $"select max(MId) from T_Medicines where MName='{Tmp.MName}'";

                Tmp.MId = (int)Db.ExecuteScalar(Sql);
            }
            Db.Close();
        }

        public static List<Medicines> GetAll()
        {
            List<Medicines> lstMedicines = new List<Medicines>();

            string Sql = "select * from T_Medicines";
            DbContext Db = new DbContext();
            DataTable Dt = Db.Execute(Sql);

            //נעבור על טבלת הנתונים שורה שורה נעביר אותם אותם לתוך רשימה של מוצרים

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                lstMedicines.Add(new Medicines()
                {
                    MId = (int)Dt.Rows[i]["MId"],
                    MName = Dt.Rows[i]["MName"] + "",
                    Price = float.Parse(Dt.Rows[i]["Price"] + ""),
                   
                });
            }

            Db.Close();
            return lstMedicines;

        }
        public static Medicines GetByiD(int Id)
        {
            Medicines tmp = null;

            string Sql = $"select * from t_Medicines where MId={Id}";

            DbContext Db = new DbContext();
            DataTable Dt = Db.Execute(Sql);

            if (Dt.Rows.Count > 0)
            {
                tmp = new Medicines()
                {
                    MId = int.Parse(Dt.Rows[0]["MId"] + ""),
                    MName = (Dt.Rows[0]["MName"] + ""),
                    Price = float.Parse(Dt.Rows[0]["Price"]+""),                  
                };
            }
            Db.Close();
            return tmp;


        }

        public static int DeleteByiD(int Id)
        {
            int RetVal = 0;
            string Sql = $"delete from t_Medicines where MId={Id}";
            DbContext Db = new DbContext();
            RetVal = Db.ExecuteNonQuery(Sql);
            Db.Close();
            return RetVal;
        }


    }
}