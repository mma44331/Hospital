using BLL;
using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DAL
{
    public class DepartmentsDAL
    {

        public static void Save(Departments Tmp)
        {
            string Sql = "";
            if (Tmp.DId == -1)
            {
                Sql = $"insert into T_Departments(DName,DHead,DHeadId)";
                Sql += $"values(N'{Tmp.DName}',N'{Tmp.DHead}',{Tmp.DHeadId})";


            }
            else
            {
                Sql = "Update T_Departments set ";
                Sql += $" DName=N'{Tmp.DName}',";
                Sql += $" DHead=N'{Tmp.DHead}',";
                Sql += $" DHeadId={Tmp.DHeadId}";
                Sql += $" Where DId={Tmp.DId}";
            }

            DbContext Db = new DbContext();
            Db.ExecuteNonQuery(Sql);

            if (Tmp.DId == -1)
            {
                Sql = $"select max(DId) from T_Departments Where DName=N'{Tmp.DName}'";

                Tmp.DId = (int)Db.ExecuteScalar(Sql);
            }
            Db.Close();
        }

        public static List<Departments> GetAll()
        {
            List<Departments> lstDepa = new List<Departments>();

            string Sql = "select * from T_Departments";
            DbContext Db = new DbContext();
            DataTable Dt = Db.Execute(Sql);

            //נעבור על טבלת הנתונים שורה שורה נעביר אותם אותם לתוך רשימה של מוצרים

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                lstDepa.Add(new Departments()
                {
                    DId = (int)Dt.Rows[i]["DId"],
                    DName = Dt.Rows[i]["DName"] + "",
                    DHead = Dt.Rows[i]["DHead"] + "",
                    DHeadId =(int) Dt.Rows[i]["DHeadId"],
                });
            }

            Db.Close();
            return lstDepa;

        }
        public static Departments GetByiD(int Id)
        {
            Departments tmp = null;

            string Sql = $"select * from t_Departments where DId={Id}";

            DbContext Db = new DbContext();
            DataTable Dt = Db.Execute(Sql);

            if (Dt.Rows.Count > 0)
            {
                tmp = new Departments()
                {
                    DId = (int)Dt.Rows[0]["DId"],
                    DName = Dt.Rows[0]["DName"] + "",
                    DHead = Dt.Rows[0]["DHead"] + "",
                    DHeadId = (int)Dt.Rows[0]["DHeadId"],
                };
            }
            Db.Close();
            return tmp;


        }

        public static int DeleteByiD(int Id)
        {
            int RetVal = 0;
            string Sql = $"delete from t_Departments where DId={Id}";
            DbContext Db = new DbContext();
            //RetVal = 
                Db.ExecuteNonQuery(Sql);
            Db.Close();
            return RetVal;
        }




    }
}