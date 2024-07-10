using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            DDLDHead.DataTextField = "DFname";
            DDLDHead.DataTextField = "DLname";
            DDLDHead.DataValueField = "Id";       
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
            Departments Tmp=new Departments()
            {
                DId=int.Parse(HidDid.Value),
                DName=TxtDepName.Text,
                DHead=DDLDHead.Text,
            };
            Tmp.Save();
            Response.Redirect("ListDepartments.aspx");


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
        }
    }
}