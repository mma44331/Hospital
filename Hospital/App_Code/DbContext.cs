using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace Data
{
    public class DbContext
    {
        public string ConnStr { get; set; }
        public SqlConnection Conn { get; set; }

        public DbContext()
        {
            ConnStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            Conn = new SqlConnection(ConnStr);
            Conn.ConnectionString = ConnStr;
            Conn.Open();

        }
        public DbContext(string ConnStr)
        {
            this.ConnStr = ConnStr;
            SqlConnection Conn = new SqlConnection(ConnStr);
            Conn.ConnectionString = ConnStr;
            Conn.Open();

        }

        public void Close()
        {
            Conn.Close();
        }

        public int ExecuteNonQuery(string Sql)
        {
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            Cmd.CommandText = Sql;

            int RetVal = Cmd.ExecuteNonQuery();//הפונקציה משמשת לשאילתות שלא שולפת נתונים, כגון הוספה מחיקה ועידכון
            Cmd.Dispose();//שחרור הזכרון באופן יזום
            return RetVal;//החזרת מספר הרשומות שהושפעו מהשאילתה
        }

        public object ExecuteScalar(string Sql)
        {
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            Cmd.CommandText = Sql;
            object RetVal = Cmd.ExecuteScalar();//הפונקציה משמשת לשאילתות שלא שולפת נתונים, כגון הוספה מחיקה ועידכון
            Cmd.Dispose();//שחרור הזכרון באופן יזום
            return RetVal;//החזרת מספר הרשומות שהושפעו מהשאילתה
        }

        public DataTable Execute(string Sql)//פונקציה זו תשמש לשלפה של הנתונים
        {
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Conn;//הגדרת צינור בו ישתמש אובייקט הפקודה
            Cmd.CommandText = Sql;//הגדרת השאילתה אותה ברצוננו לבצע
            DataTable Dt = new DataTable();//יצירת אובייקט מסוג טבלת נתונים
            SqlDataAdapter Da = new SqlDataAdapter();//הגדרת אובייקת מסוג מתאם נתונים
            Da.SelectCommand = Cmd;//הגדרת תותח השאילתות אותו יתפעל המתאם
            Da.Fill(Dt);//מילוי טבלח הנתונים בתוצאות שחזרו מהפעלת השאילתה
            return Dt;//החזרת טבלת הנתונים שחזרה מהשאילתה
        }
    }
}
