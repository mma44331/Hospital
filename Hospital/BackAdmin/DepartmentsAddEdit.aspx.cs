using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hospital.BackAdmin
{
    public partial class AddNewDepartments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
                fillData();
            }
        }
        public void fillData()
        {
            Departments Tmp = null;
            string DId = Request["DId"] + "";
            if (string.IsNullOrEmpty(DId))
            {
                DId = "-1";
            }
            else
            {
               Tmp = Departments.GetByiD(int.Parse(DId));
                if (Tmp == null)
                {
                    DId = "-1";
                }
            }
            HidDid.Value = DId;
            DDLDHead.DataSource = Doctors.GetAll();//מקור הנתונים
            DDLDHead.DataTextField = "DLname";
            DDLDHead.DataValueField = "DLname";       
            DDLDHead.DataBind();
            DDLDHead.Items.Insert(0, "בחר ראש מחלקה");
            
            if (Tmp!=null)
            {
                TxtDepName.Text = Tmp.DName;
                DDLDHead.Text= Tmp.DHead;
                DDLDHead.SelectedValue = Tmp.DHeadId+"";
            }
           
        }

        protected void BtnDep_Click(object sender, EventArgs e)
        {
            string Msg = "";
            bool flage=true;
            List<Departments>lst=Departments.GetAll();
            Departments Tmp=new Departments()
            {
                DId=int.Parse(HidDid.Value),
                DName=TxtDepName.Text,
                DHead=DDLDHead.Text,
            };
            for(int i = 0; i < lst.Count; i++)
            {
                if (Tmp.DHead == lst[i].DHead)
                {
                    flage = false;
                    Msg = "הרופא הנוכחי כבר מוגדר למחלקה אחרת<br/>";
                    Msg += "אנא בחר רופא אחר";

                    LtlMsg.Text = Msg;
                    break;
                }
            }//עובר על רשימת המחלקות ובודק אם כבר קיים ראש מחלקה עם אותו שם של המחלקה החדשה
            if (flage == true)
            {
                Tmp.Save();
                Response.Redirect("ListDepartments.aspx");
            }//במידה והוא לא מצא שיש כבר ראש מלחקה כזה אז שישמור את החדש
        }

        protected void BtnDepDel_Click(object sender, EventArgs e)
        {
            Departments Tmp = new Departments()
            {
                DId = int.Parse(HidDid.Value),
                DName = TxtDepName.Text,
                DHead = DDLDHead.Text,
            };
            Departments.DeleteByiD(Tmp.DId);
            Response.Redirect("ListDepartments.aspx");
        }
    }
}