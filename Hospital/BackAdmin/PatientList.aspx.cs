using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hospital.BackAdmin
{
    public partial class PatzientList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FileData();
            }

        }
        public void FileData()
        {  //כאן ממירים את כל האובייקטים שהיגיעו מהדתהבייס לליסט חדש כדי שנוכל
            //לשתול ערכים חדשים לכל מיני תכונות במידה ורוצים להציג ערכים אחרים ממה שמגיעה מהדתהבייס
            var Lst = Patzient.GetAll();//מה שמגיע מהדתה בייס נכנס למשתנה הנוכחי
            var lstt= Departments.GetAll();
            List<object> list = Lst.Select(x =>new 
            {
                PId=x.PId,
                PFname=x.PFname,
                PLname=x.PLname,
                PCity=x.PCity,
                PAge=x.PAge,
                PGender=(x.PGender==1) ? "נקבה" :"זכר",
                Platoon = lstt.Where(l => l.DId == x.Platoon).ToList()[0].DName,
                PCId=x.PCId
            }).ToList<object>();//ממירים את הערכים/שותלים ערכים חדשים לאובייקט החדש
            RPL.DataSource =list;//מקור הנתונים הוא מהליסת החדש
            RPL.DataBind();//מתחיל להפעיל אותו


        }

    }
}