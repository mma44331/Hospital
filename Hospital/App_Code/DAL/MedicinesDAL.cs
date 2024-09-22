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
                Sql = $"insert into T_Medicines(Mname,Price,MBarCod)";
                Sql += $"values(N'{Tmp.Mname}','{Tmp.Price}',N'{Tmp.MBarCod}')";


            }
            else
            {
                Sql = "Update T_Medicines set ";
                Sql += $" Mname= N'{Tmp.Mname}',";
                Sql += $" Price='{Tmp.Price}',";
                Sql += $" MBarCod= N'{Tmp.MBarCod}'";
                Sql += $" Where MId={Tmp.MId}";
            }

            DbContext Db = new DbContext();
            Db.ExecuteNonQuery(Sql);

            if (Tmp.MId == -1)
            {
                Sql = $"select max(MId) from T_Medicines where Mname='N{Tmp.Mname}'";

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
                    Mname = Dt.Rows[i]["Mname"] + "",
                    Price = float.Parse(Dt.Rows[i]["Price"] + ""),
                    MBarCod = Dt.Rows[i]["MBarCod"] + ""
                });
            }

            Db.Close();
            return lstMedicines;

        }
        public static Medicines GetByiD(int Id)
        {
            Medicines tmp = null;

            string Sql = $"select * from T_Medicines where MId={Id}";

            DbContext Db = new DbContext();
            DataTable Dt = Db.Execute(Sql);

            if (Dt.Rows.Count > 0)
            {
                tmp = new Medicines()
                {
                    MId = int.Parse(Dt.Rows[0]["MId"] + ""),
                    Mname = Dt.Rows[0]["Mname"] + "",
                    Price = float.Parse(Dt.Rows[0]["Price"] + ""),
                    MBarCod = Dt.Rows[0]["MBarCod"] + "",
                };
            }
            Db.Close();
            return tmp;


        }

        public static int DeleteByiD(int Id)
        {
            int RetVal = 0;
            string Sql = $"delete from T_Medicines where MId={Id}";
            DbContext Db = new DbContext();
            RetVal = Db.ExecuteNonQuery(Sql);
            Db.Close();
            return RetVal;
        }


    }
}