using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hospital.BackAdmin
{
    public partial class MedicinesAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FileData();
            }
        }
        public void FileData()
        {

            Medicines Tmp = null;
            string Id = Request["MId"] + "";//מקבל את המספר שנשלח עם הבקשה לדף
            if (string.IsNullOrEmpty(Id))//בודק האם הגיע משהו למשתנה או לא
            {
                Id = "-1";//במידה ולא הגיע שום דבר אז אנחנו במצב של הוספה 
            }
            else
            {
                Tmp = Medicines.GetByiD(int.Parse(Id));//במידה וכן הגיע מספר כלשהוא אז תשלוף את מבסיס הנתונים את הלוקח על פי המספר שהגיע
                if (Tmp == null)
                {
                    Id = "-1";
                }
            }
            HidId.Value = Id;

            if (Tmp != null)
            {
                Mname.Text = Tmp.Mname;
                Price.Text = Tmp.Price + "";
                MBarCod.Text = Tmp.MBarCod;
            }

        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            Medicines Tmp = new Medicines()
            {
                MId = int.Parse(HidId.Value),
                Mname = Mname.Text,
                MBarCod = MBarCod.Text,
                Price = float.Parse(Price.Text)
            };
            Tmp.Save();
            Response.Redirect("MedicinesList.aspx");

        }
    }
}